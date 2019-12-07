using DevOpsPortal.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace DevOpsPortal.Web.Models
{
    public class IdentityManager
    {
        // Swap ApplicationRole for IdentityRole:
        private readonly DevOpsPortalContext _db;

        private readonly RoleManager<ApplicationRole> _roleManager;//= new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>(private new DevOpsPortalContext()));

        private readonly UserManager<ApplicationUser> _userManager;
        public IdentityManager(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager, DevOpsPortalContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }
        public async Task<bool> RoleExists(string name)
        {
            return await _roleManager.RoleExistsAsync(name);
        }

        public async Task<IdentityResult> CreateRole(string name, string description = "")
        {
            // Swap ApplicationRole for IdentityRole:
            return await _roleManager.CreateAsync(new ApplicationRole(name, description));
        }

        public async Task<IdentityResult> CreateUser(ApplicationUser user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<IdentityResult> AddUserToRole(string userId, string roleName)
        {
           var user =  _userManager.FindByIdAsync(userId);
            ApplicationUser userResult = user.Result;
            return await _userManager.AddToRoleAsync(userResult, roleName);
        }


        public void ClearUserRoles(string userId)
        {
            var user = _userManager.FindByIdAsync(userId);
            ApplicationUser applicationUser = user.Result;
            var currentRoles = new List<ApplicationRoleGroup>();
            currentRoles.AddRange(applicationUser.Roles);
            foreach (ApplicationRoleGroup role in currentRoles)
            {
                _userManager.RemoveFromRoleAsync(applicationUser, role.Role.ToString());
            }
        }

        public void RemoveFromRole(string userId, string roleName)
        {
            var user = _userManager.FindByIdAsync(userId);
            ApplicationUser applicationUser = user.Result;
            _userManager.RemoveFromRoleAsync(applicationUser, roleName);
        }

        public void DeleteRole(string roleId)
        {
            IQueryable<ApplicationUser> roleUsers = _db.Users.Where(u => u.Roles.Any(r => r.RoleId == roleId));
            ApplicationRole role = _db.Roles.Find(roleId);

            foreach (ApplicationUser user in roleUsers)
            {
                RemoveFromRole(user.Id, role.Name);
            }
            _db.Roles.Remove(role);
            _db.SaveChanges();
        }

        public void CreateGroup(string groupName)
        {
            if (GroupNameExists(groupName))
            {
                throw new GroupExistsException(
                    "A group by that name already exists in the database. Please choose another name.");
            }

            var newGroup = new Group(groupName);
            _db.Groups.Add(newGroup);
            _db.SaveChanges();
        }

        public bool GroupNameExists(string groupName)
        {
            return _db.Groups.Any(gr => gr.Name == groupName);
        }

        public bool UserExists(string username)
        {
            return _db.Users.Any(gr => gr.UserName == username);
        }

        public void ClearUserGroups(string userId)
        {
            ClearUserRoles(userId);
            ApplicationUser user = _db.Users.Find(userId);
            user.Groups.Clear();
            _db.SaveChanges();
        }

        public void AddUserToGroup(string userId, int groupId)
        {
            Group group = _db.Groups.Find(groupId);
            ApplicationUser user = _db.Users.Find(userId);

            var userGroup = new ApplicationUserGroup
            {
                Group = group,
                GroupId = group.Id,
                User = user,
                UserId = user.Id
            };

            foreach (ApplicationRoleGroup role in group.Roles)
            {
                _userManager.AddToRoleAsync(user, role.Role.Name);
            }


            user.Groups.Add(userGroup);


            _db.SaveChanges();
        }




        public void ClearGroupRoles(int groupId)
        {
            Group group = _db.Groups.Find(groupId);
            IQueryable<ApplicationUser> groupUsers = _db.Users.Where(u => u.Groups.Any(g => g.GroupId == group.Id));

            foreach (ApplicationRoleGroup role in group.Roles)
            {
                string currentRoleId = role.RoleId;
                foreach (ApplicationUser user in groupUsers)
                {
                    // Is the user a member of any other groups with this role?
                    int groupsWithRole = user.Groups.Count(g => g.Group.Roles.Any(r => r.RoleId == currentRoleId));

                    // This will be 1 if the current group is the only one:
                    if (groupsWithRole == 1)
                    {
                        RemoveFromRole(user.Id, role.Role.Name);
                    }
                }
            }
            group.Roles.Clear();
            _db.SaveChanges();
        }

        public void AddRoleToGroup(int groupId, string roleName)
        {
            Group group = _db.Groups.Find(groupId);
            ApplicationRole role = _db.Roles.First(r => r.Name == roleName);

            var newgroupRole = new ApplicationRoleGroup
            {
                //GroupId = group.Id,
                //Group = group,
                //RoleId = role.Id,
                //Role = role

                GroupId = groupId,
                Group = group,
                RoleId = role.Id,
                Role = role
            };

            // make sure the groupRole is not already present
            if (!group.Roles.Contains(newgroupRole))
            {
                group.Roles.Add(newgroupRole);
                _db.SaveChanges();
            }

            // Add all of the users in this group to the new role:
            IQueryable<ApplicationUser> groupUsers = _db.Users.Where(u => u.Groups.Any(g => g.GroupId == group.Id));
            foreach (ApplicationUser user in groupUsers)
            {
                if (!(_userManager.IsInRoleAsync(user, roleName).Result))
                {
                     AddUserToRole(user.Id, role.Name);
                }
            }
        }

        public void DeleteGroup(int groupId)
        {
            Group group = _db.Groups.Find(groupId);

            // Clear the roles from the group:
            ClearGroupRoles(groupId);
            _db.Groups.Remove(group);
            _db.SaveChanges();
        }
    }

    [Serializable]
    public class GroupExistsException : Exception
    {
        public GroupExistsException()
        {
        }

        public GroupExistsException(string message) : base(message)
        {
        }

        public GroupExistsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected GroupExistsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevOpsSolution.Models
{

    public class SelectUserGroupsViewModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<SelectGroupEditorViewModel> Groups { get; set; }

        public SelectUserGroupsViewModel()
        {
            this.Groups = new List<SelectGroupEditorViewModel>();
        }

        public SelectUserGroupsViewModel(ApplicationUser user, string defaultuserid,string defaultusername)
            : this()
        {
            this.UserName = user.UserName;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;

           // var Db = new DevOpsPortalContext();

           
           // // Add all available groups to the public list:
           //if(user.OrgId == 1)
           //     {

           //     var allGroups = Db.Groups;
           //     foreach (var role in allGroups)
           //     {
           //         // An EditorViewModel will be used by Editor Template:
           //         var rvm = new SelectGroupEditorViewModel(role);
           //         this.Groups.Add(rvm);
           //     }

           //     // Set the Selected property to true where user is already a member:
           //     foreach (var group in user.Groups)
           //     {
           //         var checkUserRole =
           //             this.Groups.Find(r => r.GroupName == group.Group.Name);
           //         checkUserRole.Selected = true;
           //     }
           // }
           // else if((user.OrgId !=1))
           // {
           //     string sql = "select * from Groups where Name not in ('SuperAdmins', 'GroupAdmins', 'UserAdmins')";
           //     var allGroups = from b in Db.Groups.SqlQuery(sql)
           //                     select b;
           //     foreach (var role in allGroups)
           //     {
           //         // An EditorViewModel will be used by Editor Template:
           //         var rvm = new SelectGroupEditorViewModel(role);
           //         this.Groups.Add(rvm);
           //     }

           //     // Set the Selected property to true where user is already a member:
           //     foreach (var group in user.Groups)
           //     {
           //         var checkUserRole =
           //             this.Groups.Find(r => r.GroupName == group.Group.Name);
           //         checkUserRole.Selected = true;
           //     }
           // }



            
        }
    }


}

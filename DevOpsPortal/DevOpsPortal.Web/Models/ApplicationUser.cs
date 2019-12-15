using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DevOpsPortal.Data
{
    public class ApplicationUser :IdentityUser
    {
        public ApplicationUser()
           : base()
        {
            this.Groups = new HashSet<ApplicationUserGroup>();
            this.Roles = new HashSet<ApplicationRoleGroup>();
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public override string Email { get; set; }


        [Required]
        public int OrgId { get; set; }

        public int? OrgLevelTypeId { get; set; }

        // [Required] -- made it optional
        public int? OrgLevelid { get; set; }

        public bool User_Active { get; set; }

        public bool IsPasswordReset { get; set; }
        public virtual ICollection<ApplicationUserGroup> Groups { get; set; }
        public virtual ICollection<ApplicationRoleGroup> Roles { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}

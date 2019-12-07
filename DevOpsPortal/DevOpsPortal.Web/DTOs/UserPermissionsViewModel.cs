using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace DevOpsSolution.Models
{

    public class UserPermissionsViewModel
    {
        public UserPermissionsViewModel()
        {
            this.Roles = new List<RoleViewModel>();
        }


        // Enable initialization with an instance of ApplicationUser:
        public UserPermissionsViewModel(ApplicationUser user)
            : this()
        {
            this.UserName = user.UserName;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;

            //foreach (var role in user.Groups)
            //{
            //    var appRole = role.Group;
            //    var pvm = new RoleViewModel(appRole);
            //    this.Roles.Add(pvm);
            //}
        }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public List<RoleViewModel> Roles { get; set; }
    }


}

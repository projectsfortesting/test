using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace DevOpsSolution.Models
{
    public class OrgHierarchyLevelUsersViewModel
    {
        public bool Selected { get; set; }
        public string UserName { get; set; }

       
        public string FirstName { get; set; }

       
        public string LastName { get; set; }

   
        public string Email { get; set; }

        public string userid { get; set; }
              
        public int OrgId { get; set; }

        public int OrgLevelTypeId { get; set; }

       //this is id column mapping to orgheirarchylevelusers table.
        public int OrgLevelid { get; set; }

        public bool isAdmin { get; set; }

        public string projectname { get; set; }

        public int orghid { get; set; }
    }
}
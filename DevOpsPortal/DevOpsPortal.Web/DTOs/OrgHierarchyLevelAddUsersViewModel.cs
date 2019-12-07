using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// New namespace imports:



namespace DevOpsSolution.Models
{
    public class OrgHierarchyLevelAddUsersViewModel
    {
        public List<OrgHierarchyLevelUsersViewModel> userslist { get; set; }
              
        public int OrgId { get; set; }

        public int OrgLevelTypeId { get; set; }

       //this is id column mapping to orgheirarchylevelusers table.
        public int OrgLevelid { get; set; }

        public string searchstring { get; set; }

        public string projectname { get; set; }

    }
}
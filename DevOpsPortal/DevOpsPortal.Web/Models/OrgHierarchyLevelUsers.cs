
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DevOpsPortal.Data
{
    public class OrgHierarchyLevelsUsers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int orghid { get; set; }
        public int Id { get; set; }

        public int Org_Id { get; set; }     

        public string Name { get; set; }

        public string userid { get; set; }

        public string username { get; set; }

        public int OrgLevelTypeId { get; set; }

        public bool isadmin { get; set; }
       //public virtual OrgLevels projectOrgLevelTypes { get; set; }
        //public virtual Organizations Org { get; set; }

    }

}

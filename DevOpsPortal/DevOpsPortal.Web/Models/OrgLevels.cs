
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
    public class OrgLevels
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public int Org_Id { get; set; }

        public int ParentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int OrgLevelTypeId { get; set; }
        
        public string orgleveladminId { get; set; }

        public bool ORG_LEVEL_ACTIVE { get; set; }

        public string ORG_CREATED_BY { get; set; }

        public DateTime? ORG_CREATED_DATE { get; set; }

        public string ORG_MODIFIED_BY { get; set; }

        public DateTime? ORG_MODIFIED_DATE { get; set; }

        public virtual OrgLevelTypes OrgLevelTypes { get; set; }

        public virtual Organizations Org { get; set; }

    }

}

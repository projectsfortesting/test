
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
    public class Organizations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int OrgId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string ORG_CREATED_BY { get; set; }

        public DateTime? ORG_CREATED_DATE { get; set; }

        public string ORG_MODIFIED_BY { get; set; }

        public DateTime? ORG_MODIFIED_DATE { get; set; }
        public bool ORG_LEVEL_ACTIVE { get; set; }

    }

}

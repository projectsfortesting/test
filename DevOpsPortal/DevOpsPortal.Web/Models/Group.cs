﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevOpsPortal.Data
{
    public class Group
    {
        public Group()
        {
        }


        public Group(string name) : this()
        {
            Roles = new List<ApplicationRoleGroup>();
            Name = name;
        }


        [Key]
        [Required]
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

      
        public virtual ICollection<ApplicationRoleGroup> Roles { get; set; }
    }
}
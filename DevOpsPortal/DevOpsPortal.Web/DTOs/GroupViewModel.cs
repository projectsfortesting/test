using System.ComponentModel.DataAnnotations;

// New namespace imports:
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevOpsSolution.Models
{
    public class GroupViewModel
    {
        public List<Group> grplist { get; set; }
        public Group group { get; set; }
    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevOpsSolution.Models
{

    public class SelectGroupEditorViewModel
    {
        public SelectGroupEditorViewModel() { }
        public SelectGroupEditorViewModel(Group group)
        {
            this.GroupName = group.Name;
            this.GroupId = group.Id;
        }

        public bool Selected { get; set; }

        [Required]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }


}

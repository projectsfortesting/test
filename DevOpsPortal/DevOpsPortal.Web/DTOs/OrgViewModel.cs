using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevOpsSolution.Models
{
    public class OrgViewModel
    {
        public List<Organizations> orgslist { get; set; }
        public int OrgId { get; set; } //selectedanswer for orgn

        public int BunitId { get; set; } //selectedanswer for BU

        public int SBUnitId { get; set; } //selectedanswer for SBU

        public int ProjectId { get; set; } //selectedanswer for SBU

        public List<SelectListItem> Organizations { get; set; }

        public List<SelectListItem> BusinessUnits { get; set; }

        public List<SelectListItem> SBUnits { get; set; }

        public Organizations org { get; set; }
        public List<OrgLevels> orglevelslist { get; set; } // to list business units

        public List<OrgLevels> SubBusinessUnits { get; set; } // to list subbusiness units
                                                              //to add pjtunits 
        public List<OrgLevels> projects { get; set; } // to list projects

        public List<OrgLevelTypes> orgLevelTypes { get; set; }
        public OrgLevels orgLevel { get; set; } // for business unit
        public OrgLevels subBusinessUnit { get; set; }// for subbusiness unit

        public OrgLevels project { get; set; }// for project unit

        //to test --- adding sbuviewmodel
        public SBUViewModel sbuviewmodel { get; set; }

        public bool IsProjHasChild { get; set; }
    }
}
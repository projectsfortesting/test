using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevOpsSolution.Models
{
    public class SBUViewModel
    {
        public List<Organizations> sbu_orgslist { get; set; }

        public List<OrgLevels> sbu_orglevelslist { get; set; } // to list business units

        public List<OrgLevels> sbu_SubBusinessUnits { get; set; } // to list subbusiness units
                                                                  //to add pjtunits 

        public int sbu_OrgId { get; set; } //selectedanswer for orgn

        public int sbu_BunitId { get; set; } //selectedanswer for BU

        public int sbu_SBUnitId { get; set; } //selectedanswer for SBU

        public List<SelectListItem> sbu_Organizations { get; set; }

        public List<SelectListItem> sbu_BusinessUnits { get; set; }   
          
           
        public OrgLevels subBusinessUnit { get; set; }// for subbusiness unit

    }
}
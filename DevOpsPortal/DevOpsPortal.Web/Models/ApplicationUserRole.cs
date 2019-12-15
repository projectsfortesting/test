using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DevOpsPortal.Data
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public ApplicationUserRole()
        {

        }

        //public virtual ApplicationUser User { get; set; }

        //public virtual ApplicationRole Role { get; set; }
    }
}
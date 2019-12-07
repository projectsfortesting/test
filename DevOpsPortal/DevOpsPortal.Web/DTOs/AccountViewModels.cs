using System.ComponentModel.DataAnnotations;

// New namespace imports:
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using DevOpsPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevOpsSolution.Models
{
    public class ManageUserViewModel
    {
        [Required(ErrorMessage = "Current Password is required.")]
        [Remote("IsValidPassword", "Account", HttpMethod = "POST", ErrorMessage = "Current Password entered is wrong. Please enter correct current password !")]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "New Password is required.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,12}$",
            ErrorMessage = "The Password must be 8 to 12 characters long & it should have at least One Lower case Letter, One Upper case Letter, One Number and One Special Character.")]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage =
            "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }


    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }


    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,12}$",
            ErrorMessage = "The New Password must be 8 to 12 characters long & it should have at least One Lower case Letter, One Upper case Letter, One Number and One Special Character.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage =
            "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        // New Fields added to extend Application User class:

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Please enter a valid Email Address")]
        public string Email { get; set; }

        [Required]
        public int OrgId { get; set; } //selectedanswer for orgn


        public int? OrgLevelTypeId { get; set; } //selectedanswer for orgLevelTypeId

        // [Required]
        public int? OrgLevelid { get; set; }  //selectedanswer for orgLevelid

        public bool User_Active { get; set; }

        // Return a pre-poulated instance of AppliationUser:
        public ApplicationUser GetUser()
        {
            var user = new ApplicationUser()
            {
                UserName = this.UserName,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                OrgId = this.OrgId,
                OrgLevelTypeId = this.OrgLevelTypeId,
                OrgLevelid = this.OrgLevelid,
                User_Active = true//this.User_Active //modified by CS on 12.03.2018. Due to created user is not active before.
            };
            return user;
        }

        public List<SelectListItem> Organizations { get; set; }

        public List<SelectListItem> orgLevelTypes { get; set; }

        public List<SelectListItem> orgUnits { get; set; }
    }



    public class EditUserViewModel
    {
        public EditUserViewModel() { }

        // Allow Initialization with an instance of ApplicationUser:
        public EditUserViewModel(ApplicationUser user)
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Email = user.Email;
            this.OrgId = user.OrgId;
            this.OrgLevelTypeId = user.OrgLevelTypeId ?? 1;
            this.OrgLevelid = user.OrgLevelid ?? user.OrgId;      //making the orglevel id, org leveltype id optional, hence orglevelid will be orgid, incase if orglevelid is null.      
            this.User_Active = user.User_Active;
        }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid Email Address")]
        public string Email { get; set; }

        [Required]
        public int OrgId { get; set; }

        public string Id { get; set; }

        public int OrgLevelTypeId { get; set; }


        public int? OrgLevelid { get; set; }

        public bool User_Active { get; set; }

        public List<SelectListItem> Organizations { get; set; }

        public List<SelectListItem> orgLevelTypes { get; set; }

        public List<SelectListItem> orgUnits { get; set; }
    }

}


// Used to display a single role with a checkbox, within a list structure:











// Wrapper for SelectGroupEditorViewModel to select user group membership:



// Used to display a single role group with a checkbox, within a list structure:








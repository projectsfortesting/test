using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Net.Mail;
using System.Web;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity.Owin;
//using Microsoft.OwinCore.Security;
//using DevOpsSolution.Models;
using DevOpsPortal.Data;
using Microsoft.EntityFrameworkCore;
using DevOpsSolution.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
//using DevOpsPortal.Web.CustomFilters;


namespace DevOpsSolution.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private DevOpsPortalContext _db;
        private UserManager<ApplicationUser> UserManager;
        public AccountController(DevOpsPortalContext context, UserManager<ApplicationUser> _UserManager)
        {
            _db = context;
            UserManager = _UserManager; 
        }
        // Private IUserManager _UserManager;
        //public AccountController()
        //    : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new DevOpsPortalContext())))
        //{

        //}

        //  public UserManager<ApplicationUser> UserManager  { get; private set; }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            //if (Request.IsAuthenticated == true)
            //{
            //    return RedirectToAction("Index", "AdminLte");
            //}

            ViewBag.ReturnUrl = returnUrl;
            //  return View();
            return PartialView();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByLoginAsync(model.UserName, model.Password);
                 user = await UserManager.FindByIdAsync("57fd6f01-4823-4e05-82fb-cf2a1b1934d7");
                //("094f3943-725a-4f0e-9f5c-b18c205bed52");// ("PlainVanillaUser");// 
                if (user != null)
                {
                    var roles =(from x in _db.Roles
                                 join y in _db.UserRoles on x.Id equals y.RoleId
                                 where y.UserId == user.Id
                                 select x).ToList();

                    await SignInAsync(user, model.RememberMe);
                    return RedirectToLocal(returnUrl);

                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                    return PartialView("Login");
                }

            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        // [Authorize(Roles = "Admin, CanEditUser")]
        ////[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins")]
        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        public ActionResult Register()
        {
            RegisterViewModel newuser = new RegisterViewModel();

            string userid = string.Empty;
            string username = string.Empty;

            if (User.Identity.IsAuthenticated)
            {
                //userid = User.Identity,();
                username = User.Identity.Name;
            }
            var usrOrgdetail = (from b in _db.Users
                                where b.Id == userid
                                select b).FirstOrDefault();
            int _usrorgid = usrOrgdetail.OrgId;

            string defaultusrId = (from b in _db.Users
                                   where b.UserName == "defaultadmin" && b.OrgId == 1
                                   select b.Id).FirstOrDefault();


            if (username == "defaultadmin" && userid == defaultusrId)
            {

                //get orgn and org levels
                var organization = from b in _db.Organizations
                                   select new SelectListItem()
                                   {
                                       Text = b.Name,
                                       Value = b.OrgId.ToString()
                                   };
                var orgLevelTypes = from b in _db.OrgLevelTypes
                                    select new SelectListItem()
                                    {
                                        Text = b.Name,
                                        Value = b.typeId.ToString()
                                    };
                newuser.Organizations = organization.ToList();
                newuser.orgLevelTypes = orgLevelTypes.ToList();
            }
            else
            {
                //get orgn and org levels
                var organization = from b in _db.Organizations
                                   where b.OrgId == _usrorgid
                                   select new SelectListItem()
                                   {
                                       Text = b.Name,
                                       Value = b.OrgId.ToString()
                                   };
                var orgLevelTypes = from b in _db.OrgLevelTypes

                                    select new SelectListItem()
                                    {
                                        Text = b.Name,
                                        Value = b.typeId.ToString()
                                    };
                newuser.Organizations = organization.ToList();
                newuser.orgLevelTypes = orgLevelTypes.ToList();
            }

            return View(newuser);
        }

        private static void SendEmail(ApplicationUser user, RegisterViewModel model)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(model.Email);

            System.Security.SecureString password = new System.Security.SecureString();
            password.AppendChar('a');
            password.AppendChar('p');
            password.AppendChar('r');
            password.AppendChar('@');
            password.AppendChar('2');
            password.AppendChar('0');
            password.AppendChar('1');
            password.AppendChar('8');

            mail.From = new MailAddress("ramanathanso@hcl.com");
            mail.Subject = "Consultant User Account Created";
            string Body = "Hi " + model.FirstName + ",\n " + Environment.NewLine + "A Consultant user account has been created for you\n" + Environment.NewLine + "URL: http://azurepocvm.eastus.cloudapp.azure.com/RapidPortaldev/" + Environment.NewLine + Environment.NewLine + "UserName:" + model.UserName
                + Environment.NewLine + "Password:" + model.Password + Environment.NewLine + "\nThanks" + Environment.NewLine + "DevopsCOE Team";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "chn-hclt-csht01.hclt.corp.hcl.in"; //Or Your SMTP Server Address
            smtp.Port = 25;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential
            ("ramanathanso", password, "hcltech");
            smtp.EnableSsl = false;
            smtp.Send(mail);
        }

        // [Authorize(Roles = "Admin, CanEditUser")]
        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        public JsonResult GetOrgUnits(int orgId, int orgleveltypeid)
        {
            var orgunits = _db.OrgLevels.Where(c => c.OrgLevelTypeId == orgleveltypeid && c.Org_Id == orgId);
            return Json(orgunits);//, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        // [Authorize(Roles = "Admin, CanEditUser")]
        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = model.GetUser();
                user.User_Active = true;
                //get organization level details
                var result = await UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // SendEmail(user, model);
                    //return RedirectToAction("Index", "Account");
                    return RedirectToAction("Index", "AdminLte");
                }

            }
            //get orgn and org levels
            var organization = from b in _db.Organizations
                               select new SelectListItem()
                               {
                                   Text = b.Name,
                                   Value = b.OrgId.ToString()
                               };
            var orgLevelTypes = from b in _db.OrgLevelTypes
                                select new SelectListItem()
                                {
                                    Text = b.Name,
                                    Value = b.typeId.ToString()

                                };

            model.Organizations = organization.ToList();
            model.orgLevelTypes = orgLevelTypes.ToList();

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels,User")]

        public ActionResult Manage(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
                : message == ManageMessageId.Error ? "An error has occurred."
                : "";
            ViewBag.HasLocalPassword = HasPassword();
            ViewBag.ReturnUrl = Url.Action("Manage");
            return View("Manage");
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        ////[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels,User")]
        //public async Task<ActionResult> Manage(ManageUserViewModel model)
        //{
        //    bool hasPassword = HasPassword();
        //    ViewBag.HasLocalPassword = hasPassword;
        //    ViewBag.ReturnUrl = Url.Action("Manage");
        //    if (hasPassword)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            IdentityResult result = await UserManager.ChangePasswordAsync(User.Identity, model.OldPassword, model.NewPassword);
        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Manage", new { Message = ManageMessageId.ChangePasswordSuccess });
        //            }
        //            else
        //            {
        //                AddErrors(result);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        // User does not have a password so remove any validation errors caused by a missing OldPassword field
        //        //ModelState state = ModelState["OldPassword"];
        //        //if (state != null)
        //        //{
        //        //    state.Errors.Clear();
        //        //}

        //        if (ModelState.IsValid)
        //        {
        //            IdentityResult result = await UserManager.AddPasswordAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier);, model.NewPassword);
        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Manage", new { Message = ManageMessageId.SetPasswordSuccess });
        //            }
        //            else
        //            {
        //                AddErrors(result);
        //            }
        //        }
        //    }

        //    // If we got this far, something failed, redisplay form
        //    return View(model);
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //Session.Abandon();
            //Session.RemoveAll();
            HttpContext.SignOutAsync();
            //AuthenticationManager.SignOut();
            // return RedirectToAction("Index", "Home");
            return RedirectToAction("Login", "Account");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing && UserManager != null)
            {
                UserManager.Dispose();
                UserManager = null;
            }
            base.Dispose(disposing);
        }



        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        public ActionResult Index()
        {
            string userid = string.Empty;
            string username = string.Empty;

            if (User.Identity.IsAuthenticated)
            {
                userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                username = User.Identity.Name;
            }
            var usrOrgdetail = (from b in _db.Users
                                where b.Id == userid
                                select b).FirstOrDefault();
            int _usrorgid = usrOrgdetail.OrgId;

            string defaultusrId = (from b in _db.Users
                                   where b.UserName == "defaultadmin" && b.OrgId == 1
                                   select b.Id).FirstOrDefault();



            var model = new List<EditUserViewModel>();
            if (username == "defaultadmin" && userid == defaultusrId)
            {
                var users = _db.Users;
                foreach (var user in users)
                {
                    var u = new EditUserViewModel(user);
                    model.Add(u);
                }
            }
            else
            {
                var users = _db.Users.Where(p => p.OrgId == _usrorgid);
                foreach (var user in users)
                {
                    var u = new EditUserViewModel(user);
                    model.Add(u);
                }
            }

            return View(model);
        }

        [HttpGet]

        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        public ActionResult Edit(string id, ManageMessageId? Message = null)
        {
            var user = _db.Users.First(u => u.UserName == id);

            string userid = string.Empty;
            string username = string.Empty;

            if (User.Identity.IsAuthenticated)
            {
               userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
                username = User.Identity.Name;
            }
            var usrOrgdetail = (from b in _db.Users
                                where b.Id == userid
                                select b).FirstOrDefault();
            int _usrorgid = usrOrgdetail.OrgId;

            string defaultusrId = (from b in _db.Users
                                   where b.UserName == "defaultadmin" && b.OrgId == 1
                                   select b.Id).FirstOrDefault();
            EditUserViewModel editUser = new EditUserViewModel(user);
            if (username == "defaultadmin" && userid == defaultusrId)
            {

                var organization = from b in _db.Organizations
                                   select new SelectListItem()
                                   {
                                       Text = b.Name,
                                       Value = b.OrgId.ToString()
                                   };
                editUser.Organizations = organization.ToList();
            }
            else
            {
                var organization = from b in _db.Organizations
                                   where b.OrgId == _usrorgid
                                   select new SelectListItem()
                                   {
                                       Text = b.Name,
                                       Value = b.OrgId.ToString()
                                   };
                editUser.Organizations = organization.ToList();
            }
            var orgLevelTypes = from b in _db.OrgLevelTypes
                                select new SelectListItem()
                                {
                                    Text = b.Name,
                                    Value = b.typeId.ToString()
                                };

            //var model = new EditUserViewModel(user);


            editUser.orgLevelTypes = orgLevelTypes.ToList();

            ViewBag.MessageId = Message;
            return View(editUser);
        }


        [HttpPost]

        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                // var user = _db.Users.First(u => u.UserName == model.UserName);
                var user = _db.Users.First(u => u.Id == model.Id);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;
                user.UserName = model.UserName;
                //user.OrgName = model.OrgName;
                // user.OrgId = model.
                user.OrgLevelid = model.OrgLevelid;
                user.User_Active = true;//model.User_Active;
             //   _db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }



        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        public ActionResult Delete(string id = null)
        {
            var user = _db.Users.First(u => u.UserName == id);
            var model = new EditUserViewModel(user);
            if (user == null)
            {
               // return HttpNotFound();
            }
            return View(model);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        public ActionResult DeleteConfirmed(string id)
        {
            var user = _db.Users.First(u => u.UserName == id);
            _db.Users.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        public ActionResult UserGroups(string id)
        {
            string userid = string.Empty;
            string username = string.Empty;

            if (User.Identity.IsAuthenticated)
            {
                userid = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                username = User.Identity.Name;
            }
            var usrOrgdetail = (from b in _db.Users
                                where b.Id == userid
                                select b).FirstOrDefault();
            int _usrorgid = usrOrgdetail.OrgId;

            string defaultusrId = (from b in _db.Users
                                   where b.UserName == "defaultadmin" && b.OrgId == 1
                                   select b.Id).FirstOrDefault();

            //need to check the userid and restrict the organization add button based on user. 
            //TempData["defaultadminUserId"] = defaultusrId;
            //TempData["defaultUserName"] = "defaultadmin";

            //TempData["currentUserId"] = userid;
            //TempData["currentUserName"] = username;


            var user = _db.Users.First(u => u.UserName == id);
            var model = new SelectUserGroupsViewModel(user, defaultusrId, "defaultadmin");
            return View(model);
        }


        [HttpPost]
        // //[AuthLog(Groups = "UserAdmins,GroupAdmins,SuperAdmins,DevOpsAdmins")]
        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]
        [ValidateAntiForgeryToken]
        public ActionResult UserGroups(SelectUserGroupsViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var idManager = new IdentityManager();
                var user = _db.Users.First(u => u.UserName == model.UserName);
               // idManager.ClearUserGroups(user.Id);
                foreach (var group in model.Groups)
                {
                    if (group.Selected)
                    {
                     //   idManager.AddUserToGroup(user.Id, group.GroupId);
                    }
                }
                return RedirectToAction("index");
            }
            return View();
        }

        // //[AuthLog(Groups = "UserAdmins,GroupAdmins,SuperAdmins,DevOpsAdmins")]
        //[AuthLog(Groups = "UserAdmins,SuperAdmins,DevOpsAdmins,OrgnAdmins", Roles = "Admin, CanEditUser,CanEditOrgLevels")]

        public ActionResult UserPermissions(string id)
        {
            var user = _db.Users.First(u => u.UserName == id);
            var model = new UserPermissionsViewModel(user);
            return View(model);
        }


        #region Helpers

        private AuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Authentication;
            }
        }


     private async Task SignInAsync(ApplicationUser user, bool isPersistent)
     {
            try
            {
                var identity = new ClaimsIdentity();
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal, new Microsoft.AspNetCore.Authentication.AuthenticationProperties { IsPersistent = isPersistent });

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            //AuthenticationManager.SignOutAsync(DefaultAuthenticationTypes.ExternalCookie);
      //      var identity = new ClaimsPrincipal();// await UserManager.C(user, DefaultAuthenticationTypes.ApplicationCookie);
       // await AuthenticationManager.SignInAsync(/*(new AuthenticationProperties() { IsPersistent = isPersistent }*/"",identity);
     }


        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
               // ModelState.AddModelError("", error,);
            }
        }


        private bool HasPassword()
        {
           var user = UserManager.FindByIdAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));
           if (user != null)
           {
               return user.Result.PasswordHash != null;
           }
            return false;
        }


        public enum ManageMessageId
        {
            ChangePasswordSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            Error
        }


        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            // return RedirectToAction("Index", "Home");
            return RedirectToAction("Index", "AdminLte");
        }


        [HttpPost]
        public JsonResult IsValidPassword(string OldPassword)
        {
            bool passwordCheck = UserManager.CheckPasswordAsync(UserManager.FindByIdAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier)).Result,OldPassword).Result;

            return Json(passwordCheck);

        }
       #endregion
    }
}
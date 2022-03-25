using HelloAguekeng.BLL;
using HelloAguekeng.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HelloAguekeng.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager userManager;
        public AccountController()
        {
            this.userManager = new UserManager();
        }
        // GET: Account
        public ActionResult Index(string returnUrl = null)
        {
            var model = new LoginModel { ReturnUrl = returnUrl };
            return View(model);
        }
        // GET: Account
        public ActionResult Login()
        {

            return RedirectToAction("Index");
            //return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            try
            {
                var user = userManager.AuthenticateUser(model.UserName, model.Password);
                FormsAuthentication.SetAuthCookie(user.UserName, model.RememberMe);
                if (!string.IsNullOrEmpty(model.ReturnUrl))
                    return Redirect(model.ReturnUrl);
                return RedirectToAction("Index","Home");
            }
            catch (KeyNotFoundException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occured. Please  try again later !");
                Console.Error.WriteLine($"--->{ex.Message}");
            }
            return View("Index", model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index"); 
        }
    }
}
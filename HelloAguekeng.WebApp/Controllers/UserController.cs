using HelloAguekeng.BLL;
using HelloAguekeng.BO;
using HelloAguekeng.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloAguekeng.WebApp.Controllers
{
    public class UserController : Controller
    {
        private UserManager userManager;
        // GET: User
        public UserController()
        {
            userManager = new UserManager();
        }
        public ActionResult Index()
        {
            var users = userManager.FindUser();
            var userModels = users?.Select
                (
                    x =>
                    new UserModel
                    (
                        x.Id,
                        x.UserName,
                        x.Password,
                        x.Password,
                        x.FullName,
                        (DateTime)x.CreatedAT,
                        (bool)x.Statues,
                        x.Profile.ToString(),
                        Url.Action("Picture", "User", new { id = x.Id })
                    )
                ).ToList();
            return View(userModels);
        }
        public ActionResult Edit(int id)
        {
            var userModel = new UserModel
            {
                Status = true,
                ProfileSelectedValue = (int)BO.User.ProfileOptions.Visitor,
                Profiles = GetUserProfiles()
            };
            return View("Edit", userModel);

        }

        [HttpPost]
        public ActionResult Edit(int id, UserModel model)
        {
            var user = userManager.GetUser(id);
            if (user == null)
                return HttpNotFound();
            byte[] picture = new byte[model.Image.ContentLength];
            if (model.Image != null && model.Image.ContentLength > 0)
            {
                model.Image.InputStream.Read(picture, 0, model.Image.ContentLength);
            }
            else
            {
                picture = user.Picture;
            }
            user = new User
               (
                   id,
                   model.UserName,
                   model.Password,
                   model.FullName,
                   (BO.User.ProfileOptions)model.ProfileSelectedValue,
                   (bool)model.Status,
                   picture,
                   (DateTime)user.CreatedAT
               );
            userManager.EditUser(user);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var user = userManager.GetUser(id);
            if (user == null)
                return HttpNotFound();
            var userModel = new UserModel
                (
                    user.Id,
                    user.UserName,
                    user.Password,
                    user.Password,
                    user.FullName,
                    (DateTime)user.CreatedAT,
                    (bool)user.Statues,
                    user.Profile.ToString(),
                    user.Picture != null ? Url.Action("Picture", "User", new { id = user.Id }) : null
                );

            return View(userModel);
        }
        public FileContentResult Picture(int id)
        {
            var user = userManager.GetUser(id);
            if(user != null && user.Picture != null)
            {
                return File(user.Picture, "image/jpg");
            }
            return null;
        }

        public ActionResult Delete(int id)
        {
            userManager.DeleteUser(id);
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {

            var userModel = new UserModel
            {
                Status = true,
                ProfileSelectedValue = (int)BO.User.ProfileOptions.Visitor,
                Profiles = GetUserProfiles()
            };
            return View("Edit", userModel); 
        }


        [HttpPost]
        public ActionResult Create(UserModel model)
        {
            byte[] picture = new byte[model.Image.ContentLength];
            if (model.Image != null && model.Image.ContentLength > 0)
            {
                model.Image.InputStream.Read(picture, 0, model.Image.ContentLength);
            }
            else
            {
                picture = null;
            }
            var user = new User
               (
                   0,
                   model.UserName,
                   model.Password,
                   model.FullName,
                   (BO.User.ProfileOptions)model.ProfileSelectedValue,
                   (bool)model.Status,
                   picture,
                   DateTime.Now
               );
            userManager.CreateUser(user);

            return RedirectToAction("Create");
        }

        private List<SelectListItem> GetUserProfiles(User.ProfileOptions[] selectedProfiles = null)
        {
            return Enum.GetValues(typeof(User.ProfileOptions)).Cast<int>().Select
            (
                x =>
                new SelectListItem
                {
                    Value = x.ToString(),
                    Text = ((BO.User.ProfileOptions)x).ToString(),
                    Selected = selectedProfiles?.Contains((BO.User.ProfileOptions)x) ?? false
                }
            ).ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloAguekeng.WebApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        [DisplayName("Full name")]
        public string FullName { get; set; }
        [DisplayName("Created at")]
        public DateTime CreateAT { get; set; }
        public bool Status { get; set; }
        [DisplayName("Status")]
        public string StatusName { get => Status ? "Enable" : "Disable"; }
        public string Profile { get; set; }
        public string Picture { get; set; }
        public IEnumerable<SelectListItem> Profiles { get; set; }
        public HttpPostedFileBase Image { get; set; }
        public int? ProfileSelectedValue { get; set; }

        public UserModel()
        {

        }
       

        public UserModel(int id, string userName, string password, string confirmPassword, string fullName, DateTime createAT, bool status, string profile, string picture)
        {
            Id = id;
            UserName = userName;
            Password = password;
            ConfirmPassword = confirmPassword;
            FullName = fullName;
            CreateAT = createAT;
            Status = status;
            Profile = profile;
            Picture = picture;
        }

        public UserModel(int id, string userName, string password, string confirmPassword, string fullName,
            DateTime createAT, bool status, string profile, string picture,int? profileSelectedValue, IEnumerable<SelectListItem> profiles) : 
            this(id, userName, password, confirmPassword, fullName, createAT, status, profile, picture)
        {
            ProfileSelectedValue = profileSelectedValue;
            this.Profiles = profiles;
        }
    }
}
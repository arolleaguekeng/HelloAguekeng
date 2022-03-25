using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAguekeng.BO
{
    public class User
    {
        public enum ProfileOptions
        {
            Admin,
            Visitor
        }
        public int Id { get; set; }
        public string   UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public ProfileOptions? Profile { get; set; }
        public bool? Statues { get; set; }
        public byte[] Picture { get; set; }
        public DateTime? CreatedAT { get; set; }
        public User()
        {

        }

        public User(int id, string userName, string password, string fullName, ProfileOptions? profile, bool? statues, byte[] picture, DateTime? createdAT)
        {
            Id = id;
            UserName = userName;
            Password = password;
            FullName = fullName;
            Profile = profile;
            Statues = statues;
            Picture = picture;
            CreatedAT = createdAT;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}

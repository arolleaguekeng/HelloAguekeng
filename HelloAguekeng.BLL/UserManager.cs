using HelloAguekeng.BO;
using HelloAguekeng.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAguekeng.BLL
{
    public class UserManager
    {
        private readonly UserDAO userDAO;
        public UserManager()
        {
            userDAO = new UserDAO();
            userDAO.Add();
        }
        public void CreateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("User! ");
            user.CreatedAT = DateTime.Now;
            if (user.Statues == null)
                throw new ArgumentNullException("User statu cannot be null ! ");
            if(user.Profile == null)
                throw new ArgumentNullException("User Profile cannot be null ! ");
            userDAO.Add(user);
        }

        public void EditUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("User! ");
            user.CreatedAT = DateTime.Now;
            if (user.Statues == null)
                throw new ArgumentNullException("User statu cannot be null ! ");
            if (user.Profile == null)
                throw new ArgumentNullException("User Profile cannot be null ! ");
            userDAO.Set(user);
        }
        public void DeleteUser(int id)
        {
            userDAO.Delete(id);
        }
        public User GetUser(int id)
        {
            return userDAO.Get(id);
        }
        public User GetUser(string login , string password)
        {
            return userDAO.Login(login,password);
        }
        public IEnumerable<User> FindUser(User user = null)
        {
            return userDAO.Find(user).OrderByDescending(x => x.CreatedAT).ToList();   
        }
        /// <summary>
        /// Authenticate the use by UserName And Password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>BO.User</returns>
        /// <exception cref="KeyNotFoundException">KeyNotFoundException</exception>
        /// <exception cref="UnauthorizedAccessException">KeyNotFoundException</exception>
        public User AuthenticateUser(string username , string password)
        {
            var user = userDAO.Login(username, password);
            if (user == null)
                throw new KeyNotFoundException("UserName or password is incorrect ! ");
            if (user.Statues == false)
                throw new UnauthorizedAccessException("your Account is disable");
            return user;
        }
    }
}

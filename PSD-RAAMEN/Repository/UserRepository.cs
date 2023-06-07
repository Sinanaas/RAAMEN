using PSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_RAAMEN.Controller;

namespace PSD_RAAMEN.Repository
{
    public class UserRepository
    {
        static DatabaseEntities1 db = new DatabaseEntities1();

        public static void insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User login(string username, string password)
        {
            User user = (from u in db.Users where u.Username.Equals(username) && u.Password.Equals(password) select u).FirstOrDefault();
            return user;
        }

        public static void updateUser(int id, string username, string email, string gender, string password)
        {
            //User user = db.Users.Find(id);
            //User user = (from x in db.Users where x.User_Id.Equals(id) select x).FirstOrDefault();
            int c = (from x in db.Users where x.User_Id.Equals(id) select x.User_Id).ToList().FirstOrDefault();
            User user = db.Users.Find(c);
            //User user = db.Users.Find(id);
            user.Username = username;
            user.Password = password;
            user.Gender = gender;
            user.Email = email;
            db.SaveChanges();
        }
    }
}
using PSD_RAAMEN.Factory;
using PSD_RAAMEN.Model;
using PSD_RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_RAAMEN.Handler
{
    public class UserHandler
    {
        public static void InsertUser(int RoleId, string username, string email, string gender, string password)
        {
            User user = UserFactory.createUser(RoleId, username, email, gender, password);
            UserRepository.insert(user);
        }

        public static User LoginUser(string username, string password)
        {
            User user = UserRepository.login(username, password);
            return user;
        }

        public static void updateUser(int id, string username, string email, string gender, string password)
        {
            UserRepository.updateUser(id, username, email, gender, password);
            //UserRepository.updateUser(id, "NEWUSERNAME", "NEWEMAIL.com", "FEMALE", "NEWPASSWORD");
        }
    }
}
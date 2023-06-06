using PSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PSD_RAAMEN.Factory
{
    public class UserFactory
    {
       public static User createUser(int RoleId, string Username, string email, string gender, string password)
        {
            User user = new User();
            user.Role_Id = RoleId;
            user.Username = Username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;

            return user;
        }
    }
}
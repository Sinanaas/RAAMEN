using PSD_RAAMEN.Handler;
using PSD_RAAMEN.Model;
using PSD_RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PSD_RAAMEN.Controller
{
    public class UserController
    {
        public static void InsertUser(int role_id, string username, string email, string gender, string password, string confirm_password)
        {
            if (username.Length < 5 || username.Length >= 15 || NoSpaces(username))
            {
                // Handle the case when the username is invalid
                return;
            }
            else if (email.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
            {
                // Handle the case when the email is invalid
                return;
            }
            else if (string.IsNullOrEmpty(gender))
            {
                // Handle the case when the gender is not chosen
                return;
            }
            else if (password != confirm_password)
            {
                // Handle the case when the password and confirm password do not match
                return;
            }
            else
            {
                // All fields are valid, proceed with user insertion
                UserHandler.InsertUser(role_id, username, email, gender, password);
            }
        }

        private static bool NoSpaces(string username)
        {
            // Length must be between 5 and 15 and should only contain alphabets and spaces
            Regex regex = new Regex("^[a-zA-Z ]{5,15}$");
            return regex.IsMatch(username);
        }

        public static User UserLogin(string username, string password)
        {
            User user = UserHandler.LoginUser(username, password);
            return user;
        }


        public static void updateUser(int id, string username, string email, string gender, string password)
        {
            UserHandler.updateUser(id, username, email, gender, password);
            //if (username.Length < 5 || username.Length >= 15 || NoSpaces(username))
            //{
            //    // Handle the case when the username is invalid
            //    return;
            //}
            //else if (email.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
            //{
            //    // Handle the case when the email is invalid
            //    return;
            //}
            //else if (string.IsNullOrEmpty(gender))
            //{
            //    // Handle the case when the gender is not chosen
            //    return;
            //}
            //else
            //{
            //    // All fields are valid, proceed with user insertion
            //    UserHandler.update(id, username, email, gender, password);
            //}
        }
    }
}

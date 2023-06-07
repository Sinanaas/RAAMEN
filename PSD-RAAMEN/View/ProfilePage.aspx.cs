using PSD_RAAMEN.Controller;
using PSD_RAAMEN.Handler;
using PSD_RAAMEN.Model;
using PSD_RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_RAAMEN.View
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //int user_id = (int)Session["uid"];
            //Label3.Text = user_id.ToString();
            //int uid = int.Parse(Request.QueryString["id"]);
            //User user = (from x in db.Users where x.User_Id.Equals(uid) select x).FirstOrDefault();
            //username_txt.Text = user.Username;
            //email_txt.Text = user.Email;
            //password_txt.Text = user.Password;
            //if (user.Gender.Equals("Male"))
            //{
            //    male_radio.Checked = true;
            //}
            //else if(user.Gender.Equals("Female"))
            //{
            //    female_radio.Checked = false;
            //}
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            int uid = int.Parse(Request.QueryString["id"]);
            string selectedGender;
            if (male_radio.Checked)
            {
                selectedGender = "Male";
            }
            else if (female_radio.Checked)
            {
                selectedGender = "Female";
            } else
            {
                selectedGender = "Male";
            }
            string username = username_txt.Text.ToString();
            string email = email_txt.Text.ToString();
            string password = password_txt.Text.ToString();
            status.Text = username + " | " + password + " | " + email + " | " + selectedGender;
            //UserController.updateUser(uid, "newusername", "newnewemail.com", "Female", "newpassword");
            UserController.updateUser(uid, username, email, selectedGender, password);
            //User user = db.Users.Find(uid);
            //user.Username = username;
            //user.Password = password;
            //user.Email = email;
            //user.Gender = selectedGender;
            //db.SaveChanges();
            //status.Text = user.Username + " | " + user.Password + " | " + user.Email + " | " + user.Gender;
            //Response.Redirect("ProfilePage.aspx?id=" + uid);
        }
    }
}
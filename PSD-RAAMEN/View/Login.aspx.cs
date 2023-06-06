using System;
using PSD_RAAMEN.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_RAAMEN.Controller;
using System.Text.RegularExpressions;

namespace PSD_RAAMEN.View
{
    public partial class Login : System.Web.UI.Page
    {
        static DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];

            if (cookie != null)
            {
                string cookieValue = cookie.Value;
                int startIndex = cookieValue.IndexOf('=') + 1;
                int userId = int.Parse(cookieValue.Substring(startIndex));
                User user = (from u in db.Users where u.User_Id.Equals(userId) select u).FirstOrDefault();
                Label4.Text = user.Role_Id.ToString();
                if (user.Role_Id == 1)
                {
                    Response.Redirect("HomeAdmin.aspx");
                }
                else if (user.Role_Id== 2)
                {
                    Response.Redirect("HomeStaff.aspx");
                }
                else if (user.Role_Id == 3)
                {
                    Response.Redirect("HomeCustomer.aspx");
                }else
                {
                    Response.Redirect("Register.aspx");
                }
            }
            //Response.Redirect("Login.aspx");
        }


        protected void login_btn_Click(object sender, EventArgs e)
        {
            User user = UserController.UserLogin(username_text.Text, password_text.Text);

            if(user != null)
            {
                int uid = user.User_Id;

                //Session["uid"] = user.User_Id;
                //Label5.Text = Session["uid"].ToString();
                if (remember_check.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserInfo");
                    cookie["user_id"] = user.User_Id.ToString();


                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                if (user.Role_Id == 1)
                {
                    Response.Redirect("HomeAdmin.aspx?id=" + uid);
                } 
                else if (user.Role_Id == 2)
                {
                    Response.Redirect("HomeStaff.aspx");
                }
                else if (user.Role_Id == 3)
                {
                    Response.Redirect("HomeCustomer.aspx");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}
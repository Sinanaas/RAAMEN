using PSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_RAAMEN.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButOut_Click(object sender, EventArgs e)
        { 
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if(cookie != null)
            {
                cookie.Expires = DateTime.Now.AddHours(-1);
            }
            Response.Redirect("Login.aspx");
        }
    }
}
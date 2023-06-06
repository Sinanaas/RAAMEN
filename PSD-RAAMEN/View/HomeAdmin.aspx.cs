using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_RAAMEN.View
{
    public partial class HomeAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string uid = Request.QueryString["id"];
        }

        protected void view_customer_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCustomer.aspx");
        }

        protected void view_staff_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStaff.aspx");
        }

        protected void user_profile_Click(object sender, EventArgs e)
        {
            string uid = Request.QueryString["id"];
            Response.Redirect("ProfilePage.aspx?id=" + uid);
        }
    }
}
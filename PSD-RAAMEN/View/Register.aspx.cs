using PSD_RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_RAAMEN.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_btn_Click(object sender, EventArgs e)
        {
            string selectedGender = "";
            if (male_radio.Checked)
            {
                selectedGender = "Male";
            }
            else if (female_radio.Checked)
            {
                selectedGender = "Female";
            }

            UserController.InsertUser(1, username_text.Text, email_text.Text, selectedGender, password_text.Text, confirm_password_text.Text);
            Response.Redirect("Login.aspx");
        }

    }
}
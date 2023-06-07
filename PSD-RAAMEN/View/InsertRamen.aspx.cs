using PSD_RAAMEN.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_RAAMEN.View
{
    public partial class InsertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_ramen_btn_Click(object sender, EventArgs e)
        {
            RamenController.insertRamen(int.Parse(DropDownList1.SelectedValue), name_txt.Text, broth_txt.Text, int.Parse(price_txt.Text));
            Response.Redirect("HomeStaff.aspx");
        }
    }
}
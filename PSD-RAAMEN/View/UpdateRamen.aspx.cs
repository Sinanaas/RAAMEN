using PSD_RAAMEN.Controller;
using PSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_RAAMEN.View
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        static DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_ramen_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ramen_id"]);
            RamenController.updateRamen(id, int.Parse(DropDownList1.SelectedValue), name_txt.Text, broth_txt.Text, int.Parse(price_txt.Text));
            Response.Redirect("HomeStaff.aspx");
        }
    }
}
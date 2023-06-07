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
    public partial class HomeStaff : System.Web.UI.Page
    {
        DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Raman> ramens = (from ramen in db.Ramen select ramen).ToList();
            ramenGridView.DataSource = ramens;
            ramenGridView.DataBind();
        }

        protected void insert_ramen_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertRamen.aspx");
        }

        protected void UserGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ramenGridView.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text.ToString());
            Raman ramen = db.Ramen.Find(id);
            db.Ramen.Remove(ramen);
            db.SaveChanges();
            Response.Redirect("HomeStaff.aspx");

        }

        protected void update_ramen_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateRamen.aspx?ramen_id=" + update_ramen_txt.Text);
        }
    }
}
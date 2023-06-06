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
        DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Raman> ramens = (from ramen in db.Ramen select ramen).ToList();
            ramenGridView.DataSource = ramens;
            ramenGridView.DataBind();
        }
    }
}
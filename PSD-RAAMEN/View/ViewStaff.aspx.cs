using PSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_RAAMEN.View
{
    public partial class ViewStaff : System.Web.UI.Page
    {
        DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> users = (from staff in db.Users where staff.Role_Id.Equals(2) select staff).ToList();
            staffGridView.DataSource = users;
            staffGridView.DataBind();
        }
    }
}
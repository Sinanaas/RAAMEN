using PSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_RAAMEN.View
{
    public partial class ViewCustomer : System.Web.UI.Page
    {
        DatabaseEntities1 db = new DatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> users = (from customer in db.Users where customer.Role_Id.Equals(3) select customer).ToList();
            customerGridView.DataSource = users;
            customerGridView.DataBind();
        }
    }
}
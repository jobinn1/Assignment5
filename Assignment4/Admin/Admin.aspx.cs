using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.two
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL.confirmbal confba = new BAL.confirmbal();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = confba.viewcust();
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            confba.Id = id;
            int i = confba.userconfirm();
            GridView1.DataSource = confba.viewcust();
            GridView1.DataBind();

        }
    }
}
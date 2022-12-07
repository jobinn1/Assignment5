using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.two
{
    public partial class Reg : System.Web.UI.Page
    {
        BAL.Bal objba = new BAL.Bal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objba.Name = TextBox1.Text;
            objba.Email = TextBox2.Text;
           
            object oj = objba.insertregister();

            if (oj != null)
            {
                objba.Id = Convert.ToInt32(oj);
                objba.username = TextBox3.Text;
                objba.password = TextBox4.Text;
                objba.insertlogin();

                Response.Write("success");

            }
        }
    }
}
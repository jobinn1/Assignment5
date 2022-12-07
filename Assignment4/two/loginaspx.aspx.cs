using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.two
{
    public partial class loginaspx : System.Web.UI.Page
    {
        BAL.Bal objba = new BAL.Bal();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objba.username = TextBox1.Text;
            objba.password = TextBox2.Text;
            //SqlDataReader i = objba.customerlogin();

            DataTable dt = objba.lgn();


            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][3].ToString() == "Admin")
                {
                    Response.Redirect("/Admin/Admin.aspx");

                }
                else if (dt.Rows[0][3].ToString() == "user" && Convert.ToInt32(dt.Rows[0][4]) == 1)
                {
                    Session["userid"] = dt.Rows[0][0].ToString();

                    Response.Write("Login Successfull!!!");

                    Response.Redirect("../user/user.aspx");
                }
                else if (dt.Rows[0][3].ToString() == "user" && Convert.ToInt32(dt.Rows[0][4]) != 1)
                {
                    Response.Write("pls wait for confirmation");
                    string msg = "Permission Denied! Waiting for confirmation";

                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + msg + "');", true);
                }



            }
        }
    }
    
}
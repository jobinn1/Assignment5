using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String sql = "insert into Employee values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','"+TextBox4.Text+"') ";
            int i = db.exenonquery(sql);
            if (i == 1)
            {
                Response.Write("Success");
            }
            else
                Response.Write("Fail");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = db.exedataset("Select * from Employee ");
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = db.exedataset("select * from Employee");
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string _id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.exenonquery("delete from Employee where EmployeeId='" + _id + "'");
            GridView1.DataSource = db.exedataset("Select * from Employee");
            GridView1.DataBind();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = db.exedataset("Select * from Employee");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string EmployeeId = GridView1.DataKeys[e.RowIndex].Value.ToString();

            TextBox txtName = new TextBox();
            txtName = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            TextBox txtEmail = new TextBox();
            txtEmail = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox txtPhone = new TextBox();
            txtPhone = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox txtAge = new TextBox();
            txtAge = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];


            db.exenonquery("update Employee set Name='" + txtName.Text + "',Email='" + txtEmail.Text + "' ,Phone='" + txtPhone.Text + "' ,Age='" + txtAge.Text + "' where EmployeeId = '"+EmployeeId+"'" );


            GridView1.EditIndex = -1;
            GridView1.DataSource = db.exedataset("Select * from Employee");
            GridView1.DataBind();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Assignment4.two.DAL
{
    public class Dal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Dal()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }

        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }


        public object registerinsert(BAL.Bal ob)
        {
            string s = "insert into Register values ('" + ob.Name + "','" + ob.Email + "');select @@IDENTITY";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            object oc = cmd.ExecuteScalar();
            return oc;

        }

        public int logininsert(BAL.Bal ob)
        {
            string s = "insert into login values ('" + ob.Id + "','" + ob.Name + "', '" + ob.password + "','user',0)";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }

        /* public SqlDataReader logincustomer(BAL.Bal ob)
         {
             string s = "select * from login where username='" + ob.username + "' and password ='" + ob.password + "'";
             SqlCommand cmd = new SqlCommand(s, Getcon());
             SqlDataReader r = cmd.ExecuteReader();
             return r;

         }*/

        public DataTable loggin(BAL.Bal ob)
        {
            string s = "SELECT * FROM login WHERE username='" + ob.username + "' AND password ='" + ob.password + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (dt);

        }
    }
}
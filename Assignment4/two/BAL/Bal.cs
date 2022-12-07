using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Assignment4.two.BAL
{
    public class Bal
    {
        DAL.Dal objda = new DAL.Dal();

        private string _name;
        private string _email;
        
        private int _id;
        public string _username;
        public string _password;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
       

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }



        public object insertregister()
        {
            return objda.registerinsert(this);
        }

        public int insertlogin()
        {
            return objda.logininsert(this);
        }

        /* public SqlDataReader customerlogin()
         {
             return objda.logincustomer(this);
         }*/



        public DataTable lgn()
        {
            return objda.loggin(this);
        }

    }
}
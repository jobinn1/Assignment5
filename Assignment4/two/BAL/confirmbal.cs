using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Assignment4.two.BAL
{
    public class confirmbal
    {
        DAL.confirmdal confda = new DAL.confirmdal();

        private string _username;
        private string _name;
        private int _id;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public DataTable viewcust()
        {
            return confda.custview();

        }

        public int userconfirm()
        {
            return confda.confuser(this);
        }

    }
}
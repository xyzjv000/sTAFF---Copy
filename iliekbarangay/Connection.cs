using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace iliekbarangay
{
    class Connection
    {
        public static SqlConnection con = null;

        string a = ConfigurationManager.AppSettings["oServer"];
        string b = ConfigurationManager.AppSettings["oCompanyDB"];
        string c = ConfigurationManager.AppSettings["oDbUserName"];
        string d = ConfigurationManager.AppSettings["oDbPassword"];

        public void Connect()
        {
         //   con = new SqlConnection(@"Data Source=ACER;Initial Catalog=ilikebarangay;Integrated Security=True");
            con = new SqlConnection(@"Data Source="+a+";Initial Catalog="+b+";Persist Security Info=True;User ID="+c+";Password="+d+"");
            con.Open();
        }  
        
       
    }


}

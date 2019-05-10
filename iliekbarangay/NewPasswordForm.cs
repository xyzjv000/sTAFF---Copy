using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace iliekbarangay
{
    public partial class NewPasswordForm : UserControl
    {
        private static NewPasswordForm _instance;
        public static NewPasswordForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewPasswordForm();
                return _instance;
            }
        }
        public NewPasswordForm()
        {
            InitializeComponent();
        }
        string un;
        public String Uname
        {
            get { return un; }
            set { un = value; }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (cUN.Text != nUN.Text)
            {
                MessageBox.Show("Password dont match");
            }
            else if (nUN.Text.Length < 6)
            {
                MessageBox.Show("Password must be 6 characters");
            }
            else
            {

                nUN.Text = Eramake.eCryptography.Encrypt(nUN.Text);
                cUN.Text = Eramake.eCryptography.Encrypt(cUN.Text);
                Connection con = new Connection();
                con.Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update STAFF set STAFF_PASSWORD = '" + nUN.Text + "' WHERE STAFF_USERNAME = '" + Uname + "'";
                cmd.Connection = Connection.con;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Password has been changed successfully!");
                Application.Restart();
            }
            
        }
    }
}

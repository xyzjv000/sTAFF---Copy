using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace iliekbarangay
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        string answer;
        
        private void submit_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM STAFF WHERE STAFF_USERNAME ='" + un.Text + "'"; 
            cmd.Connection = Connection.con;
            DataTable dt = new DataTable();
            SqlDataReader dar = cmd.ExecuteReader();
            if (dar.Read())
            {
                try
                {
                    answer = dar["STAFF_ANSWER"].ToString();

                    try
                    {
                        if (answer.Trim() == ans.Text)
                        {
                            MessageBox.Show("User verified");
                            if (!panel1.Controls.Contains(NewPasswordForm.Instance))
                            {
                                panel1.Controls.Add(NewPasswordForm.Instance);
                                NewPasswordForm.Instance.Dock = DockStyle.Fill;
                                NewPasswordForm.Instance.BringToFront();
                            }
                            else
                            {
                                NewPasswordForm.Instance.BringToFront();
                            }
                            NewPasswordForm.Instance.Uname = this.un.Text;

                        }
                        else
                        {
                            MessageBox.Show("Answer incorrect");
                        }
                    }
                    catch
                    {

                    }
                }
                catch
                {

                }
            }
        }

        private void un_OnValueChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM STAFF WHERE STAFF_USERNAME ='" + un.Text+"'";
            cmd.Connection = Connection.con;
            DataTable dt = new DataTable();
            SqlDataReader dar = cmd.ExecuteReader();
            if (dar.Read())
            {
                try
                {
                    label3.Text = dar["STAFF_QUESTION"].ToString();
                }
                catch
                {

                }
            }
            else
            {
                label3.Text = "Username dont exist!";
            }
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

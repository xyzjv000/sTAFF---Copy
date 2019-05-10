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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
          
           
            this.AcceptButton = staffLgn;
                  
            
        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private String fname;
        private String mname;
        private String lname;
                                
        private String id;
                                
        public void getTheName(String username)
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmd = new SqlCommand();
            
            if (metroTabControl1.SelectedTab == metroTabPage2)
            {
                cmd.CommandText = "SELECT staff_fname AS a, staff_mname AS b, staff_lname AS c , staff_id as d FROM staff WHERE staff_username = @username";

                try
                {

                    cmd.Connection = Connection.con;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteScalar();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        fname = rdr["a"].ToString();
                        mname = rdr["b"].ToString();
                        lname = rdr["c"].ToString();
                        id = rdr["d"].ToString();
                    }
                    rdr.Close();
                }
                catch (Exception)
                {
                }
                finally
                {
                   
                }
            }

        }


        private void staffLgn_Click(object sender, EventArgs e)
        {    
                
            try
            {
                StaffMain staff = new StaffMain();
                string pass;
                pass = Eramake.eCryptography.Encrypt(stffPass.Text);
                stffPass.Text = Eramake.eCryptography.Decrypt(pass.ToString());
                if (stffUname.Text == "Username" || stffPass.Text == "Password")
                {
                    MessageBox.Show("Please fillup al fields.");
                    return;
                }

                else
                {
                    Connection con = new Connection();
                    con.Connect();
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select * from staff where staff_username=@username AND staff_password=@password";
                    cmd.Parameters.AddWithValue("@username", stffUname.Text);
                    cmd.Parameters.AddWithValue("@password", pass);
                    cmd.Connection = Connection.con;

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    string str;

                    str = "select * from staff";
                    SqlCommand com = new SqlCommand();
                    com.Connection = Connection.con;
                    com.CommandText = str;

                    if (count == 1)
                    {
                        this.getTheName(stffUname.Text);
                        StaffMain sm = new StaffMain();
                        sm.ID = id.Trim();
                        sm.MyUser();
                        this.Hide();
                        sm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Login Failed!!! Try Again.");
                        stffPass.Text = "";
                        stffPass.Focus();
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Server settings");
            }
            

            
        }

        
        

        private void stffUname_Enter(object sender, EventArgs e)
        {
            if (stffUname.Text == "Username")
            {
                stffUname.Text = "";
                stffUname.ForeColor = Color.Black;
            }
        }

        private void stffUname_Leave(object sender, EventArgs e)
        {
            if (stffUname.Text == "")
            {
                stffUname.Text = "Username";
                stffUname.ForeColor = Color.DarkGray;
            }
        }

        private void stffPass_Enter(object sender, EventArgs e)
        {
            if (stffPass.Text == "Password")
            {
                stffPass.Text = "";
                stffPass.ForeColor = Color.Black;
                stffPass.PasswordChar = '*';
            }
        }

        private void stffPass_Leave(object sender, EventArgs e)
        {
            if (stffPass.Text == "")
            {
                stffPass.Text = "Password";
                stffPass.ForeColor = Color.DarkGray;
                stffPass.PasswordChar = Char.Parse("\0");
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            iliekbarangay.settings set = new settings();
            set.ShowDialog();
        }

        private void fpA_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }

        private void fpS_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }
    }
}

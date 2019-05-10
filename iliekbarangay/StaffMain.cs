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
    public partial class StaffMain : Form
    {
        public StaffMain()
        {
            InitializeComponent();
            MyUser();
        }

        
        public void MyUser()
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand Famcmd = new SqlCommand();
            Famcmd.CommandText = "select CONCAT(staff_fNAME,' ',staff_MNAME,' ',staff_LNAME) as a from staff where staff_id = '"+ID+"'";
            Famcmd.Connection = Connection.con;
            SqlDataReader dr = Famcmd.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = "Staff " + dr["a"].ToString();
            }
            dr.Close();
        }

        private String ids;
        public String ID
        {
            get { return ids; }
            set { ids = value; }
        }


        private void clsBtn_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Are you sure you want to exit?", "Exiting iLikeBarangay", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {
                Connection con = new Connection();
                con.Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from resident where family_id is null";
                cmd.Connection = Connection.con;
                cmd.ExecuteNonQuery();
                
                Application.Exit();
            }
            else if (resu == DialogResult.No)
            {

            }
        }

        private void staffs_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(6, 119, 186);
            
            DialogResult resu = MessageBox.Show("Are you sure you want to logout?", "Logout?", MessageBoxButtons.YesNo);

            if (resu == DialogResult.Yes)
            {
                Connection con = new Connection();
                con.Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from resident where family_id is null";
                cmd.Connection = Connection.con;

                cmd.ExecuteNonQuery();
                Application.Restart();

            }
            else if (resu == DialogResult.No)
            {

            }

        }

        private void profile_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(6, 119, 186);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Profile";
            PanelBody.Controls.Clear();
            if (!PanelBody.Controls.Contains(tab_staffProfile.Instance))
            {
                PanelBody.Controls.Add(tab_staffProfile.Instance);
                tab_staffProfile.Instance.Dock = DockStyle.Fill;
                tab_staffProfile.Instance.BringToFront();
               
            }
            else
            {
                tab_staffProfile.Instance.BringToFront();
            }
            tab_staffProfile.Instance.ID = this.ID;
            tab_staffProfile.Instance.DisplayData();
          
        }

        private void announcements_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(6, 119, 186);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Announcements";
            PanelBody.Controls.Clear();
            if (!PanelBody.Controls.Contains(tab_announcements.Instance))
            {
                PanelBody.Controls.Add(tab_announcements.Instance);
                tab_announcements.Instance.Dock = DockStyle.Fill;
                tab_announcements.Instance.BringToFront();
            }
            else
            {
                tab_announcements.Instance.BringToFront();
            }
            tab_announcements.Instance.DisableButton();
        }

        private void programs_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(6, 119, 186);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Programs";
            PanelBody.Controls.Clear();
            if (!PanelBody.Controls.Contains(tab_programs.Instance))
            {
                PanelBody.Controls.Add(tab_programs.Instance);
                tab_programs.Instance.Dock = DockStyle.Fill;
                tab_programs.Instance.BringToFront();
            }
            else
            {
                tab_programs.Instance.BringToFront();
            }
            tab_programs.Instance.DisableButtons();
            tab_programs.Instance.forStaff();
        }

        private void residents_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(6, 119, 186);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Residents";
            PanelBody.Controls.Clear();
            if (!PanelBody.Controls.Contains(tab_residents.Instance))
            {
                PanelBody.Controls.Add(tab_residents.Instance);
                tab_residents.Instance.Dock = DockStyle.Fill;
                tab_residents.Instance.BringToFront();

            }
            else
            {
                tab_residents.Instance.BringToFront();
            }
            tab_residents.Instance.ID = this.ID ;
            tab_residents.Instance.EnableButton();
        }

        private void transactions_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(6, 119, 186);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Transactions";
            PanelBody.Controls.Clear();
            if (!PanelBody.Controls.Contains(tab_document.Instance))
            {
                PanelBody.Controls.Add(tab_document.Instance);
                tab_document.Instance.Dock = DockStyle.Fill;
                tab_document.Instance.BringToFront();
                
            }
            else
            {
                tab_document.Instance.BringToFront();
            }
           
            tab_document.Instance.ID = this.ID;
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(6, 119, 186);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Dashboard";
            PanelBody.Controls.Clear();

            if (!PanelBody.Controls.Contains(tab_dashboard.Instance))
            {
                PanelBody.Controls.Add(tab_dashboard.Instance);
                tab_dashboard.Instance.Dock = DockStyle.Fill;
                tab_dashboard.Instance.BringToFront();
                tab_dashboard.Instance.LoadAll();
            }
            else
            {
                tab_dashboard.Instance.BringToFront();
            }
            
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            if (!PanelBody.Controls.Contains(tab_dashboard.Instance))
            {
                PanelBody.Controls.Add(tab_dashboard.Instance);
                tab_dashboard.Instance.Dock = DockStyle.Fill;
                tab_dashboard.Instance.BringToFront();
            }
            else
            {
                tab_dashboard.Instance.BringToFront();
            }
        }

        private void StaffMain_Load(object sender, EventArgs e)
        {     
            id.Text = ID;
          
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

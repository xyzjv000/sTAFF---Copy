using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.Lib;
using DarrenLee.Media;

namespace iliekbarangay
{
    public partial class AdminMain : Form
    {

        static AdminMain _instance;
        public static AdminMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminMain();
                return _instance;
            }
        }

        public Panel GlobalPanel
        {
            get { return PanelBody; }
            set { PanelBody = value; }
        }

        public String ID
        {
            get { return ids.Text; }
            set { ids.Text = value; }
        }



        public AdminMain()
        {
            InitializeComponent();
           
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Are you sure you want to exit?", "Exiting iLikeBarangay", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {                   
                Application.Exit();                 
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
            staffs.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Profile";
            //switching panel1 to tab_profile user control
            if (!PanelBody.Controls.Contains(tab_profile.Instance))
            {
                PanelBody.Controls.Add(tab_profile.Instance);                   
                tab_profile.Instance.Dock = DockStyle.Fill;
                tab_profile.Instance.BringToFront();                  
            }
            else
            {
                tab_profile.Instance.BringToFront();
            }
        }

        private void announcements_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40,40,40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            staffs.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(6, 119, 186);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Announcements";
            //switching panel1 to tab_announcements user control
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
        }

        private void programs_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(6, 119, 186);
            staffs.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Programs";
            //switching panel1 to tab_programs user control
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
            tab_programs.Instance.IDS = this.ID.Trim();
            tab_programs.Instance.EnableButtons();
            tab_programs.Instance.forAdmin();
        }

        private void residents_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            staffs.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(6, 119, 186);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Residents";
            
            //switching panel1 to tab_residents user control
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
            
            tab_residents.Instance.DisableButton();
        }
       

        private void staffs_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            staffs.Normalcolor = Color.FromArgb(6, 119, 186);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Staffs";
            //switching panel1 to tab_staffs user control
            if (!PanelBody.Controls.Contains(tab_staffs.Instance))
            {
                PanelBody.Controls.Add(tab_staffs.Instance);
                tab_staffs.Instance.Dock = DockStyle.Fill;
                tab_staffs.Instance.BringToFront();
            }
            else
            {
                tab_staffs.Instance.BringToFront();
            }
            tab_staffs.Instance.ID = ids.Text;
        }
       
        private void transactions_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(6, 119, 186);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            staffs.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Transactions";
            //switching panel1 to tab_transaction user control
            
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
            tab_document.Instance.AdminPriv();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            dashboard.Normalcolor = Color.FromArgb(6, 119, 186);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            staffs.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(40, 40, 40);
            globalLabel.Text = "Dashboard";
            //switching panel1 to tab_dashboard user control    
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

        private void AdminMain_Load(object sender, EventArgs e)
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

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {    
            dashboard.Normalcolor = Color.FromArgb(40, 40, 40);
            profile.Normalcolor = Color.FromArgb(40, 40, 40);
            transactions.Normalcolor = Color.FromArgb(40, 40, 40);
            programs.Normalcolor = Color.FromArgb(40, 40, 40);
            staffs.Normalcolor = Color.FromArgb(40, 40, 40);
            announcements.Normalcolor = Color.FromArgb(40, 40, 40);
            residents.Normalcolor = Color.FromArgb(40, 40, 40);
            logout.Normalcolor = Color.FromArgb(6, 119, 186);

            DialogResult resu = MessageBox.Show("Are you sure you want to logout?", "Logout?", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {
                  Application.Restart();

                
            }
            else if (resu == DialogResult.No)
            {

            }

        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

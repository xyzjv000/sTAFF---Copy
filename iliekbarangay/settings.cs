using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace iliekbarangay
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

            sn.Text = ConfigurationManager.AppSettings["oServer"];
            dn.Text = ConfigurationManager.AppSettings["oCompanyDB"];
            un.Text = ConfigurationManager.AppSettings["oDbUserName"];
            pw.Text = ConfigurationManager.AppSettings["oDbPassword"];
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlSettings.SetSetting("oServer", sn.Text);
            SqlSettings.SetSetting("oCompanyDB", dn.Text);
            SqlSettings.SetSetting("oDbUserName", un.Text);
            SqlSettings.SetSetting("oDbPassword", pw.Text);
            MessageBox.Show("New Settings Applied!", "Connection Settings", MessageBoxButtons.OK, MessageBoxIcon.None);
            Application.Restart();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }                    
    }
}

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
    public partial class tab_programs : UserControl
    {
       
        private static tab_programs _instance;
        public static tab_programs Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab_programs();
                return _instance;
            }
        }

        public Panel Bodys
        {
            get { return panel1; }
            set { panel1 = value; }
        }
        string ids;
        public String IDS
        {
            get { return ids; }
            set { ids = value; }
        }


        public void forAdmin()
        {
            addBtn.Visible = true;
            removeBtn.Visible = true;
            verifyBtn.Visible = false;
        }

        public void forStaff()
        {
            addBtn.Visible = false;
            removeBtn.Visible = false;
            verifyBtn.Visible = true;
        }
        public tab_programs()
        {
            InitializeComponent();
            Connection con = new Connection();
            con.Connect();
            SqlDataAdapter da = new SqlDataAdapter("select PROGRAM_ID AS ID,PROGRAM_NAME as A,PROGRAM_DATE AS B,PARTICIPANTS_CATEGORY AS C," +
                "PARTICIPANTS_COUNT AS D ,PARTICIPANTS_REMAINING as E FROM PROGRAM", Connection.con);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();     
            da.Fill(dt);
            programData.DataSource = dt;
            programData.AutoSizeColumnsMode =
           DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void DisableButtons()
        {
            addBtn.Visible = false;
          
            removeBtn.Visible = false;
        }


        public void EnableButtons()
        {
            addBtn.Visible = true;
          
            removeBtn.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ProgramsCreation tr = new ProgramsCreation();
            this.Controls.Add(tr);

            tr.ID = this.IDS.Trim();
            tr.Dock = DockStyle.Fill;
            tr.Show();

        }
      

        private void panel1_Leave(object sender, EventArgs e)
        {
          
        }

        private void panel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            Bodys.Controls.Clear();
        }
        string id;
        private void programData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                label1.Text = (programData.Rows[e.RowIndex].Cells[0].Value.ToString());
                id = (programData.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
         

            DialogResult resu = MessageBox.Show("Are you sure ?", "Deleting a program", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {
                
                Connection con = new Connection();
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmds = new SqlCommand();
                cmd.CommandText = "delete from list where PROGRAM_ID = '"+label1.Text+"'";
                cmds.CommandText = "delete from program where PROGRAM_ID ='" + label1.Text + "'";
                con.Connect();
                cmd.Connection = Connection.con;
                cmds.Connection = Connection.con;   
                cmd.ExecuteNonQuery();
                cmds.ExecuteNonQuery();
                DisplayInfo();
                MessageBox.Show("Removed");

            }
            else if (resu == DialogResult.No)
            {
                MessageBox.Show("Operation cancelled");
               
            }
        }
   
        private void verifyBtn_Click(object sender, EventArgs e)
        {
            program_verification pv = new program_verification();                
            pv.label2.Text = this.programData.CurrentRow.Cells[0].Value.ToString();
            pv.ShowDialog();
        }

     

        public void DisplayInfo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select PROGRAM_ID AS ID,PROGRAM_NAME as A,PROGRAM_DATE AS B,PARTICIPANTS_CATEGORY AS C," +
               "PARTICIPANTS_COUNT AS D ,PARTICIPANTS_REMAINING as E FROM PROGRAM", Connection.con);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            programData.DataSource = dt;
        }

        private void tab_programs_Load(object sender, EventArgs e)
        {
            label1.Text = IDS;
        }
    }
}

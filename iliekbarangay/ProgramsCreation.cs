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
    public partial class ProgramsCreation : UserControl
    {
        private static ProgramsCreation _instance;
        public static ProgramsCreation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProgramsCreation();
                return _instance;
            }
        }
        public ProgramsCreation()
        {
            InitializeComponent();
            programDate.MinDate = DateTime.Now;
            label2.Parent = panel1;
        }

        public Panel Bodys
        {
            get { return progBody; }
            set { progBody = value; }
        }

        string ids;
        public String ID
        {
            get { return ids; }
            set { ids = value; }
        }

        string category;

        public void Clear()
        {   // Clearing Fields
            programDate.Value = programDate.MinDate;
            programName.Text = "";
            categoryBox.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);                 
        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {              

            DialogResult resu = MessageBox.Show("Are you sure to cancel operation?", "Cancel Operation?", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {
                Clear();
                //calling instance of programs
                try
                {
                    this.Controls.Clear();
                    tab_programs tr = new tab_programs();
                    
                    this.Controls.Add(tr);
                    tr.IDS = this.ID.Trim();
                    tr.Dock = DockStyle.Fill;
                    tr.Show();

                   
                }
                catch
                {

                }
                finally
                {
                   
                }
              

            }
            else if (resu == DialogResult.No)
            {

            }
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmd = new SqlCommand();
            SqlCommand scmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.CommandText = "INSERT INTO program(PROGRAM_NAME,PROGRAM_DATE,PARTICIPANTS_CATEGORY,ADMIN_ID)" +
                "VALUES(@pn,@date,@cat,@id)";
            if (all.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM	WHERE PROGRAM.PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL), PARTICIPANTS_REMAINING =  (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL) WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }
           else if (mother.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM WHERE RESIDENT_POSITION = 'Mother' AND PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_POSITION = 'Mother'), PARTICIPANTS_REMAINING = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_POSITION = 'Mother')  WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }
            else if (father.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM WHERE RESIDENT_POSITION = 'Father' AND PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_POSITION = 'Father'), PARTICIPANTS_REMAINING = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_POSITION = 'Father')  WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }
            else if (male.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM WHERE RESIDENT_GENDER = 'Male' AND PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_GENDER = 'Male'), PARTICIPANTS_REMAINING = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_GENDER = 'Male') WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }
            else if (female.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM WHERE RESIDENT_GENDER = 'Female' AND PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_GENDER = 'Female'), PARTICIPANTS_REMAINING = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_GENDER = 'Female') WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }
            else if (HOTF.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM WHERE RESIDENT_FAMILY_HEAD = 'Yes' AND PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";  
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_FAMILY_HEAD = 'Yes'), PARTICIPANTS_REMAINING = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_FAMILY_HEAD = 'Yes')  WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }
            else if (etinUp.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM WHERE RESIDENT_AGE >= 18 AND PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_AGE >= 18), PARTICIPANTS_REMAINING =(SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_AGE >= 18) WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }
            else if (etindown.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM WHERE RESIDENT_AGE < 18 AND PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_AGE < 18), PARTICIPANTS_REMAINING =  (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_AGE < 18) WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }
            else if (senyor.Checked)
            {
                scmd.CommandText = "INSERT INTO LIST(PROGRAM_ID,RESIDENT_ID) SELECT PROGRAM.PROGRAM_ID ,RESIDENT.RESIDENT_ID FROM RESIDENT, PROGRAM WHERE RESIDENT_AGE >= 60 AND PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM) ";
                cmd2.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_COUNT = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_AGE >= 60), PARTICIPANTS_REMAINING = (SELECT COUNT(RESIDENT_ID) FROM RESIDENT WHERE RESIDENT.FAMILY_ID IS NOT NULL AND RESIDENT_AGE >= 60) WHERE PROGRAM_ID = (SELECT MAX(PROGRAM_ID) FROM PROGRAM)";
            }                    
            cmd.Connection = Connection.con;
            scmd.Connection = Connection.con;
            cmd2.Connection = Connection.con;
            if (programName.Text == "" )
            {
                MessageBox.Show("Please input a program name");
                programName.Focus();
            }
            else if (category == "")
            {
                MessageBox.Show("Please select participants");
                categoryBox.Focus();
            }
            else
            {
                try
                {
                    cmd.Parameters.AddWithValue("@pn", programName.Text);
                    cmd.Parameters.AddWithValue("@date", programDate.Value);
                    cmd.Parameters.AddWithValue("@cat", category);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    scmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Successfully added new Program"); 
                    Clear();
                    //calling instance of programs
                    this.Controls.Clear();
                    tab_programs tr = new tab_programs();
                    this.Controls.Add(tr);
                    tr.IDS = this.ID.Trim();
                    tr.Dock = DockStyle.Fill;
                    tr.Show();


                }
                catch
                {

                }
            }


         
        }

        private void all_CheckedChanged(object sender, EventArgs e)
        {
            category = all.Text;
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            category = male.Text;
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            category = female.Text;
        }

        private void mother_CheckedChanged(object sender, EventArgs e)
        {
            category = mother.Text;
        }

        private void father_CheckedChanged(object sender, EventArgs e)
        {
            category = father.Text;
        }

        private void HOTF_CheckedChanged(object sender, EventArgs e)
        {
            category = HOTF.Text;
        }

        private void etinUp_CheckedChanged(object sender, EventArgs e)
        {
            category = etinUp.Text;
        }

        private void senyor_CheckedChanged(object sender, EventArgs e)
        {
            category = senyor.Text;
        }

        private void etindown_CheckedChanged(object sender, EventArgs e)
        {
            category = etindown.Text;
        }

        private void progBody_Leave(object sender, EventArgs e)
        {
           
        }

        private void progBody_ControlRemoved(object sender, ControlEventArgs e)
        {
            tab_programs.Instance.Controls["ProgramsCreation"].SendToBack();

        }

        private void progBody_ControlAdded(object sender, ControlEventArgs e)
        {
            tab_programs.Instance.Controls["ProgramsCreation"].BringToFront();
        }

        private void ProgramsCreation_Load(object sender, EventArgs e)
        {
            label2.Text = ID;
        }
    }
}

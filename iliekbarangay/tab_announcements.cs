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
using System.Net.NetworkInformation;
using MySql.Data.MySqlClient;

namespace iliekbarangay
{
    public partial class tab_announcements : UserControl
    {

        private static tab_announcements _instance;
        public static tab_announcements Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab_announcements();
                return _instance;
            }
        }

        private String ids;
        public String ID
        {
            get { return ids; }
            set { ids = value; }
        }

        public tab_announcements()
        {
            InitializeComponent();
            DisplayData();
            annContent.BackColor = Color.White;
            annTitle.BackColor = Color.White;
            // annDate.MinDate = DateTime.Now;

        }

        public void DisableButton()
        {
            postBtn.Visible = false;
            contentPanel.Enabled = false;
            editBtn.Visible = false;
            delBtn.Visible = false;
            create.Visible = false;
            create.Enabled = false;
            create.DisabledColor = Color.White;

        }
        private void title_Enter(object sender, EventArgs e)
        {
            if (annTitle.Text == "Title")
            {
                annTitle.Text = "";
                annTitle.ForeColor = Color.Black;
            }
        }

        private void title_Leave(object sender, EventArgs e)
        {
            if (annTitle.Text == "")
            {
                annTitle.Text = "Title";
                annTitle.ForeColor = Color.DarkGray;
            }
        }

        private void content_Enter(object sender, EventArgs e)
        {
            if (annContent.Text == "Content")
            {
                annContent.Text = "";
                annContent.ForeColor = Color.Black;
            }
        }

        private void content_Leave(object sender, EventArgs e)
        {
            if (annContent.Text == "")
            {
                annContent.Text = "Content";
                annContent.ForeColor = Color.DarkGray;
            }
        }


        private void title_TextChanged(object sender, EventArgs e)
        {

        }



        private void postBtn_Click(object sender, EventArgs e)
        {

            if (annDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Date must be in the future.");
            }
            else
            {
                if (annTitle.Text == "" || annContent.Text == "")
                {
                    MessageBox.Show("Please dont leave empty spaces.");
                }
                else
                {
                    bool Connections = NetworkInterface.GetIsNetworkAvailable();
                    if (Connections == true)
                    {
                        try
                        {

                            string connString = "Server =remotemysql.com; Port = 3306; Database =T2W4fqv6NB; Uid = T2W4fqv6NB; Pwd = gkQSco3cAC;";
                            try
                            {
                                Connection con = new Connection();
                                con.Connect();
                                SqlCommand cmds = new SqlCommand();
                                cmds.CommandText = "Insert into announcement (ANNOUNCEMENT_NAME,ANNOUNCEMENT_CONTENT,ANNOUNCEMENT_DATE,ANNOUNCEMENT_POSTEDON,ADMIN_ID)" +
                                    "VALUES (@title,@content,@AD,@dt,@id)";
                                cmds.Connection = Connection.con;


                                cmds.Parameters.AddWithValue("@title", annTitle.Text);
                                cmds.Parameters.AddWithValue("@content", annContent.Text);
                                cmds.Parameters.AddWithValue("@AD", annDate.Value);
                                cmds.Parameters.AddWithValue("@dt", dateTaken.Text);
                                cmds.Parameters.AddWithValue("@id", ID);

                                cmds.ExecuteNonQuery();


                                MySqlConnection conn = new MySqlConnection(connString);
                                MySqlCommand cmd = new MySqlCommand("Insert into ANNOUNCEMENT (ANNOUNCEMENT_NAME,ANNOUNCEMENT_CONTENT,ANNOUNCEMENT_DATE,ANNOUNCEMENT_POSTEDON,ADMIN_ID  )" +
                             "VALUES (@title,@content,@AD,@dt,@id)", conn);

                                conn.Open();
                                cmd.Parameters.AddWithValue("@title", annTitle.Text);
                                cmd.Parameters.AddWithValue("@content", annContent.Text);
                                cmd.Parameters.AddWithValue("@AD", annDate.Value);
                                cmd.Parameters.AddWithValue("@dt", dateTaken.Text);
                                cmd.Parameters.AddWithValue("@id", ID);
                                //   cmd.Parameters.AddWithValue("@id"), ID;
                                cmd.ExecuteNonQuery();

                                Clear();
                                MessageBox.Show("Posted Successfully");
                                timer1.Stop();
                                DisplayData();
                                postBtn.Focus();
                                conn.Close();


                            }
                            catch
                            {
                                MessageBox.Show("Check your internet connnection!");
                            }
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("No Internet Connection");
                    }

                    /* Connection con = new Connection();
                     con.Connect();
                     SqlCommand cmd = new SqlCommand();
                     cmd.CommandText = "Insert into announcement (ANNOUNCEMENT_NAME,ANNOUNCEMENT_CONTENT,ANNOUNCEMENT_DATE,ANNOUNCEMENT_POSTEDON )" +
                         "VALUES (@title,@content,@AD,@dt)";
                     cmd.Connection = Connection.con;


                     cmd.Parameters.AddWithValue("@title", annTitle.Text);
                     cmd.Parameters.AddWithValue("@content", annContent.Text);
                     cmd.Parameters.AddWithValue("@AD", annDate.Value);
                     cmd.Parameters.AddWithValue("@dt", dateTaken.Text);




                     cmd.ExecuteNonQuery();

                     Clear();
                     MessageBox.Show("Posted Successfully");
                     DisplayData();
                     postBtn.Focus();       */

                }
            }
            editBtn.Enabled = false;
        }
        string id;
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (data.CurrentCell != null || data.CurrentCell.Value != null)
                {
                    annTitle.Text = (data.Rows[e.RowIndex].Cells[0].Value.ToString());
                    annDate.Text = (data.Rows[e.RowIndex].Cells[1].Value.ToString());
                    annContent.Text = (data.Rows[e.RowIndex].Cells[2].Value.ToString());
                    id = (data.Rows[e.RowIndex].Cells[4].Value.ToString());
                    dateTaken.Text = (data.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Program is empty.");
                }
            }




            annTitle.Enabled = false;
            annDate.Enabled = false;
            annContent.Enabled = false;
            create.Visible = true;
            create.BringToFront();
            postBtn.Visible = false;
            postBtn.SendToBack();
            dateTaken.Visible = true;
            label1.Visible = true;
            editBtn.Enabled = true;
        }

        private void Clear()
        {
            annContent.Text = "Content";
           // annDate.Value = annDate.MinDate;
            annTitle.Text = "Title";
            dateTaken.Visible = false;
            label1.Visible = false;
        }

        private void DisplayData()
        {
            bool Connections = NetworkInterface.GetIsNetworkAvailable();
            if (Connections == true)
            {
                string connString = "Server =remotemysql.com; Port = 3306; Database =T2W4fqv6NB; Uid = T2W4fqv6NB; Pwd = gkQSco3cAC;";
                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT ANNOUNCEMENT_NAME,ANNOUNCEMENT_DATE ,ANNOUNCEMENT_CONTENT,ANNOUNCEMENT_POSTEDON,ANNOUNCEMENT_ID from ANNOUNCEMENT", conn);
                    MySqlCommandBuilder cd = new MySqlCommandBuilder(da);
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);
                    data.DataSource = dt;
                    conn.Close();
                    timer1.Start();
                }
                catch
                {
                    MessageBox.Show("Unstable Connection");
                }

            }
            else
            {
                Connection con = new Connection();
                con.Connect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ANNOUNCEMENT_NAME,ANNOUNCEMENT_DATE ,ANNOUNCEMENT_CONTENT,ANNOUNCEMENT_POSTEDON,ANNOUNCEMENT_ID from ANNOUNCEMENT", Connection.con);

                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();

                da.Fill(dt);
                data.DataSource = dt;
            }


        }



        private void editBtn_Click(object sender, EventArgs e)
        {
            annTitle.Enabled = true;
            annDate.Enabled = true;
            annContent.Enabled = true;
            save.Visible = true;
            save.BringToFront();
            create.Visible = false;
            create.SendToBack();
            dateTaken.Visible = false;
            label1.Visible = false;
            editBtn.Enabled = false;
            timer1.Start();
        }

        private void create_Click(object sender, EventArgs e)
        {
            annContent.Text = "Content";
            annTitle.Text = "Title";
            annTitle.Enabled = true;
            annDate.Enabled = true;
            annContent.Enabled = true;
            create.Visible = false;
            create.SendToBack();
            postBtn.Visible = true;
            postBtn.BringToFront();
            dateTaken.Visible = false;
            label1.Visible = false;
            editBtn.Enabled = false;
            timer1.Start();
        }

        private void save_Click(object sender, EventArgs e)
        {

            if (annDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Date must be in the future.");
            }
            else
            {
                if (annTitle.Text == "" || annContent.Text == "")
                {
                    MessageBox.Show("Please dont leave empty spaces.");
                }
                else
                {
                    DialogResult resu = MessageBox.Show("Save changes ?", "Changes saved", MessageBoxButtons.YesNo);
                    if (resu == DialogResult.Yes)
                    {
                        bool Connections = NetworkInterface.GetIsNetworkAvailable();
                        if (Connections == true)
                        {   //Offline
                            Connection con = new Connection();
                            con.Connect();
                            SqlCommand cmda = new SqlCommand();
                            cmda.CommandText = "update ilikebarangay.announcement set ANNOUNCEMENT_NAME = @name,ANNOUNCEMENT_CONTENT= @content,ANNOUNCEMENT_DATE= @date, ANNOUNCEMENT_POSTEDON = @dt,ADMIN_ID = @id  WHERE ANNOUNCEMENT_ID = @id";
                            cmda.Connection = Connection.con;
                            cmda.Parameters.AddWithValue("@name", annTitle.Text);
                            cmda.Parameters.AddWithValue("@content", annContent.Text);
                            cmda.Parameters.AddWithValue("@date", annDate.Value);
                            cmda.Parameters.AddWithValue("@dt", dateTaken.Text);
                            cmda.Parameters.AddWithValue("@id", ID);

                            cmda.ExecuteNonQuery();


                            //Online
                            string connString = "Server =remotemysql.com; Port = 3306; Database =T2W4fqv6NB; Uid = T2W4fqv6NB; Pwd = gkQSco3cAC;";
                            MySqlConnection conn = new MySqlConnection(connString);
                            MySqlCommand cmd = new MySqlCommand("update ANNOUNCEMENT set ANNOUNCEMENT_NAME = @name,ANNOUNCEMENT_CONTENT= @content,ANNOUNCEMENT_DATE= @date, ANNOUNCEMENT_POSTEDON = @dt, ADMIN_ID = @id   WHERE ANNOUNCEMENT_ID = @id", conn);

                            conn.Open();

                            cmd.Parameters.AddWithValue("@name", annTitle.Text);
                            cmd.Parameters.AddWithValue("@content", annContent.Text);
                            cmd.Parameters.AddWithValue("@date", annDate.Value);
                            cmd.Parameters.AddWithValue("@dt", dateTaken.Text);
                            cmd.Parameters.AddWithValue("@id", ID);


                            cmd.ExecuteNonQuery();
                            timer1.Stop();
                            DisplayData();
                            Clear();
                            //contentPanel.Focus();
                            conn.Close();
                            MessageBox.Show("Saved!!");

                        }
                        else
                        {
                            MessageBox.Show("No Internet Access!");
                        }




                    }
                    else if (resu == DialogResult.No)
                    {
                        MessageBox.Show("Operation cancelled");
                        Clear();
                    }



                }
            }
            save.Visible = false;
            save.SendToBack();

            postBtn.Visible = true;
            editBtn.Enabled = false;
            postBtn.BringToFront();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Are you sure ?", "Changes saved", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {
                bool Connections = NetworkInterface.GetIsNetworkAvailable();
                if (Connections == true)
                {   //offline
                    Connection con = new Connection();
                    con.Connect();
                    SqlCommand cmds = new SqlCommand();
                    cmds.CommandText = "delete from announcement WHERE ANNOUNCEMENT_ID = @id";
                    cmds.Connection = Connection.con;


                    cmds.Parameters.AddWithValue("@id", id);

                    cmds.ExecuteNonQuery();

                    //online
                    string connString = "Server =remotemysql.com; Port = 3306; Database =T2W4fqv6NB; Uid = T2W4fqv6NB; Pwd = gkQSco3cAC;";
                    MySqlConnection conn = new MySqlConnection(connString);
                    MySqlCommand cmd = new MySqlCommand("delete from ANNOUNCEMENT WHERE ANNOUNCEMENT_ID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DisplayData();
                    Clear();
                    postBtn.Visible = true;
                    postBtn.BringToFront();
                    MessageBox.Show("Removed");
                    postBtn.Focus();
                }
                else
                {
                    MessageBox.Show("No Internet Access!");
                }
            }
            else if (resu == DialogResult.No)
            {
                MessageBox.Show("Operation cancelled");
                Clear();
            }
            annTitle.Enabled = true;
            annDate.Enabled = true;
            annContent.Enabled = true;
        }

        private void tab_announcements_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.Controls.Clear();
            tab_announcements.Instance.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTaken.Text = DateTime.Now.ToString("MMM. dd yyyy, hh:mm tt");
        }

        private void dateTaken_TextChanged(object sender, EventArgs e)
        {

        }
    }


    //Start

}

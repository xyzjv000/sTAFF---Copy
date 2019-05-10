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
using System.IO;
using System.Drawing.Imaging;
using DarrenLee.Media;


namespace iliekbarangay
{
    public partial class tab_staffs : UserControl
    {

        private static tab_staffs _instance;
        public static tab_staffs Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab_staffs();
                return _instance;
            }
        }
        string ids;
        public String ID
        {
            get { return ids; }
            set { ids = value; }
        }
        Camera myCamera = new Camera();
        int count = 0;
        public tab_staffs()
        {
            InitializeComponent(); 
            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;
            myCamera.Stop();
            Connection con = new Connection();
            con.Connect();
            displayData();
            
            
        }
        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            profileImage.Image = img;
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.Connect();

            if (password.Text.Length < 6)
            {
                MessageBox.Show("Password must be atleast 6 charachters!");
                password.Focus();
            }
            else if (cnum.Text.Length < 11 || cnum.Text.Length >11)
            {
                MessageBox.Show("Contact number must be atleast 11 charachters!");
                cnum.Focus();
            }

            else if (username.Text.Length < 4)
            {
                MessageBox.Show("Username must be atleast 4 charachters!");
                username.Focus();
            }
            else
            {
                SqlDataReader reader = null;
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = Connection.con;
                cmd3.CommandText = "select * from staff where staff_username = @username";
                cmd3.Parameters.AddWithValue("@username", username.Text);
                reader = cmd3.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    MessageBox.Show("Username already exists.");

                }
                else
                {
                    reader.Close();
                    if (username.Text == "" || password.Text == "" || fname.Text == "" || lname.Text == "" || cnum.Text == "" || address.Text == "" || gender.Text == "" || DOB.Value >= DateTime.Now)
                    {
                        MessageBox.Show("Dont leave empty spaces!");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        SqlCommand cmd2 = new SqlCommand();
                        cmd.Connection = Connection.con;
                        cmd2.Connection = Connection.con;

                        cmd2.CommandText = "update staff set staff_age = datediff(YY, staff_dob,GETDATE())";
                        password.Text = Eramake.eCryptography.Encrypt(password.Text);
                        MemoryStream stream = new MemoryStream();
                        if (profileImage.Image != null)
                        {
                            cmd.CommandText = "INSERT INTO STAFF(STAFF_FNAME,STAFF_MNAME,STAFF_LNAME,STAFF_CNUM,STAFF_ADDRESS,STAFF_DOB,STAFF_GENDER,STAFF_USERNAME,STAFF_PASSWORD,STAFF_IMAGE,ADMIN_ID) " +
                           "VALUES(@fname,@mname,@lname,@cnum,@add,@dob,@gender,@username,@pass,@pic,@id)";
                            profileImage.Image = resizeImage(profileImage.Image, new Size(177, 151));
                            profileImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] pic = stream.ToArray();
                            cmd.Parameters.AddWithValue("@fname", fname.Text);
                            cmd.Parameters.AddWithValue("@mname", mname.Text);
                            cmd.Parameters.AddWithValue("@lname", lname.Text);
                            cmd.Parameters.AddWithValue("@cnum", cnum.Text);
                            cmd.Parameters.AddWithValue("@add", address.Text);
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            cmd.Parameters.AddWithValue("@pass", password.Text);
                            cmd.Parameters.AddWithValue("@dob", DOB.Value);
                            cmd.Parameters.AddWithValue("@gender", gender.Text);
                            cmd.Parameters.AddWithValue("@pic", pic);
                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.ExecuteNonQuery();
                            Clear();
                            cmd2.ExecuteNonQuery();

                        }
                        else if (profileImage.Image == null)
                        {
                            cmd.CommandText = "INSERT INTO STAFF(STAFF_FNAME,STAFF_MNAME,STAFF_LNAME,STAFF_CNUM,STAFF_ADDRESS,STAFF_DOB,STAFF_GENDER,STAFF_USERNAME,STAFF_PASSWORD,ADMIN_ID) " +
                           "VALUES(@fname,@mname,@lname,@cnum,@add,@dob,@gender,@username,@pass,@id)";
                            cmd.Parameters.AddWithValue("@fname", fname.Text);
                            cmd.Parameters.AddWithValue("@mname", mname.Text);
                            cmd.Parameters.AddWithValue("@lname", lname.Text);
                            cmd.Parameters.AddWithValue("@cnum", cnum.Text);
                            cmd.Parameters.AddWithValue("@add", address.Text);
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            cmd.Parameters.AddWithValue("@pass", password.Text);
                            cmd.Parameters.AddWithValue("@dob", DOB.Value);
                            cmd.Parameters.AddWithValue("@gender", gender.Text);
                            cmd.Parameters.AddWithValue("@id", ID);
                            //   cmd.Parameters.AddWithValue("@pic", SqlDbType.VarChar).Value = null;
                            cmd.ExecuteNonQuery();
                            Clear();
                            cmd2.ExecuteNonQuery();

                        }
                        MessageBox.Show(fname.Text + " Successfully Added");

                        displayData();

                        form.Visible = false;
                        myCamera.Stop();
                    }

                }
            }

           




        }
        private void displayData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT CONCAT(STAFF_FNAME,' ',STAFF_MNAME,' ',STAFF_LNAME) AS STAFF,STAFF_FNAME,STAFF_MNAME,STAFF_LNAME,STAFF_CNUM,STAFF_ADDRESS,STAFF_DOB,STAFF_GENDER,STAFF_IMAGE ,STAFF_AGE,STAFF_ID FROM staff", Connection.con);
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);

            staffList.DataSource = dt;
        }
        public void Clear()
        {
            fname.Text = null;
            mname.Text = null;
            lname.Text = null;
            cnum.Text = null;
            gender.Text = null;
            address.Text = null;
            DOB.Value = DOB.MinDate;
            username.Text = null;
            password.Text = null;
            age.Text = null;
            profileImage.Image = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Are you sure? ", "Warning!!", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {
                Clear();
                disable();
                form.Visible = false;
                myCamera.Stop();
            }
            else if (resu == DialogResult.No)
            {
                form.Visible = true; 
            }

        }
        private void disable()
        {
            username.Visible = false;
            password.Visible = false;
            userLabel.Visible = false;
            passLabel.Visible = false;
            fname.Enabled = false;
            mname.Enabled = false;
            lname.Enabled = false;
            cnum.Enabled = false;
            gender.Enabled = false;
            address.Enabled = false;
            DOB.Enabled = false;
            age.Enabled = false;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            takePhoto.Visible = false;
            closeCam.Visible = false;
        }
        private void EnableAll()
        {
            username.Visible = true;
            password.Visible = true;
            userLabel.Visible = true;
            passLabel.Visible = true;
            fname.Enabled = true;
            mname.Enabled = true;
            lname.Enabled = true;
            cnum.Enabled = true;
            gender.Enabled = true;
            address.Enabled = true;
            DOB.Enabled = true;
            age.Enabled = true;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            takePhoto.Visible = true;
            closeCam.Visible = true;
        }

        private void addStaff_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            ageLabel.Visible = false;
            age.Visible = false;
            EnableAll();
            Clear();
            closeForm.Visible = false;
            DOB.Value = DateTime.Now;

        }

        private void staffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            form.Visible = true;
            age.Visible = true;
            ageLabel.Visible = true;
            disable();
            closeForm.Visible = true;


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (staffList.CurrentCell != null || staffList.CurrentCell.Value != null)
                {

                    DataGridViewRow row = this.staffList.Rows[e.RowIndex];
                    fname.Text = (staffList.Rows[e.RowIndex].Cells[1].Value.ToString());
                    mname.Text = (staffList.Rows[e.RowIndex].Cells[2].Value.ToString());
                    lname.Text = (staffList.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cnum.Text = (staffList.Rows[e.RowIndex].Cells[4].Value.ToString());
                    address.Text = (staffList.Rows[e.RowIndex].Cells[5].Value.ToString());
                    DOB.Value = Convert.ToDateTime(staffList.Rows[e.RowIndex].Cells[6].Value);
                    age.Text = (staffList.Rows[e.RowIndex].Cells[9].Value.ToString());
                    gender.Text = (staffList.Rows[e.RowIndex].Cells[7].Value.ToString());
                    id = (staffList.Rows[e.RowIndex].Cells[10].Value.ToString());
                    profileImage.Image = null;

                    if (staffList.Rows[e.RowIndex].Cells[8] == null)
                    {

                    }
                    else
                    {
                        try
                        {
                            var data = (Byte[])(row.Cells[8].Value);
                            var stream = new MemoryStream(data);
                            profileImage.Image = Image.FromStream(stream);
                        }
                        catch
                        {

                        }
                    }


                }

                else
                {
                    MessageBox.Show("Program is empty.");
                }
            }
            else
            {

            }

        }

        private void takePhoto_Click(object sender, EventArgs e)
        {
            myCamera.Start();
            takePhoto.Visible = false;
            closeCam.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\" + "Image" + count.ToString();
            myCamera.Capture(filename);
            count++;
            myCamera.Stop();
            takePhoto.Visible = true;
            closeCam.Visible = false;
        }

        private void tab_staffs_Leave(object sender, EventArgs e)
        {
            myCamera.Stop();
        }

        private void tab_staffs_ControlRemoved(object sender, ControlEventArgs e)
        {
            myCamera.Stop();
        }

        private void staffList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            form.Visible = false;
            Clear();
            closeForm.Visible = false;
            myCamera.Stop();
        }
        string id;
        private void removeStaff_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Are you sure ?", "Changes saved", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {

                Connection con = new Connection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from staff where staff_id = @id";
                con.Connect();
                cmd.Connection = Connection.con;


                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                displayData();
                Clear();
                form.Visible = false;
                MessageBox.Show("Removed");

            }
            else if (resu == DialogResult.No)
            {
                MessageBox.Show("Operation cancelled");
                Clear();
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void cnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void staffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void password_KeyUp(object sender, KeyEventArgs e)
        {
            password.isPassword = true;
        }
    }
}

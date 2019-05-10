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
using Encoder = System.Drawing.Imaging.Encoder;

namespace iliekbarangay
{
    public partial class tab_profile : UserControl
    {
        private static tab_profile _instance;
        public static tab_profile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab_profile();
                return _instance;
            }
        }
        Camera myCamera = new Camera();
        int count = 0;
        public tab_profile()
        {
            InitializeComponent();
            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;
            myCamera.Stop();
            DisplayData();
            saveBtn.Parent = profileImage;
            takePhoto.Parent = profileImage;
          
        }
        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            profileImage.Image = img;
        }
        OpenFileDialog fd1 = new OpenFileDialog();

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            myCamera.Stop();
            saveBtn.Visible = false; saveBtn.SendToBack();
            takePhoto.Visible = true; takePhoto.BringToFront();
            fd1.Filter = "image files|*.jpg;*.png;*.icon;.*;";
            DialogResult dres1 = fd1.ShowDialog();                  
            if (dres1 == DialogResult.Abort)                        
                return;                                             
            if (dres1 == DialogResult.Cancel)                       
                return;
            MemoryStream ms1 = new MemoryStream();
            profileImage.Image = Image.FromFile(fd1.FileName);
            profileImage.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            ii= 1;
        }
        int ii = 0;
        private void takePhoto_Click(object sender, EventArgs e)
        {
            myCamera.Start();
            takePhoto.Visible = false;
            takePhoto.SendToBack();
            saveBtn.Visible = true;
            saveBtn.BringToFront();
            ii = 0;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\" + "Image" + count.ToString();
            myCamera.Capture(filename);
            count++;
            myCamera.Stop();
            takePhoto.Visible = true;
            takePhoto.BringToFront();
            saveBtn.Visible = false;
            saveBtn.SendToBack();
            ii = 1;
        }
        
        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditBtn.Visible = false;
         
            save.Visible = true;
            cancelBtn.Visible = true;
            fname.Enabled = true;
            lname.Enabled = true;
            mi.Enabled = true;
            cnum.Enabled = true;
            email.Enabled = true;
            gender.Enabled = true;
            answer.Enabled = true;
            dob.Enabled = true;
            address.Enabled = true;
            newUname.Enabled = true;
            oldPass.Enabled = true;
            confirmPass.Enabled = true;
            newPass.Enabled = true;
            takePhoto.Enabled = true;
            uploadBtn.Enabled = true;
            saveBtn.Enabled = true;

            SecretQuestion();
            if (q.Trim() == "" && i.Trim() == "")
            {
                MessageBox.Show("Answering secret question is recommended for retrieval purposes!");
                question.Enabled = true;
                metroLink1.Visible = true;
                metroLink1.Focus();
            }


        }
        string q;
        string i;
        public void SecretQuestion()
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from admin";
            cmd.Connection = Connection.con;
            DataTable dt = new DataTable();
            SqlDataReader dar = cmd.ExecuteReader();
            if (dar.Read())
            {
                try
                {
                    q = dar["ADMIN_QUESTION"].ToString();
                    i = dar["ADMIN_ANSWER"].ToString();
                                        
                }
                catch
                {

                }

            }
            dar.Close();
        }
        private void Disable()
        {
            metroLink1.Visible = false;
            answer.Enabled = false;
            question.Enabled = false;
            EditBtn.Visible = true ;
            save.Visible = false;
            cancelBtn.Visible = false;
            fname.Enabled = false;
            lname.Enabled = false;
            mi.Enabled = false;
            cnum.Enabled = false;
            email.Enabled = false;
            gender.Enabled = false;
            age.Enabled = false;
            dob.Enabled = false;
            address.Enabled = false;
            newUname.Enabled = false;
            oldPass.Enabled = false;
            confirmPass.Enabled = false;
            newPass.Enabled = false;
            takePhoto.Enabled = false;
            uploadBtn.Enabled = false;
            saveBtn.Enabled = false;
            oldPass.Text = null;
            newPass.Text = null;
            confirmPass.Text = null;
            notify.Text = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            EditBtn.Visible = true;
            save.Visible = false;
            cancelBtn.Visible = false;
            Disable();
            DisplayData();
            myCamera.Stop();
            ii = 0;
        }
        string pasd;

        private void save_Click(object sender, EventArgs e)
        {
            
            myCamera.Stop();
            if (mi.Text.Length > 1)
            {
                MessageBox.Show("Initials must be 1 character!");
                mi.Focus();
            }
            else if (cnum.Text.Length > 11 || cnum.Text.Length < 11)
            {
                MessageBox.Show("Contact number must be 11 digits!");
                cnum.Focus();
            }
            else if (newUname.Text.Length < 4)
            {
                MessageBox.Show("Username must be 4 characters above!");
                newUname.Focus();
            }
           
            else
            {
                Connection conn = new Connection();
                conn.Connect();
                SqlCommand cmd3 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = Connection.con;
                cmd2.CommandText = "update admin set admin_age = datediff(YY, admin_dob,GETDATE())";
                cmd3.Connection = Connection.con;

                string pass;
                pass = Eramake.eCryptography.Encrypt(oldPass.Text);
                oldPass.Text = Eramake.eCryptography.Decrypt(pass.ToString());
                newPass.Text = Eramake.eCryptography.Encrypt(newPass.Text);
                confirmPass.Text = Eramake.eCryptography.Encrypt(confirmPass.Text);

                MemoryStream stream = new MemoryStream();
                if (ii == 1 && groupBox2.Enabled == true)
                {
                    cmd3.CommandText = "UPDATE ADMIN SET ADMIN_FNAME =@fname ,ADMIN_MNAME = @mname ,ADMIN_LNAME = @lname,ADMIN_CNUM = @cnum,ADMIN_ADDRESS = @add,ADMIN_DOB =@dob,ADMIN_GENDER= @gender,ADMIN_EMAIL =@email,ADMIN_USERNAME = @username,ADMIN_PASSWORD =@pass,ADMIN_IMAGE = @pic,ADMIN_QUESTION = @quest,ADMIN_ANSWER = @ans";
                    profileImage.Image = resizeImage(profileImage.Image, new Size(177, 151));
                    profileImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd3.Parameters.AddWithValue("@fname", fname.Text);
                    cmd3.Parameters.AddWithValue("@mname", mi.Text);
                    cmd3.Parameters.AddWithValue("@lname", lname.Text);
                    cmd3.Parameters.AddWithValue("@cnum", cnum.Text);
                    cmd3.Parameters.AddWithValue("@add", address.Text);
                    cmd3.Parameters.AddWithValue("@email", email.Text);
                    cmd3.Parameters.AddWithValue("@dob", dob.Value);
                    cmd3.Parameters.AddWithValue("@gender", gender.Text);
                    cmd3.Parameters.AddWithValue("@pic", pic);
                    cmd3.Parameters.AddWithValue("@username", newUname.Text);
                    cmd3.Parameters.AddWithValue("@quest", question.Text);
                    cmd3.Parameters.AddWithValue("@ans", answer.Text);

                    if (oldPass.Text == pasd && newPass.Text == confirmPass.Text && newPass.Text != "" && confirmPass.Text != "")
                    {
                        
                        cmd3.Parameters.AddWithValue("@pass", newPass.Text);
                        if (newPass.Text.Length < 6)
                        {
                            MessageBox.Show("Password must be atleast 6 characters and above!");
                            cnum.Focus();
                        }
                        else
                        {
                            cmd3.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                            DisplayData();
                            EditBtn.Visible = true;
                            save.Visible = false;
                            cancelBtn.Visible = false;
                            Disable();
                            

                            ii = 0;
                        }
                       
                       
                    }
                    else
                    {
                        notify.Text = "Password not matched!";

                    }


                }
                else if (ii == 1 && groupBox2.Enabled == false)
                {
                    cmd3.CommandText = "UPDATE ADMIN SET ADMIN_FNAME =@fname ,ADMIN_MNAME = @mname ,ADMIN_LNAME = @lname,ADMIN_CNUM = @cnum,ADMIN_ADDRESS = @add,ADMIN_DOB =@dob,ADMIN_GENDER= @gender,ADMIN_EMAIL =@email,ADMIN_IMAGE = @pic ,ADMIN_USERNAME =@uname, ADMIN_QUESTION = @quest,ADMIN_ANSWER = @ans";
                    profileImage.Image = resizeImage(profileImage.Image, new Size(177, 151));
                    profileImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd3.Parameters.AddWithValue("@fname", fname.Text);
                    cmd3.Parameters.AddWithValue("@mname", mi.Text);
                    cmd3.Parameters.AddWithValue("@lname", lname.Text);
                    cmd3.Parameters.AddWithValue("@cnum", cnum.Text);
                    cmd3.Parameters.AddWithValue("@add", address.Text);
                    cmd3.Parameters.AddWithValue("@email", email.Text);
                    cmd3.Parameters.AddWithValue("@dob", dob.Value);
                    cmd3.Parameters.AddWithValue("@gender", gender.Text);
                    cmd3.Parameters.AddWithValue("@pic", pic);
                    cmd3.Parameters.AddWithValue("@uname", newUname.Text);
                    cmd3.Parameters.AddWithValue("@quest", question.Text);
                    cmd3.Parameters.AddWithValue("@ans", answer.Text);
                    cmd3.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Saved");
                    DisplayData();
                    EditBtn.Visible = true;
                    save.Visible = false;
                    cancelBtn.Visible = false;
                    Disable();
                    ii = 0;
                }
                else if (ii != 1 && groupBox2.Enabled == false)
                {
                    cmd3.CommandText = "UPDATE ADMIN SET ADMIN_FNAME =@fname ,ADMIN_MNAME = @mname ,ADMIN_LNAME = @lname,ADMIN_CNUM = @cnum,ADMIN_ADDRESS = @add,ADMIN_DOB =@dob,ADMIN_GENDER= @gender,ADMIN_EMAIL =@email, ADMIN_USERNAME = @uname, ADMIN_QUESTION = @quest,ADMIN_ANSWER = @ans";
                    cmd3.Parameters.AddWithValue("@fname", fname.Text);
                    cmd3.Parameters.AddWithValue("@mname", mi.Text);
                    cmd3.Parameters.AddWithValue("@lname", lname.Text);
                    cmd3.Parameters.AddWithValue("@cnum", cnum.Text);
                    cmd3.Parameters.AddWithValue("@add", address.Text);
                    cmd3.Parameters.AddWithValue("@email", email.Text);
                    cmd3.Parameters.AddWithValue("@uname", newUname.Text);
                    cmd3.Parameters.AddWithValue("@dob", dob.Value);
                    cmd3.Parameters.AddWithValue("@quest", question.Text);
                    cmd3.Parameters.AddWithValue("@ans", answer.Text);
                    cmd3.Parameters.AddWithValue("@gender", gender.Text);
                    //    cmd3.Parameters.AddWithValue("@pic", SqlDbType.VarChar).Value = null;
                    cmd3.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    DisplayData();
                    MessageBox.Show("Saved");
                    EditBtn.Visible = true;
                    save.Visible = false;
                    cancelBtn.Visible = false;
                    Disable();
                    ii = 0;
                }
                else if (ii != 1 && groupBox2.Enabled == true)
                {
                    cmd3.CommandText = "UPDATE ADMIN SET ADMIN_FNAME =@fname ,ADMIN_MNAME = @mname ,ADMIN_LNAME = @lname,ADMIN_CNUM = @cnum,ADMIN_ADDRESS = @add,ADMIN_DOB =@dob,ADMIN_GENDER= @gender,ADMIN_EMAIL =@email, ADMIN_USERNAME = @username, ADMIN_PASSWORD = @pass, ADMIN_QUESTION = @quest,ADMIN_ANSWER = @ans";
                    cmd3.Parameters.AddWithValue("@fname", fname.Text);
                    cmd3.Parameters.AddWithValue("@mname", mi.Text);
                    cmd3.Parameters.AddWithValue("@lname", lname.Text);
                    cmd3.Parameters.AddWithValue("@cnum", cnum.Text);
                    cmd3.Parameters.AddWithValue("@add", address.Text);
                    cmd3.Parameters.AddWithValue("@email", email.Text);
                    cmd3.Parameters.AddWithValue("@dob", dob.Value);
                    cmd3.Parameters.AddWithValue("@gender", gender.Text);
                    cmd3.Parameters.AddWithValue("@username", newUname.Text);
                    cmd3.Parameters.AddWithValue("@quest", question.Text);
                    cmd3.Parameters.AddWithValue("@ans", answer.Text);
                    //     cmd3.Parameters.AddWithValue("@pic", SqlDbType.VarChar).Value = null;
                    if (oldPass.Text == pasd && newPass.Text == confirmPass.Text && newPass.Text != "" && confirmPass.Text != "")
                    {
                        
                        cmd3.Parameters.AddWithValue("@pass", newPass.Text);
                        if (newPass.Text.Length < 6)
                        {
                            MessageBox.Show("Password must be atleast 6 characters and above!");
                            cnum.Focus();
                        }
                        else
                        {
                            cmd3.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Saved");
                            DisplayData();
                            EditBtn.Visible = true;
                            save.Visible = false;
                            cancelBtn.Visible = false;
                            Disable();
                            ii = 0;
                        }
                       
                    }
                    else
                    {
                        notify.Text = "Password not matched!";

                    }
                }

            }

        }

        byte[] imageBytes;
        private void DisplayData()
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmd = new SqlCommand();
           
            cmd.CommandText = "SELECT * FROM ADMIN";
            cmd.Connection = Connection.con;
           
            DataTable dt = new DataTable();
            SqlDataReader dar = cmd.ExecuteReader();
            if (dar.Read())
            {
                try
                {
                    fname.Text = dar["ADMIN_FNAME"].ToString();
                    mi.Text = dar["ADMIN_MNAME"].ToString();
                    lname.Text = dar["ADMIN_LNAME"].ToString();
                    cnum.Text = dar["ADMIN_CNUM"].ToString();
                    address.Text = dar["ADMIN_ADDRESS"].ToString();
                    gender.Text = dar["ADMIN_GENDER"].ToString();
                    email.Text = dar["ADMIN_EMAIL"].ToString();
                    newUname.Text = dar["ADMIN_USERNAME"].ToString();
                    dob.Value = Convert.ToDateTime(dar["ADMIN_DOB"]);
                    age.Text = dar["ADMIN_AGE"].ToString();
                    imageBytes = dar["ADMIN_IMAGE"] as byte[];
                    question.Text = dar["ADMIN_QUESTION"].ToString();
                    answer.Text = dar["ADMIN_ANSWER"].ToString();
                    if (imageBytes != null)
                    {
                        using (var stream = new MemoryStream(imageBytes))
                            profileImage.Image = Image.FromStream(stream);

                    }
                   
                   
                }
                catch
                {

                }
                
            }
            dar.Close();
            metroPanel1.Size = new Size(644, 464);
            panel2.Size = new Size(644, 480);
            
        }

       

        

        private void label6_Click(object sender, EventArgs e)
        {
            profileImage.Image = null;
        }

        private void tab_profile_Leave(object sender, EventArgs e)
        {
            Disable();
        }

        private void tab_profile_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.panel1.Dispose();
        }

        private void oldPass_OnValueChanged(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand();
            cmd4.Connection = Connection.con;
            cmd4.CommandText = "select ADMIN_PASSWORD from ADMIN";
            DataTable dt = new DataTable();
            SqlDataReader dar = cmd4.ExecuteReader();
            if (dar.Read())
            {
                try
                {
                    string pass;
                    pass = Eramake.eCryptography.Encrypt(oldPass.Text);
                    oldPass.Text = Eramake.eCryptography.Decrypt(pass.ToString());
                    pasd = dar["ADMIN_PASSWORD"].ToString();

                    if (oldPass.Text == pasd)
                    {
                        groupBox2.Enabled = true;
                        newPass.Enabled = true;
                        confirmPass.Enabled = true;

                    }
                    else
                    {
                        groupBox2.Enabled = false;
                        newPass.Enabled = false;
                        confirmPass.Enabled = false;
                        newPass.Text = null;
                        confirmPass.Text = null;                       
                    }
                }
                catch
                {

                }
            }
            dar.Close();
        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void oldPass_KeyUp(object sender, KeyEventArgs e)
        {
            oldPass.isPassword = true;
        }

        private void newPass_KeyUp(object sender, KeyEventArgs e)
        {
            newPass.isPassword = true;
        }

        private void confirmPass_KeyUp(object sender, KeyEventArgs e)
        {
            confirmPass.isPassword = true;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            metroPanel1.Size = new Size(644, 516);
            panel2.Size = new Size(644, 550);
        }


    }
}

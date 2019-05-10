using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using iliekbarangay.Documents;

namespace iliekbarangay
{
    public partial class tab_document : UserControl, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        private static tab_document _instance;
        public static tab_document Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab_document();
                return _instance;
            }
        }
        public tab_document()
        {
            InitializeComponent();
            Verificator = new DPFP.Verification.Verification();
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            Stop();
        }

        public void AdminPriv()
        {
            verifyBtn.Enabled = false;
            viewBtn.Enabled = false;
        }

       
        public String ID
        {
            get { return staffID.Text; }
            set { staffID.Text = value; }
        }

        string fname;
        string cnum;
        string add;
        string dob;
        string age;
        string gender;
        string Fid;


        private DPFP.Verification.Verification Verificator;


        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                if (null != Capturer)
                    Capturer.EventHandler = this;
                else
                    SetPrompt("Cant initiate capture operation!!");
            }
            catch
            {
                MessageBox.Show("Error!!");
            }
        }
        protected virtual void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using fingerprint reader scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Cant initiate capture!");
                }

            }
        }

        protected virtual void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();

                }
                catch
                {
                    MessageBox.Show("Capture Stopped!");
                }

            }
        }
        #region
       
        private void so()
        {
            label1.Text = "Match";
        }
        string RID;
        byte[] imageBytes;
        string position;
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("fingerprint captured.");
            SetPrompt("Scan fingerprint again");
            //Process(Sample);
            try
            {
                Connection con = new Connection();
                con.Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select RESIDENT_ID,FAMILY_ID, resident_fingerprint from resident ";
                cmd.Connection = Connection.con;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
              
                foreach (DataRow dr in dt.Rows)
                {
                    byte[] _img = (byte[])dr["resident_fingerprint"];
                    string id = dr["RESIDENT_ID"].ToString();



                    MemoryStream ms = new MemoryStream(_img);

                    DPFP.Template Template = new DPFP.Template();
                    Template.DeSerialize(ms);
                    DPFP.Verification.Verification Verificator = new DPFP.Verification.Verification();

                    Process(Sample);

                    DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
                    if (features != null)
                    {
                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                        Verificator.Verify(features, Template, ref result);
                        // UpdateStatus(result.FARAchieved);
                        if (result.Verified)
                        {
                            MessageBox.Show("Verified as a Resident of Barangay!!!");
                           
                            Stop();                                                 
                            viewBtn.Enabled = true;
                            if (id != null)
                            {
                                try
                                {
                                    SqlCommand cmds = new SqlCommand();
                                    cmds.CommandText = "select RESIDENT_ID,resident_image,CONCAT(RESIDENT_FNAME,' ', RESIDENT_MNAME ,'. ', RESIDENT_LNAME) as NAME,RESIDENT_CNUM,FORMAT(RESIDENT_DOB,'MMMM d yyyy') as Det, RESIDENT_AGE, RESIDENT_GENDER, FAMILY.FAMILY_ID,CONCAT(FAMILY_ZONE,' ', FAMILY_STREET ,'. ', FAMILY_BARANGAY,', ',FAMILY_CITY)AS ADDRESS,RESIDENT_POSITION from(RESIDENT inner join FAMILY on RESIDENT.FAMILY_ID = FAMILY.FAMILY_ID) WHERE RESIDENT_ID ='" + id.ToString() + "'";
                                    cmds.Connection = Connection.con;
                                    SqlDataReader dar = cmds.ExecuteReader();
                                    if (dar.Read())
                                    {
                                        RID = dar["RESIDENT_ID"].ToString();
                                        imageBytes = dar["resident_image"] as byte[];
                                        fname = dar["NAME"].ToString();
                                        cnum = dar["RESIDENT_CNUM"].ToString();
                                        dob = dar["Det"].ToString();
                                        age = dar["RESIDENT_AGE"].ToString();
                                        add = dar["ADDRESS"].ToString();
                                        gender = dar["RESIDENT_GENDER"].ToString();
                                        Fid = dar["FAMILY_ID"].ToString();
                                        position = dar["RESIDENT_POSITION"].ToString();

                                        if (imageBytes != null)
                                        {
                                            using (var stream = new MemoryStream(imageBytes))
                                                photo.Image = Image.FromStream(stream);


                                        }

                                    }
                                    dar.Close();

                                }
                                catch
                                {
                                    MessageBox.Show("Try Again");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }


                        }
                         else
                         {
                               MakeReport("Fingerprint unrecognized!");
                         }
                        

                    }
                    else
                    {
                        
                    }
                   
                }
              
            }
            catch
            {

            }
            
            
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("fingerprint removed.");
           
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("fingerprint reader touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("fingerprint reader connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("fingerprint reader disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MessageBox.Show("Good");
            else
                MessageBox.Show("Bad");
        }
        #endregion



        protected void SetStatus1(string status)
        {
            this.Invoke((Action)(delegate ()
            {
                label1.Text = status;
            }));
        }

        public void SetPrompt(string prompt)
        {
            this.Invoke((Action)(delegate ()
            {
                textBox1.Text = prompt;
            }));
        }

        protected void MakeReport(string message)
        {
            this.Invoke((Action)(delegate ()
            {
                textBox2.AppendText(message + "\r\n");
            }));
        }

        public void DrawPicture(Bitmap bitmap)
        {
            this.Invoke((Action)(delegate ()
            {
                pictureBox1.Image = new Bitmap(bitmap, pictureBox1.Size);
            }));
        }


        protected virtual void Process(DPFP.Sample Sample)
        {
            // draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
            
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            Init();
            

        }

        private void CaptureForm_Leave(object sender, EventArgs e)
        {
            Stop();
        }




        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Start();  
            f.Text = "";
            bd.Text = "";
            ag.Text = "";
            cn.Text = "";
            address.Text = ""; 
            gen.Text = "";                                                               
            mamshie.Text = "";
            papshie.Text = "";
            Clear();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
           
            viewBtn.Enabled = false;
            price.Visible = false;
            selection.Visible = false;               
            previewBtn.Visible = false;
            viewBtn.Visible = true;
        }
        private void Clear()
        {
            fname = null;
            dob = null;
            cnum = null;
            add = null;
            age = null;
            gender = null;
            mother = null;
            father = null;
            photo.Image = null;

            imageBytes = null;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (photo.Image == null)
            {
                MessageBox.Show("Scan fingerprint again");
            }
            else
            {
                f.Text = fname.ToString();
                bd.Text = dob.ToString();
                ag.Text = age.ToString();
                cn.Text = cnum.ToString();
                address.Text = add.ToString();
                gen.Text = gender.ToString();
                fampos.Text = position.ToString();
                //   label8.Text = Fid.ToString();
                //  mamshie.Text = mother.ToString();                              
                //  papshie.Text = father.ToString();
                FamilyInfo();
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                viewBtn.Enabled = false;
                viewBtn.Visible = false;
                price.Visible = true;
                selection.Visible = true;
                previewBtn.Visible = true;
            }
        }

       
        string mother;
        string father;

        private void FamilyInfo()
        {
            Connection conect = new Connection();
            conect.Connect();

            SqlCommand cmds1 = new SqlCommand();
            SqlCommand cmds2 = new SqlCommand();
            SqlCommand cmds3 = new SqlCommand();
                                                                      
            cmds1.Connection = Connection.con;
            cmds2.Connection = Connection.con;                       

            

            if (fampos.Text == "Son")
            {
                cmds2.CommandText = "select concat(resident_fname,' ',resident_mname,'. ',resident_lname) as Papa from resident  where resident_position = 'Father' and family_id ='" + Fid.ToString() + "'";
                cmds1.CommandText = "select concat(resident_fname,' ',resident_mname,'. ',resident_lname) as Mama from resident  where resident_position = 'Mother' and family_id ='" + Fid.ToString() + "'";

                try
                {
                    SqlDataReader dara = cmds1.ExecuteReader();
                    if (dara.Read())
                    {                                                 
                        mother = dara["Mama"].ToString();
                    }
                    dara.Close();
                    SqlDataReader dara1 = cmds2.ExecuteReader();
                    if (dara1.Read())
                    {
                        father = dara1["Papa"].ToString();
                    }
                    dara1.Close();
                    mamshie.Text = mother.ToString();
                    papshie.Text = father.ToString();
                }
                catch
                {

                }
               
            }
            else if (fampos.Text == "Daughter")
            {
                cmds2.CommandText = "select concat(resident_fname,' ',resident_mname,'. ',resident_lname) as Papa from resident  where resident_position = 'Father' and family_id ='" + Fid.ToString() + "'";
                cmds1.CommandText = "select concat(resident_fname,' ',resident_mname,'. ',resident_lname) as Mama from resident  where resident_position = 'Mother' and family_id ='" + Fid.ToString() + "'";
                try
                {
                    SqlDataReader dara = cmds1.ExecuteReader();
                    if (dara.Read())
                    {

                        mother = dara["Mama"].ToString();
                    }
                    dara.Close();
                    SqlDataReader dara1 = cmds2.ExecuteReader();
                    if (dara1.Read())
                    {
                        father = dara1["Papa"].ToString();
                    }
                    dara1.Close();
                    mamshie.Text = mother.ToString();
                    papshie.Text = father.ToString();

                }
                catch
                {

                }
                
            }
            else if (fampos.Text == "Mother")
            {
                cmds2.CommandText = "select concat(resident_fname,' ',resident_mname,'. ',resident_lname) as Papa from resident  where resident_position = 'Grandfather' and family_id ='" + Fid.ToString() + "'";
                cmds1.CommandText = "select concat(resident_fname,' ',resident_mname,'. ',resident_lname) as Mama from resident  where resident_position = 'Grandmother' and family_id ='" + Fid.ToString() + "'";
                try
                {
                    SqlDataReader dara = cmds1.ExecuteReader();
                    if (dara.Read())
                    {

                        mother = dara["Mama"].ToString();
                    }
                    dara.Close();
                    SqlDataReader dara1 = cmds2.ExecuteReader();
                    if (dara1.Read())
                    {
                        father = dara1["Papa"].ToString();
                    }
                    dara1.Close();
                    mamshie.Text = mother.ToString();
                    papshie.Text = father.ToString();
                }
                catch
                {

                }
                
            }
            else if (fampos.Text == "Father")
            {
                cmds2.CommandText = "select concat(resident_fname,' ',resident_mname,'. ',resident_lname) as Papa from resident  where resident_position = 'Grandfather' and family_id ='" + Fid.ToString() + "'";
                cmds1.CommandText = "select concat(resident_fname,' ',resident_mname,'. ',resident_lname) as Mama from resident  where resident_position = 'Grandmother' and family_id ='" + Fid.ToString() + "'";
                try
                {
                    SqlDataReader dara = cmds1.ExecuteReader();
                    if (dara.Read())
                    {

                        mother = dara["Mama"].ToString();
                    }
                    dara.Close();
                    SqlDataReader dara1 = cmds2.ExecuteReader();
                    if (dara1.Read())
                    {
                        father = dara1["Papa"].ToString();
                    }
                    dara1.Close();
                    mamshie.Text = mother.ToString();
                    papshie.Text = father.ToString();
                }
                catch
                {

                }
               
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
           
            if (price.Text == "" || price.Text == "Price")
            {
                MessageBox.Show("Price Should be specified or set to 0 if free");
            }
            else
            {
                if (selection.SelectedIndex == 0)
                {
                    StaffInfo();
                    BarangayClearance bc = new BarangayClearance();
                    bc.names = f.Text.Trim();
                    bc.add = address.Text.Trim();
                    bc.ID = this.stffNme.Trim();
                    bc.StffName = stffID.Trim();
                    bc.RID = this.RID.Trim();                        
                    bc.Price = price.Text.Trim();
                    bc.ShowDialog();
                }                      

                else if (selection.SelectedIndex == 1)
                {
                    StaffInfo();
                    BusinessPermit bp = new BusinessPermit();
                    bp.names = f.Text.Trim();
                    bp.add = address.Text.Trim();
                    bp.ID = this.stffNme.Trim();
                    bp.StffName = stffID.Trim();
                    bp.RID = this.RID.Trim();     
                    bp.Price = price.Text.Trim();
                    bp.ShowDialog();
                }
            }
                 
        }
        
       
      

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void price_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void transactions_Click(object sender, EventArgs e)
        {
               this.Controls.Clear();
               Transactions tr = new Transactions();
               this.Controls.Add(tr);
               tr.IDA = this.ID;
               tr.Dock = DockStyle.Fill;
               tr.Show();                                                  
        }
        string stffID;
        string stffNme;
        public void StaffInfo()
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmds = new SqlCommand();
            cmds.CommandText = "select CONCAT(staff_fname,' ',staff_mname,'. ',staff_lname) AS NAME, staff_id from STAFF where STAFF_ID = '" +staffID.Text+ "'";
            cmds.Connection = Connection.con;
            SqlDataReader dar = cmds.ExecuteReader();
            if (dar.Read())
            {
                stffID = dar["NAME"].ToString();
                stffNme = dar["staff_id"].ToString();
            }
        }
    }
}

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
using AForge.Video;
using AForge.Video.DirectShow;
using DarrenLee.Media;
using System.IO;


namespace iliekbarangay
{
    public partial class AddFamily : UserControl, DPFP.Capture.EventHandler
    {
         
        private static AddFamily _instance;
        public static AddFamily Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddFamily();
                return _instance;
            }
        }
        public Panel Body
        {
            get { return addbody; }
            set { addbody = value; }
        }

        private string ids;
        public String ID
        {
            get { return ids; }
            set { ids = value; }
        }

        public void DisplayID()
        {
            identification.Text = ID;
        }


        int count = 0;
        Camera myCamera = new Camera();

       
        DPFP.Capture.SampleConversion sp = new DPFP.Capture.SampleConversion();
        DPFP.Capture.Capture cp = new DPFP.Capture.Capture();
        DPFP.Sample sample = new DPFP.Sample();
        public AddFamily()
        {
            InitializeComponent();
            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;                     
            timer1.Start();                   
            Enroller = new DPFP.Processing.Enrollment();
            identification.Parent = addbody;

        }
        private DPFP.Processing.Enrollment Enroller;
        
        public delegate void OnTemplateEventHandler(DPFP.Template template);

        public event OnTemplateEventHandler OnTemplate;

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            
            if (familyName.Text == "" || houseHoldNum.Text == "" || Purok.Text =="" || Barangay.Text == "" || City.Text == "" ||  home == "" || residentStat == "" || lotype == "" || lengthOR == "" || waterS == "" ||waterC == "" ||garbase == "" || cr =="")
            {
                MessageBox.Show("Please dont leave empty spaces");
            }
            else
            {
                string fac ="";
                try
                {
                    if (facility.CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < facility.CheckedItems.Count; i++)
                        {
                            if (fac == "")
                            {
                                fac = facility.CheckedItems[i].ToString();
                            }
                            else
                            {
                                fac += ", " + facility.CheckedItems[i].ToString();
                            }
                        }
                        if (LFMdata.DataSource == null)
                        {
                            MessageBox.Show("No Resident Added!");
                        }
                        else
                        {
                            Connection con = new Connection();
                            con.Connect();
                            SqlCommand cmd = new SqlCommand();
                            SqlCommand cmd2 = new SqlCommand();
                            cmd.CommandText = "INSERT INTO FAMILY(FAMILY_NAME,FAMILY_HOUSEHOLD_NUM,FAMILY_ZONE,FAMILY_STREET,FAMILY_BARANGAY,FAMILY_CITY,FAMILY_DATE_REGISTERED,FAMILY_HOME_STRUCTURE,FAMILY__RESIDENTIAL_STATUS,FAMILY_LOT_TYPE,FAMILY_RESIDENCY_LENGTH,FAMILY_WATER_SOURCE,FAMILY_WATER_PAYMENT,FAMILY_CR,FAMILY_GARBAGE_SYSTEM,FAMILY_COMMUNITY_FACILITIES,STAFF_ID)" +
                                " VALUES(@family, @hh, @zone,@street,@barangay,@city,@dateR,@hs,@rs,@lt,@rl,@ws,@wp,@cr,@gs,@cf,@sid)";

                            cmd2.CommandText = "UPDATE RESIDENT SET FAMILY_ID =(SELECT MAX(FAMILY_ID) FROM FAMILY) WHERE FAMILY_ID IS NULL";
                            cmd.Connection = Connection.con;
                            cmd2.Connection = Connection.con;

                            cmd.Parameters.AddWithValue("@family", familyName.Text);
                            cmd.Parameters.AddWithValue("@hh", houseHoldNum.Text);
                            cmd.Parameters.AddWithValue("@zone", Purok.Text);
                            cmd.Parameters.AddWithValue("@street", street.Text);
                            cmd.Parameters.AddWithValue("@barangay", Barangay.Text);
                            cmd.Parameters.AddWithValue("@city", City.Text);
                            cmd.Parameters.AddWithValue("@dateR", dateTaken.Text);
                            cmd.Parameters.AddWithValue("@hs", home);
                            cmd.Parameters.AddWithValue("@rs", residentStat);
                            cmd.Parameters.AddWithValue("@lt", lotype);
                            cmd.Parameters.AddWithValue("@rl", lengthOR);
                            cmd.Parameters.AddWithValue("@ws", waterS);
                            cmd.Parameters.AddWithValue("@wp", waterC);
                            cmd.Parameters.AddWithValue("@cr", cr);
                            cmd.Parameters.AddWithValue("@gs", garbase);
                            cmd.Parameters.AddWithValue("@cf", fac);
                            cmd.Parameters.AddWithValue("@sid", ID);
                            cmd.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            
                            MessageBox.Show("Family Added Successfully");

                            this.Controls.Clear();
                            tab_residents tr = new tab_residents();
                            this.Controls.Add(tr);
                            tr.ID = this.ID.Trim();

                            tr.Dock = DockStyle.Fill;
                            tr.Show();

                            SqlDataAdapter da = new SqlDataAdapter("select RESIDENT_LNAME AS Lastname,RESIDENT_FNAME AS Firstname,RESIDENT_MNAME AS MI,RESIDENT_AGE AS Age,RESIDENT_POSITION AS Position,RESIDENT_FAMILY_HEAD AS Family_Head from resident where family_id is null", Connection.con);
                            SqlCommandBuilder cd = new SqlCommandBuilder(da);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            LFMdata.DataSource = dt;
                            
                          
                            timer1.Stop();
                            All_Clear();
                            Reset();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("You should select facilities around your area");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.ToString());
                }

            }
           


        }
        public void FMPIclear()
        {//Clearing Fields for registration.
            fname.Text = null;
            lname.Text = null;
            mi.Text = null;
            cnum.Text = null;
            DOB.Value = DateTime.Now;
            gender.Text = null;
            civilRegStat.Text = null;
            maritalStatus.Text = null;
            familyPos.Text = null;
            eduStat.Text = null;
            eduLvl.Text = null;
            sourceOfFund.Text = null;
            jobType.Text = null;
            monthlyIncome.Text = null;
            familyHead.Text = null;
            YrLvl.Text = null;
            skill.Text = null;
            while (healthProblems.CheckedIndices.Count > 0)
            {
                healthProblems.SetItemChecked(healthProblems.CheckedIndices[0], false);
            }
            while (vaccineTaken.CheckedIndices.Count > 0)
            {
                vaccineTaken.SetItemChecked(vaccineTaken.CheckedIndices[0], false);
            }
            while (healthStatus.CheckedIndices.Count > 0)
            {
                healthStatus.SetItemChecked(healthStatus.CheckedIndices[0], false);
            }
            res_Image.Image = null;  
            SetPrompt("Click 'Fingerprint' to scan.");
            MakeReport("");

        }
        
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            FMPIclear();   
            this.Refresh();
            Reset();
        }
        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {

            Image img = e.GetFrame();
            res_Image.Image = img;
        }

        private void takePhotoBtn_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\" + "Image" + count.ToString();
            myCamera.Capture(filename);
            count++;
            myCamera.Stop();
            takePhotoBtn.Visible = false;
            takePhotoBtn.SendToBack();
            openCamera.Visible = true;
            openCamera.BringToFront();
            MessageBox.Show("Image Captured");
            openCamera.Focus();
        }

        private void openCamera_Click(object sender, EventArgs e)
        {
            myCamera.Start();
            takePhotoBtn.Visible = true;
            takePhotoBtn.BringToFront();
            openCamera.Visible = false;
            openCamera.SendToBack();
        }


        private void saveResBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                var mydate = DateTime.Now;
                string healthStat = "";
                string healthProb = "";
                string vaccine = "";
                if (fname.Text == "" || lname.Text == "" || YrLvl.Text == "" || skill.Text == "")
                {
                    MessageBox.Show("Please fill up all forms");
                }
                else
                {
                   try
                    {
                        if (healthProblems.CheckedItems.Count > 0 && healthStatus.CheckedItems.Count > 0 && vaccineTaken.CheckedItems.Count > 0)
                        {
                            for (int i = 0; i < healthProblems.CheckedItems.Count; i++)
                            {
                                if (healthProb == "")
                                {
                                    healthProb = healthProblems.CheckedItems[i].ToString();
                                }
                                else
                                {
                                    healthProb += ", " + healthProblems.CheckedItems[i].ToString();
                                }
                            }
                            for (int i = 0; i < healthStatus.CheckedItems.Count; i++)
                            {
                                if (healthStat == "")
                                {
                                    healthStat = healthStatus.CheckedItems[i].ToString();
                                }
                                else
                                {
                                    healthStat += ", " + healthStatus.CheckedItems[i].ToString();
                                }
                            }
                            for (int i = 0; i < vaccineTaken.CheckedItems.Count; i++)
                            {
                                if (vaccine == "")
                                {
                                    vaccine = vaccineTaken.CheckedItems[i].ToString();
                                }
                                else
                                {
                                    vaccine += ", " + vaccineTaken.CheckedItems[i].ToString();
                                }
                            }
                            Connection con = new Connection();
                            con.Connect();
                            SqlCommand cmd = new SqlCommand();
                            SqlCommand scmd = new SqlCommand();
                            cmd.CommandText = "INSERT INTO resident(RESIDENT_FNAME,RESIDENT_MNAME,RESIDENT_LNAME,RESIDENT_CNUM,RESIDENT_DOB,RESIDENT_CIVIL_REGESTERED,RESIDENT_MARITAL,RESIDENT_POSITION,RESIDENT_FAMILY_HEAD,RESIDENT_GENDER,RESIDENT_EDUC_STATUS,RESIDENT_EDUC_LVL,RESIDENT_EDUC_GRADE,RESIDENT_SPECIALSKILL,RESIDENT_SOURCE_OF_FUND,RESIDENT_JOB_TYPE,RESIDENT_INCOME,RESIDENT_HEALTH_PROBLEM,RESIDENT_HEALTH_STATUS,RESIDENT_VACCINE,RESIDENT_IMAGE,RESIDENT_FINGERPRINT,STAFF_ID) " +
                                "VALUES(@fname,@mname,@lname,@cnum,@dob,@civilReg,@marital,@position,@head,@gender,@eduStatus,@eduLevel,@gradeLevel,@skill,@sof,@job,@income,@healthProb,@healthStat,@vaccine,@pic,@finger,@sid)";
                            scmd.CommandText = "update resident set resident_age = datediff(YY, resident_dob,GETDATE())";
                            cmd.Connection = Connection.con;
                            scmd.Connection = Connection.con;
                           
                           
                            if (res_Image.Image == null)
                            {
                                MessageBox.Show("Please take a photo");
                                
                            }                              
                            else if (fingerPrint1.Image == null)
                            {
                                MessageBox.Show("Please scan your fingerprint!");
                               
                            }
                            
                            else if (cnum.Text.Length < 11 || cnum.Text.Length >11)
                            {
                                MessageBox.Show("Check your Contact Number!");
                                cnum.Focus();
                            }
                            else if (mi.Text.Length > 1 )
                            {
                                MessageBox.Show("Initials should be 1 character!");
                                mi.Focus();
                            }
                            else if (healthStatus.CheckedItems.Count >= 2)
                            {
                                MessageBox.Show("Only choose 1 health status!");
                                healthStatus.Focus();
                            }
                            else if (healthProblems.CheckedItems.Count > 3)
                            {
                                MessageBox.Show("Only choose 3 health problems!");
                                healthProblems.Focus();
                            }
                            else if (DOB.Value >= DateTime.Now.AddYears(-2))
                            {
                                MessageBox.Show("System is available only for 3 years old and above!");
                            }
                            else if (DOB.Value > DateTime.Now)
                            {
                                MessageBox.Show("Date must be in the past!");
                                DOB.Focus();
                            }
                            else if (prompts.Text != "Done.")
                            {
                                MessageBox.Show("Unclear Fingerprint Captured!");
                                Reset();
                            }
                            else
                            {
                                UpdateStatus();
                                switch (Enroller.TemplateStatus)
                                {
                                    case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
                                        {
                                            
                                           
                                            //  byte[] btarr = null;
                                            // Enroller.Template.Serialize(ref btarr);
                                            MemoryStream fingerprint = new MemoryStream();
                                            Enroller.Template.Serialize(fingerprint);
                                            fingerprint.Position = 0;
                                            BinaryReader br = new BinaryReader(fingerprint);
                                            byte[] bytes = br.ReadBytes((Int32)fingerprint.Length);



                                            try
                                            {
                                               
                                                MemoryStream stream = new MemoryStream();                                               
                                                fingerprint.Position = (0);
                                                res_Image.Image = resizeImage(res_Image.Image, new Size(177, 151));
                                                res_Image.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                //fingerPrint1.Image.Save(fingerprint, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                byte[] pic = stream.ToArray();
                                               // byte[] fic = br.ReadBytes((Int32)fingerprint.Length);
                                                cmd.Parameters.AddWithValue("@fname", fname.Text);
                                                cmd.Parameters.AddWithValue("@mname", mi.Text);
                                                cmd.Parameters.AddWithValue("@lname", lname.Text);
                                                cmd.Parameters.AddWithValue("@cnum", cnum.Text);
                                                cmd.Parameters.AddWithValue("@dob", DOB.Value);
                                                cmd.Parameters.AddWithValue("@gender", gender.Text);
                                                cmd.Parameters.AddWithValue("@civilReg", civilRegStat.Text);
                                                cmd.Parameters.AddWithValue("@marital", maritalStatus.Text);
                                                cmd.Parameters.AddWithValue("@position", familyPos.Text);
                                                cmd.Parameters.AddWithValue("@head", familyHead.Text);
                                                cmd.Parameters.AddWithValue("@eduStatus", eduStat.Text);
                                                cmd.Parameters.AddWithValue("@eduLevel", eduLvl.Text);
                                                cmd.Parameters.AddWithValue("@gradeLevel", YrLvl.Text);
                                                cmd.Parameters.AddWithValue("@skill", skill.Text);
                                                cmd.Parameters.AddWithValue("@income", monthlyIncome.Text);
                                                cmd.Parameters.AddWithValue("@sof", sourceOfFund.Text);
                                                cmd.Parameters.AddWithValue("@job", jobType.Text);
                                                cmd.Parameters.AddWithValue("@healthProb", healthProb);
                                                cmd.Parameters.AddWithValue("@healthStat", healthStat);
                                                cmd.Parameters.AddWithValue("@vaccine", vaccine);
                                                cmd.Parameters.AddWithValue("@finger", bytes);
                                                cmd.Parameters.AddWithValue("@pic", pic);
                                                cmd.Parameters.AddWithValue("@sid", ID);
                                                cmd.ExecuteNonQuery();
                                                scmd.ExecuteNonQuery();
                                                MessageBox.Show("Resident Added Successfully");
                                                
                                                FMPIclear();
                                                myCamera.Stop();
                                                

                                                res_Image.Image = null;
                                                fingerPrint1.Image = null;

                                                SqlDataAdapter da = new SqlDataAdapter("select RESIDENT_LNAME AS Lastname,RESIDENT_FNAME AS Firstname,RESIDENT_MNAME AS MI,RESIDENT_AGE AS Age,RESIDENT_POSITION AS Position,RESIDENT_FAMILY_HEAD AS Family_Head from resident where family_id is null", Connection.con);
                                                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                                                DataTable dt = new DataTable();
                                                da.Fill(dt);
                                                LFMdata.DataSource = dt;
                                                
                                                Reset();

                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message + ex.ToString());
                                                Reset();
                                            }
                                            break;
                                        }

                                    case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
                                        {
                                            Enroller.Clear();
                                            cp.StopCapture();
                                            UpdateStatus();
                                            OnTemplate(null);
                                            cp.StartCapture();
                                            break;
                                        }
                                }
                              
                            }
                           

                        }

                        else
                        {
                            MessageBox.Show("Dont leave empty spaces");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.ToString());
                    }
                }
                

               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }    
         
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTaken.Text = DateTime.Now.ToString("MMM. dd yyyy, hh:mm tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Are you sure to cancel operation?","Okay",MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {
                
                All_Clear();    
                this.Controls.Clear();
                tab_residents tr = new tab_residents();
                this.Controls.Add(tr);
                tr.ID = this.ID.Trim();
                tr.Dock = DockStyle.Fill;
                tr.Show();

                timer1.Stop();
                
                SqlDataAdapter da = new SqlDataAdapter("delete from resident where family_id is null", Connection.con);
                SqlCommandBuilder cd = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LFMdata.DataSource = dt;
                UpdateStatus();   
                Reset();
            }
            else if(resu == DialogResult.No)
            {

            }



            
        }
        string home = "";
        string residentStat = "";
        string lotype = "";
        string lengthOR = "";
        string waterS = "";
        string waterC = "";
        string cr = "";
        string garbase= "";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            home = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            home = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            home = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            home = radioButton4.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            home = radioButton5.Text;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            residentStat = radioButton9.Text;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            residentStat = radioButton10.Text;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            residentStat = radioButton7.Text;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            residentStat = radioButton8.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            residentStat = radioButton6.Text;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            residentStat = radioButton11.Text;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            lotype = radioButton15.Text;                   
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            lotype = radioButton16.Text;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            lotype = radioButton13.Text;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            lotype = radioButton14.Text;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            lotype = radioButton12.Text;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            lengthOR = radioButton20.Text;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            lengthOR = radioButton21.Text;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            lengthOR = radioButton18.Text;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            lengthOR = radioButton19.Text;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            lengthOR = radioButton17.Text;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            waterS = radioButton25.Text;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            waterS = radioButton26.Text;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            waterS = radioButton23.Text;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            waterS = radioButton24.Text;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            waterS = radioButton22.Text;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            waterS = radioButton27.Text;
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            waterS = radioButton28.Text;
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            waterC = radioButton34.Text;
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            waterC = radioButton35.Text;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            waterC = radioButton32.Text;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            waterC = radioButton33.Text;
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            cr = radioButton38.Text;
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            cr = radioButton39.Text;
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            cr = radioButton36.Text;
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            cr = radioButton37.Text;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            cr = radioButton31.Text;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            cr = radioButton30.Text;
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            garbase = radioButton43.Text;
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            garbase = radioButton44.Text;
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            garbase = radioButton41.Text;
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            garbase = radioButton42.Text;
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            garbase = radioButton40.Text;
        }
        public void All_Clear()
        {
            familyName.Text = null;
            houseHoldNum.Text = null;
            Purok.Text = null;
            street.Text = null;
            Barangay.Text = null;
            City.Text = null;
            homeStructure.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            residentialStatus.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            lotType.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            residencyLength.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            waterSource.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            waterPayment.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            comfortRoom.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            garbageSystem.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            while (facility.CheckedIndices.Count > 0)
            {
                facility.SetItemChecked(facility.CheckedIndices[0], false);
            }
            FMPIclear();
        }

        //Fingerprint part z

        delegate void Function();
        private void AddFamily_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }

        private void AddFamily_Load(object sender, EventArgs e)
        {
            addbody.Focus();
            identification.Text = ID ;
        }

        private void fingerSave_Click(object sender, EventArgs e)
        {
            cp.StartCapture();
            cp.EventHandler = this;
            
        }

        string result;
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            Connection con = new Connection();
            con.Connect();
            SqlCommand cmds = new SqlCommand();
            cmds.CommandText = "Select count(resident_id) as a from resident";
            cmds.Connection = Connection.con;      
            cmds.ExecuteScalar();
            SqlDataReader rdr = cmds.ExecuteReader();
            if (rdr.Read())
            {              
                result = rdr["a"].ToString();
                rdr.Close();
            }
            

            if(result == "0")
            {
                MakeReport("fingerprint captured.");
                SetPrompt("Scan fingerprint again");
                Process(Sample); 
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = " select resident_fingerprint from resident ";
                    cmd.Connection = Connection.con;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        byte[] _img = (byte[])dr["resident_fingerprint"];
                        //string id = dr["RESIDENT_ID"].ToString();                                                         
                        MemoryStream ms = new MemoryStream(_img);
                        DPFP.Template Template = new DPFP.Template();
                        Template.DeSerialize(ms);
                        DPFP.Verification.Verification Verificator = new DPFP.Verification.Verification();

                        //Process(Sample);

                        DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
                        if (features != null)
                        {
                            DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                            Verificator.Verify(features, Template, ref result);
                            // UpdateStatus(result.FARAchieved);
                            if (result.Verified)
                            {
                                MessageBox.Show("This Resident is already Registered!!!");
                                Reset();
                                FMPIclear();
                                break;

                            }
                            else if (scans.Text != "0 scans left")
                            {
                                MakeReport("fingerprint captured.");
                                SetPrompt("Scan fingerprint again");
                                Process(Sample);
                            }
                            else
                            {
                                cp.StopCapture();
                                break;
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
            //Process(Sample);


        }


        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("fingerprint removed.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumbe )
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

        private void CaptureForm_Load(object sender, EventArgs e)
        {
           
            cp.StartCapture();
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cp.StopCapture();
        }
        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("{0} scans left", Enroller.FeaturesNeeded));
        }
        protected void SetStatus(string status)
        {
            this.Invoke((Action)(delegate ()
            {
                scans.Text = status;
            }));
        }

        public void SetPrompt(string prompt)
        {
            this.Invoke((Action)(delegate () {
                prompts.Text = prompt;
            }));
        }

        protected void MakeReport(string message)
        {
            this.Invoke((Action)(delegate ()
            {
                StatusLine.Text = message;
            }));
        }

        public void DrawPicture(Bitmap bitmap)
        {
            this.Invoke((Action)(delegate ()
            {
                fingerPrint1.Image = new Bitmap(bitmap, fingerPrint1.Size);
            }));
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            // draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);
            DPFP.Capture.SampleConversion ToByte = new DPFP.Capture.SampleConversion();
            
            // Check quality of the sample and add to enroller if it's good
            if (features != null) try
                {
                    MakeReport("The fingerprint feature set was created.");
                    Enroller.AddFeatures(features);

                }
                finally
                {
                    UpdateStatus();


                  switch (Enroller.TemplateStatus)
                        {
                            case DPFP.Processing.Enrollment.Status.Ready:	// report success and stop capturing
                                //OnTemplate(Enroller.Template);

                                SetPrompt("Done.");
                           
                           
                                cp.StopCapture();
                                break;

                            case DPFP.Processing.Enrollment.Status.Failed:	// report failure and restart capturing
                                Enroller.Clear();
                                cp.StopCapture();
                                UpdateStatus();
                               // OnTemplate(null);
                                cp.StartCapture();
                                break;
                        }

                }
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

        private void addbody_MouseEnter(object sender, EventArgs e)
        {
           
        }
        public void Reset()
        {
            Enroller.Clear();           
            UpdateStatus();
            SetPrompt("Give fingerprint samples again.");
            fingerPrint1.Image = null;             
            cp.StopCapture();
        }

        private void FMPI_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Purok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }                         

        private void familyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void cnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

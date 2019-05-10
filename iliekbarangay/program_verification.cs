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

namespace iliekbarangay
{
    public partial class program_verification : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        private DPFP.Verification.Verification Verificator;
        public program_verification()
        {
            InitializeComponent();
            Start();
            label1.Parent = header;
            SP.BackColor = Color.White;
            MR.BackColor = Color.White;
        }

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

    

        public void SetPrompt(string prompt)
        {
            this.Invoke((Action)(delegate ()
            {
                SP.Text = prompt;
            }));
        }

        protected void MakeReport(string message)
        {
            this.Invoke((Action)(delegate ()
            {
                MR.AppendText(message + "\r\n");
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
        byte[] imageBytes;
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
                cmd.CommandText = "select RESIDENT_FINGERPRINT, RESIDENT.RESIDENT_ID,PROGRAM.PROGRAM_ID,LIST.RESIDENT_ID,LIST.PROGRAM_ID FROM RESIDENT LEFT JOIN LIST ON RESIDENT.RESIDENT_ID = LIST.RESIDENT_ID LEFT JOIN PROGRAM ON PROGRAM.PROGRAM_ID = RESIDENT.RESIDENT_ID WHERE LIST.PROGRAM_ID ='"+label2.Text+"' AND LIST_VERIFICATION IS NULL";
                cmd.Connection = Connection.con;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    byte[] _img = (byte[])dr["resident_fingerprint"];
                    string id = dr["RESIDENT_ID"].ToString();
                    string pid = dr["PROGRAM_ID"].ToString();



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
                        UpdateStatus(result.FARAchieved);
                        if (result.Verified)
                        {
                            MessageBox.Show("Verified!!!");    
                            SqlCommand cmds = new SqlCommand();
                            cmds.CommandText = "UPDATE LIST SET LIST_VERIFICATION ='True' WHERE LIST.RESIDENT_ID = '" + id.ToString() + "' AND LIST.PROGRAM_ID = '"+label2.Text+"'";
                            cmds.Connection = Connection.con;
                            SqlDataReader dar = cmds.ExecuteReader();     
                        }
                        else 
                        {
                            MakeReport("Not registered as a resident!");
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

        private void UpdateStatus(int FAR)
        {
            FARStatus(String.Format("False Accept Rate (FAR = {0})", FAR));
        }

        protected void FARStatus(string status)
        {
            this.Invoke((Action)(delegate ()
            {
                FR.Text = status;
            }));
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand();
            con.Connect();
            cmd.CommandText = "UPDATE PROGRAM SET PARTICIPANTS_REMAINING =PARTICIPANTS_COUNT  - (SELECT COUNT(LIST_VERIFICATION) FROM LIST WHERE PROGRAM_ID = '"+label2.Text+"')WHERE PROGRAM_ID = '"+label2.Text+"'";
            cmd.Connection = Connection.con;
            cmd.ExecuteNonQuery();
            tab_programs.Instance.DisplayInfo();
            this.Close();

            
        }

        private void program_verification_Load(object sender, EventArgs e)
        {
            Init();
            Start();
           
        }

        public void StartCapture()
        {
            Start();
        }

        private void program_verification_Leave(object sender, EventArgs e)
        {
            Stop();
        }

        private void program_verification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
    }
}

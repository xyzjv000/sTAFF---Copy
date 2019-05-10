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
    public partial class tab_dashboard : UserControl
    {
        Connection con = new Connection();
      
        private static tab_dashboard _instance;
        public static tab_dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab_dashboard();
                return _instance;
            }
        }
        public tab_dashboard()
        {
            InitializeComponent();
            timer1.Start();
            date.BackColor = Color.White;
            ResCount();
            FamCount();
            StfCount();
            EmpCount();
            SnrCount();
            StuCount();
            HouseCount();
            Trancients();
            PWDCount();
            chart1.Series["residents"].Points.Clear();
            LoadChartDaugther();
            LoadChartSon();
            LoadChartMother();
            LoadChartFather();
            LoadChartGM();
            LoadChartGF();
        }

        public void LoadChartSon()
        {
            try
            {   
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT count(resident_id) from resident where resident_position = 'Son'";
                cmd.Connection = Connection.con;
                SqlDataReader rdr = cmd.ExecuteReader();

                //chart1.Series["residents"].Points.Clear();

                while (rdr.Read())
                {
                    this.chart1.Series["residents"].Points.AddXY("Son", rdr[0]);
                    

                }
                rdr.Close();
               
            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }
        public void LoadChartDaugther()
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT count(resident_id) from resident where resident_position = 'Daughter'";
                cmd.Connection = Connection.con;
                SqlDataReader rdr = cmd.ExecuteReader();

               // chart1.Series["residents"].Points.Clear();

                while (rdr.Read())
                {
                    this.chart1.Series["residents"].Points.AddXY("Daughter", rdr[0]);


                }
                rdr.Close();

            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }

        public void LoadChartMother()
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT count(resident_id) from resident where resident_position = 'Mother'";
                cmd.Connection = Connection.con;
                SqlDataReader rdr = cmd.ExecuteReader();

                // chart1.Series["residents"].Points.Clear();

                while (rdr.Read())
                {
                    this.chart1.Series["residents"].Points.AddXY("Mother", rdr[0]);


                }
                rdr.Close();

            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }

        public void LoadChartFather()
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT count(resident_id) from resident where resident_position = 'Father'";
                cmd.Connection = Connection.con;
                SqlDataReader rdr = cmd.ExecuteReader();

                // chart1.Series["residents"].Points.Clear();

                while (rdr.Read())
                {
                    this.chart1.Series["residents"].Points.AddXY("Father", rdr[0]);


                }
                rdr.Close();

            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }

        public void LoadChartGM()
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT count(resident_id) from resident where resident_position = 'Grandmother'";
                cmd.Connection = Connection.con;
                SqlDataReader rdr = cmd.ExecuteReader();

                // chart1.Series["residents"].Points.Clear();

                while (rdr.Read())
                {
                    this.chart1.Series["residents"].Points.AddXY("Grandmother", rdr[0]);


                }
                rdr.Close();

            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }

        public void LoadChartGF()
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT count(resident_id) from resident where resident_position = 'GrandFather'";
                cmd.Connection = Connection.con;
                SqlDataReader rdr = cmd.ExecuteReader();

                // chart1.Series["residents"].Points.Clear();

                while (rdr.Read())
                {
                    this.chart1.Series["residents"].Points.AddXY("Grandfather", rdr[0]);


                }
                rdr.Close();

            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }


        public void ResCount()
        {
            SqlCommand Rescmd = new SqlCommand();
            Rescmd.CommandText = "select count(resident_id) as a from resident where family_id is not null";
            Rescmd.Connection = Connection.con;
            SqlDataReader dr = Rescmd.ExecuteReader();
            if (dr.Read())
            {
                res.Text = dr["a"].ToString();
            }
            dr.Close();
        }
        public void FamCount()
        {
            SqlCommand Famcmd = new SqlCommand();
            Famcmd.CommandText = "select count(family_id) as a from family";
            Famcmd.Connection = Connection.con;
            SqlDataReader dr = Famcmd.ExecuteReader();
            if (dr.Read())
            {
                fam.Text = dr["a"].ToString();
            }
            dr.Close();
        }

        public void StfCount()
        {
            SqlCommand Stfcmd = new SqlCommand();
            Stfcmd.CommandText = "select count(staff_id) as a from staff";
            Stfcmd.Connection = Connection.con;
            SqlDataReader dr = Stfcmd.ExecuteReader();
            if (dr.Read())      
            {                   
                stf.Text = dr["a"].ToString();
            }
            dr.Close();
        }

        public void EmpCount()
        {
            SqlCommand Stfcmd = new SqlCommand();
            Stfcmd.CommandText = "select count(resident_id) as a from resident where RESIDENT_SOURCE_OF_FUND = 'Employed'";
            Stfcmd.Connection = Connection.con;
            SqlDataReader dr = Stfcmd.ExecuteReader();
            if (dr.Read())
            {
                empTxt.Text = dr["a"].ToString() + " Residents";
            }
            dr.Close();
        }

        public void PWDCount()
        {
            SqlCommand Stfcmd = new SqlCommand();
            Stfcmd.CommandText = "select count(resident_id) as a from resident where RESIDENT_HEALTH_PROBLEM LIKE'%Punkol%' OR RESIDENT_HEALTH_PROBLEM LIKE'%Abnormal%' OR RESIDENT_HEALTH_PROBLEM LIKE'%Blind%' OR RESIDENT_HEALTH_PROBLEM LIKE'%Crippled%' OR RESIDENT_HEALTH_PROBLEM LIKE'%Cleft%' OR RESIDENT_HEALTH_PROBLEM LIKE'%Leprosy%' OR RESIDENT_HEALTH_PROBLEM LIKE'%Limped%'";
            Stfcmd.Connection = Connection.con;
            SqlDataReader dr = Stfcmd.ExecuteReader();
            if (dr.Read())
            {
                label13.Text = dr["a"].ToString() + " Residents";
            }
            dr.Close();
        }

        public void StuCount()
        {
            SqlCommand Stfcmd = new SqlCommand();
            Stfcmd.CommandText = "select count(resident_id) as a from resident where RESIDENT_EDUC_STATUS LIKE'ES%'";
            Stfcmd.Connection = Connection.con;
            SqlDataReader dr = Stfcmd.ExecuteReader();
            if (dr.Read())
            {
                label8.Text = dr["a"].ToString() + " Residents";
            }
            dr.Close();
        }


        public void SnrCount()
        {
            SqlCommand Stfcmd = new SqlCommand();
            Stfcmd.CommandText = "select count(resident_id) as a from resident where resident_age  > 59";
            Stfcmd.Connection = Connection.con;
            SqlDataReader dr = Stfcmd.ExecuteReader();
            if (dr.Read())
            {
                label4.Text = dr["a"].ToString() + " Residents";
            }
            dr.Close();
        }

        public void HouseCount()
        {
            SqlCommand Stfcmd = new SqlCommand();
            Stfcmd.CommandText = "select COUNT(distinct FAMILY_HOUSEHOLD_NUM) as a from family";
            Stfcmd.Connection = Connection.con;
            SqlDataReader dr = Stfcmd.ExecuteReader();
            if (dr.Read())
            {
                label6.Text = dr["a"].ToString() + " Households";
            }
            dr.Close();
        }

        public void Trancients()
        {
            SqlCommand Stfcmd = new SqlCommand();
            Stfcmd.CommandText = "select COUNT(resident_id) as a from (resident join family on family.family_id = resident.family_id) where  FAMILY__RESIDENTIAL_STATUS LIKE'%Bed%'";
            Stfcmd.Connection = Connection.con;
            SqlDataReader dr = Stfcmd.ExecuteReader();
            if (dr.Read())
            {
                label11.Text = dr["a"].ToString()+" Residents";
            }
            dr.Close();
        }

        string dt;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                sec.Text = DateTime.Now.ToString("ss");
                time.Text = DateTime.Now.ToString("hh:mm");
                date.Text = DateTime.Now.ToString("dddd");
                day.Text = DateTime.Now.ToString("MM/dd/yyyy");
                bunifuCircleProgressbar1.Value = Convert.ToInt32(sec.Text);

            }
            catch (Exception)
            {
                return;
            }


            String.Format("{0:y yy yyy yyyy}", dt);  // "8 08 008 2008"   year
            String.Format("{0:M MM MMM MMMM}", dt);  // "3 03 Mar March"  month
            String.Format("{0:d dd ddd dddd}", dt);  // "9 09 Sun Sunday" day
            String.Format("{0:h hh H HH}", dt);  // "4 04 16 16"      hour 12/24
            String.Format("{0:m mm}", dt);  // "5 05"            minute
            String.Format("{0:s ss}", dt);  // "7 07"            second
            String.Format("{0:f ff fff ffff}", dt);  // "1 12 123 1230"   sec.fraction
            String.Format("{0:F FF FFF FFFF}", dt);  // "1 12 123 123"    without zeroes
            String.Format("{0:t tt}", dt);  // "P PM"            A.M. or P.M.
            String.Format("{0:z zz zzz}", dt);  // "-6 -06 -06:00"   time zone
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }           
        public void LoadAll()
        {

            ResCount();
            FamCount();
            StfCount();
            EmpCount();
            SnrCount();
            StuCount();
            HouseCount();
            Trancients();
            PWDCount();
            chart1.Series["residents"].Points.Clear();
            LoadChartDaugther();
            LoadChartSon();
            LoadChartMother();
            LoadChartFather();
            LoadChartGM();
            LoadChartGF();
        }

        private void tab_dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

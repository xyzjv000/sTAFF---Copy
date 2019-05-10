using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace iliekbarangay
{
    public partial class FamliyProfile : Form
    {
   
        public String ID
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
       
        
        public FamliyProfile()
        {
            InitializeComponent();
           

           
            
        }
        public  void Display()
        {
            Connection con = new Connection();
            con.Connect();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = "select CONCAT(RESIDENT_LNAME,', ',RESIDENT_FNAME,' ',RESIDENT_MNAME) AS NAME,RESIDENT_AGE AS Age,RESIDENT_POSITION AS POS, RESIDENT_GENDER AS Gender,RESIDENT_ID AS II from resident where FAMILY_ID = '" + textBox1.Text + "' ";
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rd);
                FamilyData.DataSource = dt;
            }
        }

        public String FormName
        {
            get { return formName.Text; }
            set { formName.Text = value; }
        }

        public String FamilyName
        {
            get { return fn.Text; }
            set { fn.Text = value; }
        }

        public String DateReg
        {
            get { return dr.Text; }
            set { dr.Text = value; }
        }

        public String Householdd
        {
            get { return hhn.Text; }
            set { hhn.Text = value; }
        }

        public String HomeStruct
        {
            get { return hs.Text; }
            set { hs.Text = value; }
        }

        public String Residential
        {
            get { return rs.Text; }
            set { rs.Text = value; }
        }

        public String TypeOfLot
        {
            get { return tlcr.Text; }
            set { tlcr.Text = value; }
        }
        public String LengthOfRes
        {
            get { return lr.Text; }
            set { lr.Text = value; }
        }
        public String WaterSource
        {
            get { return ws.Text; }
            set { ws.Text = value; }
        }
        public String WaterCon
        {
            get { return wcp.Text; }
            set { wcp.Text = value; }
        }
        public String Comfort
        {
            get { return cr.Text; }
            set { cr.Text = value; }
        }
        public String Garbage
        {
            get { return gs.Text; }
            set { gs.Text = value; }
        }
        


        private void clsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        byte[] imageBytes;
        string name;
        string age;
        string gender;
        string dob;
        string marital;
        string cnum;
        string add;
        string skill;
        string has;
        string hp;
        string el;
        string ep;
        string es;
        string rid;

        private void FamilyData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                rid = (FamilyData.Rows[e.RowIndex].Cells[4].Value.ToString());

                Connection con = new Connection();
                con.Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT CONCAT(RESIDENT_FNAME,' ',RESIDENT_MNAME,' ',RESIDENT_LNAME) AS NAME ,RESIDENT_AGE,RESIDENT_GENDER,RESIDENT_MARITAL,FORMAT(RESIDENT_DOB,'MMMM d yyyy') as Det,CONCAT(FAMILY_ZONE,' ',FAMILY_STREET,' ',FAMILY_BARANGAY,', ',FAMILY_CITY) AS ADDRESS,RESIDENT_CNUM,RESIDENT_SPECIALSKILL,RESIDENT_HEALTH_STATUS,RESIDENT_HEALTH_PROBLEM,RESIDENT_EDUC_STATUS,resident_image,RESIDENT_EDUC_LVL,RESIDENT_EDUC_GRADE FROM RESIDENT INNER JOIN FAMILY ON RESIDENT.FAMILY_ID = FAMILY.FAMILY_ID WHERE RESIDENT_ID = '" + rid + "'";
                cmd.Connection = Connection.con;
                cmd.ExecuteScalar();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    imageBytes = rdr["resident_image"] as byte[];
                    name = rdr["NAME"].ToString();

                    age = rdr["RESIDENT_AGE"].ToString();
                    gender = rdr["RESIDENT_GENDER"].ToString();
                    dob = rdr["Det"].ToString();
                    marital = rdr["RESIDENT_MARITAL"].ToString();
                    cnum = rdr["RESIDENT_CNUM"].ToString();
                    add = rdr["ADDRESS"].ToString();
                    skill = rdr["RESIDENT_SPECIALSKILL"].ToString();
                    has = rdr["RESIDENT_HEALTH_STATUS"].ToString();
                    hp = rdr["RESIDENT_HEALTH_PROBLEM"].ToString();
                    el = rdr["RESIDENT_EDUC_LVL"].ToString();
                    ep = rdr["RESIDENT_EDUC_STATUS"].ToString();
                    es = rdr["RESIDENT_EDUC_GRADE"].ToString();


                }
                rdr.Close();

                ResidentProfile rp = new ResidentProfile();
                rp.FormName = this.name.Trim();
                rp.Names = this.name.Trim();
                rp.Age = this.age.Trim();
                rp.Gender = this.gender.Trim();
                rp.DOB = this.dob.Trim();
                rp.Marital = this.marital.Trim();
                rp.Cnum = this.cnum.Trim();
                rp.Address = this.add.Trim();
                rp.Skill = this.name.Trim();
                rp.Healthstatus = this.has.Trim();
                rp.Healthproblem = this.hp.Trim();
                rp.EskwelaLvl = this.el.Trim();
                rp.EskwelaPa = this.ep.Trim();
                rp.EskwelaStat = this.es.Trim();
                if (imageBytes != null)
                {
                    using (var stream = new MemoryStream(imageBytes))
                        rp.Images = Image.FromStream(stream);

                }
                rp.ShowDialog();
            }

        }
    }
}

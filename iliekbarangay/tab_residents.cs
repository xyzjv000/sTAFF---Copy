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

namespace iliekbarangay
{
    public partial class tab_residents : UserControl
    {                                          
        private static tab_residents _instance;
        public static tab_residents Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab_residents();
                return _instance;
            }
        }

        private String ids;
        public String ID
        {
            get { return ids; }
            set { ids = value; }
        }

        public void DisplayID()
        {
            identification.Text = ID;
        }


        public void DisableButton()
        {
            addFamily.Visible = false;
        }

        public void EnableButton()
        {
            addFamily.Visible = true;
        }


        public tab_residents()
        {
            InitializeComponent(); 
            Connection con = new Connection();
            con.Connect();
            SqlDataAdapter da = new SqlDataAdapter("select CONCAT(RESIDENT_LNAME,', ',RESIDENT_FNAME,' ',RESIDENT_MNAME) AS NAME,RESIDENT_AGE AS Age,RESIDENT_MARITAL AS Civil_Status, RESIDENT_GENDER AS Gender, RESIDENT_ID AS II from resident where family_id is not null", Connection.con);
           
            SqlCommandBuilder cd = new SqlCommandBuilder(da);                        
            DataTable dt = new DataTable();
            

            da.Fill(dt);     
            residentData.DataSource = dt;
            SqlDataAdapter fa = new SqlDataAdapter("select FAMILY_NAME AS Family_Name, CONCAT(FAMILY_ZONE ,' ',FAMILY_STREET ,',', FAMILY_BARANGAY) AS Address,FAMILY_HOUSEHOLD_NUM AS Household_Num, FAMILY_DATE_REGISTERED AS Date_Registered, FAMILY_ID from FAMILY", Connection.con);
            SqlCommandBuilder cf = new SqlCommandBuilder(fa);
            DataTable dx = new DataTable();
            fa.Fill(dx);
            familyData.DataSource = dx;
            familyData.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            var button = new Bunifu.Framework.UI.BunifuFlatButton();
            button.Click += addFamily_Click; ;

            
            this.identification.Text = ID;

        }


        public Panel Bodys
        {
            get { return bckground; }
            set { bckground = value; }
        }
        

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }                                                                         

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search";
                searchBox.ForeColor = Color.DarkGray;
            }
        }

      

        private void addFamily_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            AddFamily tr = new AddFamily();
            this.Controls.Add(tr);
            tr.ID = this.ID.Trim(); 
            tr.Dock = DockStyle.Fill;
            tr.Show();
           
        }

        private void tab_residents_ControlRemoved(object sender, ControlEventArgs e)
        {
          
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabPage1)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = residentData.DataSource;
                bs.Filter = "NAME like '%" + searchBox.Text + "%'";
                residentData.DataSource = bs;
            }
            else if (metroTabControl1.SelectedTab == metroTabPage2)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = familyData.DataSource;
                bs.Filter = "Family_Name like '%" + searchBox.Text + "%'";
                familyData.DataSource = bs;
            }
           
        }

        private void searchBox_OnValueChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabPage1)
            {
                if (searchBox.Text == "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select CONCAT(RESIDENT_LNAME,', ',RESIDENT_FNAME,' ',RESIDENT_MNAME) AS NAME,RESIDENT_AGE AS Age,RESIDENT_MARITAL AS Civil_Status, RESIDENT_GENDER AS Gender, RESIDENT_ID AS II from resident where family_id is not null", Connection.con);

                    SqlCommandBuilder cd = new SqlCommandBuilder(da);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    residentData.DataSource = dt;
                    residentData.AutoSizeColumnsMode =
                   DataGridViewAutoSizeColumnsMode.Fill;
                   
                }
            }
            else if (metroTabControl1.SelectedTab == metroTabPage2)
            {
                if (searchBox.Text == "")
                {
                    SqlDataAdapter fa = new SqlDataAdapter("select FAMILY_NAME AS Family_Name, CONCAT(FAMILY_ZONE ,' ',FAMILY_STREET ,',', FAMILY_BARANGAY) AS Address,FAMILY_HOUSEHOLD_NUM AS Household_Num, FAMILY_DATE_REGISTERED AS Date_Registered, FAMILY_ID from FAMILY", Connection.con);
                    SqlCommandBuilder cf = new SqlCommandBuilder(fa);
                    DataTable dx = new DataTable();
                    fa.Fill(dx);
                    familyData.DataSource = dx;
                    familyData.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                  
                }
            }
        }

        private void tab_residents_Load(object sender, EventArgs e)
        {
            identification.Text = ID;
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
        string hs;
        string hp;
        string el;
        string ep;
        string es;
        string rid;
        private void residentData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {                                                     
                rid = (residentData.Rows[e.RowIndex].Cells[4].Value.ToString());
                       
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
                    hs = rdr["RESIDENT_HEALTH_STATUS"].ToString();
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
                rp.Healthstatus = this.hs.Trim();
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
        string fid;
        string famNme;
        string DOR;
        string HHN;
        string HS;
        string RES;
        string TOL;
        string LOR;
        string WS;
        string WC;
        string CR;
        string GB;
        string FFID;

        private void familyData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                fid = (familyData.Rows[e.RowIndex].Cells[4].Value.ToString());
                Connection con = new Connection();
                con.Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT FAMILY_ID,FAMILY_NAME,FAMILY_DATE_REGISTERED,FAMILY_HOUSEHOLD_NUM,FAMILY_HOME_STRUCTURE,FAMILY__RESIDENTIAL_STATUS,FAMILY_LOT_TYPE,FAMILY_RESIDENCY_LENGTH,FAMILY_WATER_SOURCE,FAMILY_WATER_PAYMENT,FAMILY_CR,FAMILY_GARBAGE_SYSTEM FROM FAMILY WHERE FAMILY_ID ='" + fid + "'";
                cmd.Connection = Connection.con;
                cmd.ExecuteScalar();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    FFID = rdr["FAMILY_ID"].ToString();
                    famNme = rdr["FAMILY_NAME"].ToString();
                    DOR = rdr["FAMILY_DATE_REGISTERED"].ToString();
                    HHN = rdr["FAMILY_HOUSEHOLD_NUM"].ToString();
                    HS = rdr["FAMILY_HOME_STRUCTURE"].ToString();
                    RES = rdr["FAMILY__RESIDENTIAL_STATUS"].ToString();
                    TOL = rdr["FAMILY_LOT_TYPE"].ToString();
                    LOR = rdr["FAMILY_RESIDENCY_LENGTH"].ToString();
                    WS = rdr["FAMILY_WATER_SOURCE"].ToString();
                    WC = rdr["FAMILY_WATER_PAYMENT"].ToString();
                    CR = rdr["FAMILY_CR"].ToString();
                    GB = rdr["FAMILY_GARBAGE_SYSTEM"].ToString();
                }
                rdr.Close();
                FamliyProfile fp = new FamliyProfile();
                fp.ID = this.FFID.Trim();
                fp.FamilyName = this.famNme.Trim();
                fp.DateReg = this.DOR.Trim();
                fp.Householdd = this.HHN.Trim();
                fp.HomeStruct = this.RES.Trim();
                fp.Residential = this.HS.Trim();
                fp.TypeOfLot = this.TOL.Trim();
                fp.LengthOfRes = this.LOR.Trim();
                fp.WaterSource = this.WS.Trim();
                fp.WaterCon = this.WC.Trim();
                fp.Comfort = this.CR.Trim();
                fp.Garbage = this.GB.Trim();
                fp.Display();
                fp.ShowDialog();
            }
        }

        private void familyData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addResidentBtn.Visible = true;
        }

        private void residentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addResidentBtn.Visible = false;
        }

        private void addResidentBtn_Click(object sender, EventArgs e)
        {
                       
            this.Controls.Clear();
            addResident tr = new addResident();
            this.Controls.Add(tr);
            // tr.ID = this.ID.Trim();
            tr.ID = ID.Trim();
            tr.FID = this.familyData.CurrentRow.Cells[4].Value.ToString();
            tr.Dock = DockStyle.Fill;
            tr.Show();
        }
    }
}

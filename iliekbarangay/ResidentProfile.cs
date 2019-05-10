using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iliekbarangay
{
    public partial class ResidentProfile : Form
    {
        public ResidentProfile()
        {
            InitializeComponent();
        
        }

        public System.Drawing.Image Images
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public String FormName
        {
            get { return formName.Text; }
            set { formName.Text = value; }
        }

        public String Names
        {
            get { return name.Text; }
            set { name.Text = value; }
        }
        public String Age
        {
            get { return age.Text; }
            set { age.Text = value; }
        }
        public String Gender
        {
            get { return gender.Text; }
            set { gender.Text = value; }
        }
        public String Marital
        {
            get { return marital.Text; }
            set { marital.Text = value; }
        }
        public String DOB
        {
            get { return dob.Text; }
            set { dob.Text = value; }
        }
        public String Address
        {
            get { return address.Text; }
            set { address.Text = value; }
        }
        public String Cnum
        {
            get { return cnum.Text; }
            set { cnum.Text = value; }
        }
        public String Skill
        {
            get { return skill.Text; }
            set { skill.Text = value; }
        }
        public String Healthstatus
        {
            get { return healthstatus.Text; }
            set { healthstatus.Text = value; }
        }
        public String Healthproblem
        {
            get { return healthproblem.Text; }
            set { healthproblem.Text = value; }
        }
        public String EskwelaStat
        {
            get { return eskwelaStat.Text; }
            set { eskwelaStat.Text = value; }
        }
        public String EskwelaLvl
        {
            get { return eskwelaLvl.Text; }
            set { eskwelaLvl.Text = value; }
        }
        public String EskwelaPa
        {
            get { return eskwelaPa.Text; }
            set { eskwelaPa.Text = value; }
        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iliekbarangay
{
    public partial class BarangayClearance : Form
    {
        public BarangayClearance()
        {
            InitializeComponent();
            name.Parent = Clearance;
            date.Parent = Clearance;
            address.Parent = Clearance;
            textBox1.Parent = Clearance;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            date.Text = "Issued this "+DateTime.Now.ToString("MMMM dd yyyy")+" Cebu";           
        }

        string rids;
        public String RID
        {
            get { return rids; }
            set { rids = value; }
        }

        string prc;
        public String Price
        {
            get { return prc; }
            set { prc = value; }
        }

       
        string ids;
        public String ID
        {
            get { return ids; }
            set { ids = value; }
        }

        public String names
        {
            get { return name.Text; }
            set { name.Text = value; }
        }

        public String add
        {
            get { return address.Text; }
            set { address.Text = value; }
        }

        public String StffName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        Bitmap MemoryImage;

        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0,0,pnl.Width,pnl.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(MemoryImage != null)
            {
              base.OnPaint(e);
            }
           
        }             

        private void BarangayClearance_Load(object sender, EventArgs e)
        {
            bunifuFlatButton1.Focus();
        }

        void printdoc1_PrintPage(Object sender, PrintPageEventArgs e)
        {
           

        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage,(pagearea.Width/2)-(this.Clearance.Width/2),this.Clearance.Location.Y);
           
        }

        public void Prints(Panel pnl)
        {
            Clearance = pnl;
            GetPrintArea(pnl);                                      
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

   
        private void Clearance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clearance_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Short", 612, 792);
            Prints(this.Clearance);
            try
            {
                SqlCommand dcmd = new SqlCommand();
                dcmd.CommandText = "Delete from logs where transaction_id = (SELECT MAX(transaction_id) FROM logs)";
                dcmd.Connection = Connection.con;
                dcmd.ExecuteNonQuery();
            }
            catch
            {

            }
                                           
        }
      

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }
        string t = "Barangay Clearance";
        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            Connection con = new Connection();
            con.Connect();
            try
            {                             
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO LOGS (DOCUMENT_TYPE,RESIDENT_NAME,TRANSACTION_DATE,RESIDENT_ID,STAFF_NAME,STAFF_ID,DOCUMENT_PRICE)" +
                    "VALUES(@type,@name,@det,@rid,@snm,@sid,@prc)";
                cmd.Connection = Connection.con;
                cmd.Parameters.AddWithValue("@type", t);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@det", DateTime.Now.ToString("MMMM dd yyyy"));
                cmd.Parameters.AddWithValue("@sid", ID);
                cmd.Parameters.AddWithValue("@rid", RID);                                            
                cmd.Parameters.AddWithValue("@prc", Price);
                cmd.Parameters.AddWithValue("@snm", textBox1.Text);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Print Failed");
            }               
                
           
        }
    }
}

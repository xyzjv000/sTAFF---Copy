using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace iliekbarangay.Documents
{
    public partial class BusinessPermit : Form
    {
        public BusinessPermit()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            date.Text = "Issued this " + DateTime.Now.ToString("MMMM dd yyyy") + " Cebu";
        }

        public String names
        {
            get { return name.Text; }
            set { name.Text = value; }
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
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                base.OnPaint(e);
            }

        }

        public void Print(Panel pnl)
        {
            Clearance = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.Clearance.Width / 2), this.Clearance.Location.Y);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Short", 612, 792);
            if (bn.Text != "BUSINESS NAME")
            {
                if ( address.Text != "BUSINESS CURRENT ADDRESS")
                {
                    if (bf.Text != "BUSINESS FOCUS")
                    {
                        Print(this.Clearance);
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
                    else
                    {
                        MessageBox.Show("Provide Business Purpose");
                        bf.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Provide Business Address");
                    address.Focus();
                }
            }
            else
            {
                MessageBox.Show("Provide Business Name!");
                bn.Focus();
            }
        }

        private void BusinessPermit_Load(object sender, EventArgs e)
        {
            bunifuFlatButton1.Focus();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string t = "Business Permit";

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

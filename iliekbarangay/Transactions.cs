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
    public partial class Transactions : UserControl
    {   private static Transactions _instance;
        public static Transactions Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Transactions();
                return _instance;
            }
        }
        Connection con = new Connection();


        public Transactions()
        {
            InitializeComponent();
            
            con.Connect();
            SqlDataAdapter fa = new SqlDataAdapter("select TRANSACTION_ID,RESIDENT_NAME,DOCUMENT_TYPE,TRANSACTION_DATE,STAFF_NAME,STAFF_ID,RESIDENT_ID,DOCUMENT_PRICE FROM LOGS", Connection.con);
            SqlCommandBuilder cf = new SqlCommandBuilder(fa);
            DataTable dx = new DataTable();
            fa.Fill(dx);
            TransactionData.DataSource = dx;
            TransactionData.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        }

        string ids;
        public String IDA
        {
            get { return ids; }
            set { ids = value; }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            tab_document tr = new tab_document();
            this.Controls.Add(tr);
            //tr.AdminPriv();
            tr.ID = this.IDA;
            tr.Dock = DockStyle.Fill;
            tr.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void trnsctionPnl_Paint(object sender, PaintEventArgs e)
        {

        }

     
       
    }
}

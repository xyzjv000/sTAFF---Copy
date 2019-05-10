using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace iliekbarangay
{
    class PrinterSelectionDialog
    {  /*
        ComboBox combo;

        public PrinterSelectionDialog()
        {
            Label label = new Label();
            label.Parent = this;
            label.Text = "Printer:";
            label.Location = new Point(8, 8);
            label.Size = new Size(40, 8);

            combo = new ComboBox();
            combo.Parent = this;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.Location = new Point(48, 8);
            combo.Size = new Size(144, 8);

            foreach (string str in PrinterSettings.InstalledPrinters)
                combo.Items.Add(str);

            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "OK";
            btn.Location = new Point(40, 32);
            btn.Size = new Size(40, 16);
            btn.DialogResult = DialogResult.OK;
            AcceptButton = btn;

            btn = new Button();
            btn.Parent = this;
            btn.Text = "Cancel";
            btn.Location = new Point(120, 32);
            btn.Size = new Size(40, 16);
            btn.DialogResult = DialogResult.Cancel;

            CancelButton = btn;

            ClientSize = new Size(200, 56);
            AutoScaleBaseSize = new Size(4, 8);
        }
        public string PrinterName
        {
            set { combo.SelectedItem = value; }
            get { return (string)combo.SelectedItem; }
        }
    }


    class PrintWithMargins : Form
    {
        public static void Main()
        {
            Application.Run(new PrintWithMargins());
        }
        public PrintWithMargins()
        {
            Text = "Print with Margins";
            Menu = new MainMenu();
            Menu.MenuItems.Add("&File");
            Menu.MenuItems[0].MenuItems.Add("&Print...",
                                     new EventHandler(MenuFilePrintOnClick));
        }
        void MenuFilePrintOnClick(object obj, EventArgs ea)
        {
            PrintDocument prndoc = new PrintDocument();

            PrinterSelectionDialog dlg = new PrinterSelectionDialog();
            dlg.PrinterName = prndoc.PrinterSettings.PrinterName;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            prndoc.PrinterSettings.PrinterName = dlg.PrinterName;

            prndoc.DocumentName = Text;
            prndoc.PrintPage += new PrintPageEventHandler(OnPrintPage);
            prndoc.Print();
        }
        void OnPrintPage(object obj, PrintPageEventArgs ppea)
        {
            Graphics grfx = ppea.Graphics;
            RectangleF rectf = new RectangleF(
                 ppea.MarginBounds.Left -
                 (ppea.PageBounds.Width - grfx.VisibleClipBounds.Width) / 2,
                 ppea.MarginBounds.Top -
                 (ppea.PageBounds.Height - grfx.VisibleClipBounds.Height) / 2,
                 ppea.MarginBounds.Width,
                 ppea.MarginBounds.Height);

            grfx.DrawRectangle(Pens.Black, rectf.X, rectf.Y,
                                           rectf.Width, rectf.Height);

            grfx.DrawLine(Pens.Black, rectf.Left, rectf.Top,
                                      rectf.Right, rectf.Bottom);

            grfx.DrawLine(Pens.Black, rectf.Right, rectf.Top,
                                      rectf.Left, rectf.Bottom);
        }            */
    } 
}

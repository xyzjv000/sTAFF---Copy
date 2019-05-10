namespace iliekbarangay
{
    partial class StaffMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMain));
            this.staffBody = new System.Windows.Forms.Panel();
            this.PanelBody = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.globalLabel = new System.Windows.Forms.Label();
            this.minBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.transactions = new Bunifu.Framework.UI.BunifuFlatButton();
            this.residents = new Bunifu.Framework.UI.BunifuFlatButton();
            this.programs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.announcements = new Bunifu.Framework.UI.BunifuFlatButton();
            this.profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.staffBody.SuspendLayout();
            this.header.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffBody
            // 
            this.staffBody.Controls.Add(this.PanelBody);
            this.staffBody.Controls.Add(this.header);
            this.staffBody.Controls.Add(this.leftPanel);
            this.staffBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffBody.Location = new System.Drawing.Point(0, 0);
            this.staffBody.Name = "staffBody";
            this.staffBody.Size = new System.Drawing.Size(974, 566);
            this.staffBody.TabIndex = 0;
            // 
            // PanelBody
            // 
            this.PanelBody.AutoScroll = true;
            this.PanelBody.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(292, 65);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(682, 501);
            this.PanelBody.TabIndex = 3;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.id);
            this.header.Controls.Add(this.uname);
            this.header.Controls.Add(this.panel1);
            this.header.Controls.Add(this.globalLabel);
            this.header.Controls.Add(this.minBtn);
            this.header.Controls.Add(this.clsBtn);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(292, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(682, 65);
            this.header.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Staff";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(198, 38);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 13);
            this.id.TabIndex = 0;
            this.id.Visible = false;
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(478, 16);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(0, 19);
            this.uname.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 55);
            this.panel1.TabIndex = 5;
            // 
            // globalLabel
            // 
            this.globalLabel.AutoSize = true;
            this.globalLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.globalLabel.Location = new System.Drawing.Point(50, 27);
            this.globalLabel.Name = "globalLabel";
            this.globalLabel.Size = new System.Drawing.Size(123, 24);
            this.globalLabel.TabIndex = 4;
            this.globalLabel.Text = "Dashboard";
            // 
            // minBtn
            // 
            this.minBtn.Activecolor = System.Drawing.Color.Transparent;
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minBtn.BackgroundImage")));
            this.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minBtn.BorderRadius = 0;
            this.minBtn.ButtonText = "";
            this.minBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minBtn.DisabledColor = System.Drawing.Color.Gray;
            this.minBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.minBtn.Iconimage = null;
            this.minBtn.Iconimage_right = null;
            this.minBtn.Iconimage_right_Selected = null;
            this.minBtn.Iconimage_Selected = null;
            this.minBtn.IconMarginLeft = 0;
            this.minBtn.IconMarginRight = 0;
            this.minBtn.IconRightVisible = true;
            this.minBtn.IconRightZoom = 0D;
            this.minBtn.IconVisible = true;
            this.minBtn.IconZoom = 90D;
            this.minBtn.IsTab = false;
            this.minBtn.Location = new System.Drawing.Point(597, 4);
            this.minBtn.Name = "minBtn";
            this.minBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.minBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.minBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.minBtn.selected = false;
            this.minBtn.Size = new System.Drawing.Size(38, 28);
            this.minBtn.TabIndex = 3;
            this.minBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minBtn.Textcolor = System.Drawing.Color.White;
            this.minBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // clsBtn
            // 
            this.clsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.clsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.clsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clsBtn.BackgroundImage")));
            this.clsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clsBtn.BorderRadius = 0;
            this.clsBtn.ButtonText = "";
            this.clsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.clsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.clsBtn.Iconimage = null;
            this.clsBtn.Iconimage_right = null;
            this.clsBtn.Iconimage_right_Selected = null;
            this.clsBtn.Iconimage_Selected = null;
            this.clsBtn.IconMarginLeft = 0;
            this.clsBtn.IconMarginRight = 0;
            this.clsBtn.IconRightVisible = true;
            this.clsBtn.IconRightZoom = 0D;
            this.clsBtn.IconVisible = true;
            this.clsBtn.IconZoom = 90D;
            this.clsBtn.IsTab = false;
            this.clsBtn.Location = new System.Drawing.Point(640, 4);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.clsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.clsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clsBtn.selected = false;
            this.clsBtn.Size = new System.Drawing.Size(38, 28);
            this.clsBtn.TabIndex = 2;
            this.clsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clsBtn.Textcolor = System.Drawing.Color.White;
            this.clsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.logout);
            this.leftPanel.Controls.Add(this.transactions);
            this.leftPanel.Controls.Add(this.residents);
            this.leftPanel.Controls.Add(this.programs);
            this.leftPanel.Controls.Add(this.announcements);
            this.leftPanel.Controls.Add(this.profile);
            this.leftPanel.Controls.Add(this.dashboard);
            this.leftPanel.Controls.Add(this.panel2);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(292, 566);
            this.leftPanel.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.BorderRadius = 0;
            this.logout.ButtonText = "     Logout";
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.DisabledColor = System.Drawing.Color.Gray;
            this.logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Iconcolor = System.Drawing.Color.Transparent;
            this.logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("logout.Iconimage")));
            this.logout.Iconimage_right = null;
            this.logout.Iconimage_right_Selected = null;
            this.logout.Iconimage_Selected = null;
            this.logout.IconMarginLeft = 0;
            this.logout.IconMarginRight = 0;
            this.logout.IconRightVisible = true;
            this.logout.IconRightZoom = 0D;
            this.logout.IconVisible = true;
            this.logout.IconZoom = 60D;
            this.logout.IsTab = false;
            this.logout.Location = new System.Drawing.Point(0, 371);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout.Name = "logout";
            this.logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.logout.OnHoverTextColor = System.Drawing.Color.White;
            this.logout.selected = false;
            this.logout.Size = new System.Drawing.Size(290, 51);
            this.logout.TabIndex = 10;
            this.logout.Text = "     Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Textcolor = System.Drawing.Color.White;
            this.logout.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Click += new System.EventHandler(this.staffs_Click);
            // 
            // transactions
            // 
            this.transactions.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.transactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transactions.BorderRadius = 0;
            this.transactions.ButtonText = "     Documents";
            this.transactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactions.DisabledColor = System.Drawing.Color.Gray;
            this.transactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactions.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactions.Iconcolor = System.Drawing.Color.Transparent;
            this.transactions.Iconimage = ((System.Drawing.Image)(resources.GetObject("transactions.Iconimage")));
            this.transactions.Iconimage_right = null;
            this.transactions.Iconimage_right_Selected = null;
            this.transactions.Iconimage_Selected = null;
            this.transactions.IconMarginLeft = 0;
            this.transactions.IconMarginRight = 0;
            this.transactions.IconRightVisible = true;
            this.transactions.IconRightZoom = 0D;
            this.transactions.IconVisible = true;
            this.transactions.IconZoom = 60D;
            this.transactions.IsTab = false;
            this.transactions.Location = new System.Drawing.Point(0, 320);
            this.transactions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transactions.Name = "transactions";
            this.transactions.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.transactions.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.transactions.OnHoverTextColor = System.Drawing.Color.White;
            this.transactions.selected = false;
            this.transactions.Size = new System.Drawing.Size(290, 51);
            this.transactions.TabIndex = 9;
            this.transactions.Text = "     Documents";
            this.transactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactions.Textcolor = System.Drawing.Color.White;
            this.transactions.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactions.Click += new System.EventHandler(this.transactions_Click);
            // 
            // residents
            // 
            this.residents.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.residents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.residents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.residents.BorderRadius = 0;
            this.residents.ButtonText = "     Residents";
            this.residents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.residents.DisabledColor = System.Drawing.Color.Gray;
            this.residents.Dock = System.Windows.Forms.DockStyle.Top;
            this.residents.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residents.Iconcolor = System.Drawing.Color.Transparent;
            this.residents.Iconimage = ((System.Drawing.Image)(resources.GetObject("residents.Iconimage")));
            this.residents.Iconimage_right = null;
            this.residents.Iconimage_right_Selected = null;
            this.residents.Iconimage_Selected = null;
            this.residents.IconMarginLeft = 0;
            this.residents.IconMarginRight = 0;
            this.residents.IconRightVisible = true;
            this.residents.IconRightZoom = 0D;
            this.residents.IconVisible = true;
            this.residents.IconZoom = 60D;
            this.residents.IsTab = false;
            this.residents.Location = new System.Drawing.Point(0, 269);
            this.residents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.residents.Name = "residents";
            this.residents.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.residents.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.residents.OnHoverTextColor = System.Drawing.Color.White;
            this.residents.selected = false;
            this.residents.Size = new System.Drawing.Size(290, 51);
            this.residents.TabIndex = 7;
            this.residents.Text = "     Residents";
            this.residents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.residents.Textcolor = System.Drawing.Color.White;
            this.residents.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residents.Click += new System.EventHandler(this.residents_Click);
            // 
            // programs
            // 
            this.programs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.programs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.programs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.programs.BorderRadius = 0;
            this.programs.ButtonText = "     Programs";
            this.programs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.programs.DisabledColor = System.Drawing.Color.Gray;
            this.programs.Dock = System.Windows.Forms.DockStyle.Top;
            this.programs.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programs.Iconcolor = System.Drawing.Color.Transparent;
            this.programs.Iconimage = ((System.Drawing.Image)(resources.GetObject("programs.Iconimage")));
            this.programs.Iconimage_right = null;
            this.programs.Iconimage_right_Selected = null;
            this.programs.Iconimage_Selected = null;
            this.programs.IconMarginLeft = 0;
            this.programs.IconMarginRight = 0;
            this.programs.IconRightVisible = true;
            this.programs.IconRightZoom = 0D;
            this.programs.IconVisible = true;
            this.programs.IconZoom = 60D;
            this.programs.IsTab = false;
            this.programs.Location = new System.Drawing.Point(0, 218);
            this.programs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.programs.Name = "programs";
            this.programs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.programs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.programs.OnHoverTextColor = System.Drawing.Color.White;
            this.programs.selected = false;
            this.programs.Size = new System.Drawing.Size(290, 51);
            this.programs.TabIndex = 6;
            this.programs.Text = "     Programs";
            this.programs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programs.Textcolor = System.Drawing.Color.White;
            this.programs.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programs.Click += new System.EventHandler(this.programs_Click);
            // 
            // announcements
            // 
            this.announcements.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.announcements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.announcements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.announcements.BorderRadius = 0;
            this.announcements.ButtonText = "     Announcements";
            this.announcements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.announcements.DisabledColor = System.Drawing.Color.White;
            this.announcements.Dock = System.Windows.Forms.DockStyle.Top;
            this.announcements.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcements.Iconcolor = System.Drawing.Color.Transparent;
            this.announcements.Iconimage = ((System.Drawing.Image)(resources.GetObject("announcements.Iconimage")));
            this.announcements.Iconimage_right = null;
            this.announcements.Iconimage_right_Selected = null;
            this.announcements.Iconimage_Selected = null;
            this.announcements.IconMarginLeft = 0;
            this.announcements.IconMarginRight = 0;
            this.announcements.IconRightVisible = true;
            this.announcements.IconRightZoom = 0D;
            this.announcements.IconVisible = true;
            this.announcements.IconZoom = 60D;
            this.announcements.IsTab = false;
            this.announcements.Location = new System.Drawing.Point(0, 167);
            this.announcements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.announcements.Name = "announcements";
            this.announcements.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.announcements.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.announcements.OnHoverTextColor = System.Drawing.Color.White;
            this.announcements.selected = false;
            this.announcements.Size = new System.Drawing.Size(290, 51);
            this.announcements.TabIndex = 5;
            this.announcements.Text = "     Announcements";
            this.announcements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.announcements.Textcolor = System.Drawing.Color.White;
            this.announcements.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcements.Click += new System.EventHandler(this.announcements_Click);
            // 
            // profile
            // 
            this.profile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile.BorderRadius = 0;
            this.profile.ButtonText = "     Profile";
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.DisabledColor = System.Drawing.Color.Gray;
            this.profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.Iconcolor = System.Drawing.Color.Transparent;
            this.profile.Iconimage = ((System.Drawing.Image)(resources.GetObject("profile.Iconimage")));
            this.profile.Iconimage_right = null;
            this.profile.Iconimage_right_Selected = null;
            this.profile.Iconimage_Selected = null;
            this.profile.IconMarginLeft = 0;
            this.profile.IconMarginRight = 0;
            this.profile.IconRightVisible = true;
            this.profile.IconRightZoom = 0D;
            this.profile.IconVisible = true;
            this.profile.IconZoom = 60D;
            this.profile.IsTab = false;
            this.profile.Location = new System.Drawing.Point(0, 116);
            this.profile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profile.Name = "profile";
            this.profile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.profile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.profile.OnHoverTextColor = System.Drawing.Color.White;
            this.profile.selected = false;
            this.profile.Size = new System.Drawing.Size(290, 51);
            this.profile.TabIndex = 4;
            this.profile.Text = "     Profile";
            this.profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile.Textcolor = System.Drawing.Color.White;
            this.profile.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // dashboard
            // 
            this.dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.dashboard.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard.BorderRadius = 0;
            this.dashboard.ButtonText = "     Dashboard";
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboard.Iconimage")));
            this.dashboard.Iconimage_right = null;
            this.dashboard.Iconimage_right_Selected = null;
            this.dashboard.Iconimage_Selected = null;
            this.dashboard.IconMarginLeft = 0;
            this.dashboard.IconMarginRight = 0;
            this.dashboard.IconRightVisible = true;
            this.dashboard.IconRightZoom = 0D;
            this.dashboard.IconVisible = true;
            this.dashboard.IconZoom = 60D;
            this.dashboard.IsTab = false;
            this.dashboard.Location = new System.Drawing.Point(0, 65);
            this.dashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboard.Name = "dashboard";
            this.dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboard.selected = false;
            this.dashboard.Size = new System.Drawing.Size(290, 51);
            this.dashboard.TabIndex = 3;
            this.dashboard.Text = "     Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Textcolor = System.Drawing.Color.White;
            this.dashboard.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Load += new System.EventHandler(this.dashboard_Load);
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 65);
            this.panel2.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // StaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 566);
            this.Controls.Add(this.staffBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(974, 566);
            this.MinimumSize = new System.Drawing.Size(974, 566);
            this.Name = "StaffMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffMain";
            this.Load += new System.EventHandler(this.StaffMain_Load);
            this.staffBody.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel staffBody;
        private System.Windows.Forms.Panel leftPanel;
        private Bunifu.Framework.UI.BunifuFlatButton transactions;
        private Bunifu.Framework.UI.BunifuFlatButton residents;
        private Bunifu.Framework.UI.BunifuFlatButton programs;
        private Bunifu.Framework.UI.BunifuFlatButton profile;
        private Bunifu.Framework.UI.BunifuFlatButton dashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label globalLabel;
        private Bunifu.Framework.UI.BunifuFlatButton minBtn;
        private Bunifu.Framework.UI.BunifuFlatButton clsBtn;
        public System.Windows.Forms.Panel PanelBody;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuFlatButton announcements;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
namespace iliekbarangay
{
    partial class tab_announcements
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tab_announcements));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTaken = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.annDate = new MetroFramework.Controls.MetroDateTime();
            this.postBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.annContent = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.annTitle = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.create = new Bunifu.Framework.UI.BunifuFlatButton();
            this.save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.delBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.editBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ANNOUNCEMENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANNOUNCEMENT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANNOUNCEMENT_CONTENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANNOUNCEMENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANNOUNCEMENT_POSTEDON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.announcementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.dateTaken);
            this.contentPanel.Controls.Add(this.annDate);
            this.contentPanel.Controls.Add(this.postBtn);
            this.contentPanel.Controls.Add(this.annContent);
            this.contentPanel.Controls.Add(this.annTitle);
            this.contentPanel.Controls.Add(this.create);
            this.contentPanel.Controls.Add(this.save);
            this.contentPanel.Location = new System.Drawing.Point(16, 21);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(647, 243);
            this.contentPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date Posted";
            this.label1.Visible = false;
            // 
            // dateTaken
            // 
            this.dateTaken.BorderColor = System.Drawing.Color.SeaGreen;
            this.dateTaken.Enabled = false;
            this.dateTaken.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTaken.ForeColor = System.Drawing.Color.Gray;
            this.dateTaken.Location = new System.Drawing.Point(20, 214);
            this.dateTaken.Multiline = true;
            this.dateTaken.Name = "dateTaken";
            this.dateTaken.Size = new System.Drawing.Size(224, 22);
            this.dateTaken.TabIndex = 7;
            this.dateTaken.Visible = false;
            this.dateTaken.TextChanged += new System.EventHandler(this.dateTaken_TextChanged);
            // 
            // annDate
            // 
            this.annDate.Location = new System.Drawing.Point(338, 16);
            this.annDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.annDate.Name = "annDate";
            this.annDate.Size = new System.Drawing.Size(287, 29);
            this.annDate.TabIndex = 4;
            // 
            // postBtn
            // 
            this.postBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.postBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.postBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.postBtn.BorderRadius = 5;
            this.postBtn.ButtonText = "    Post";
            this.postBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postBtn.DisabledColor = System.Drawing.Color.Gray;
            this.postBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.postBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("postBtn.Iconimage")));
            this.postBtn.Iconimage_right = null;
            this.postBtn.Iconimage_right_Selected = null;
            this.postBtn.Iconimage_Selected = null;
            this.postBtn.IconMarginLeft = 0;
            this.postBtn.IconMarginRight = 0;
            this.postBtn.IconRightVisible = true;
            this.postBtn.IconRightZoom = 0D;
            this.postBtn.IconVisible = true;
            this.postBtn.IconZoom = 50D;
            this.postBtn.IsTab = false;
            this.postBtn.Location = new System.Drawing.Point(522, 198);
            this.postBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postBtn.Name = "postBtn";
            this.postBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.postBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(227)))));
            this.postBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.postBtn.selected = false;
            this.postBtn.Size = new System.Drawing.Size(103, 35);
            this.postBtn.TabIndex = 3;
            this.postBtn.Text = "    Post";
            this.postBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postBtn.Textcolor = System.Drawing.Color.White;
            this.postBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // annContent
            // 
            this.annContent.BorderColor = System.Drawing.Color.SeaGreen;
            this.annContent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annContent.ForeColor = System.Drawing.Color.Gray;
            this.annContent.Location = new System.Drawing.Point(20, 57);
            this.annContent.Multiline = true;
            this.annContent.Name = "annContent";
            this.annContent.Size = new System.Drawing.Size(605, 136);
            this.annContent.TabIndex = 2;
            this.annContent.Text = "Content";
            this.annContent.Enter += new System.EventHandler(this.content_Enter);
            this.annContent.Leave += new System.EventHandler(this.content_Leave);
            // 
            // annTitle
            // 
            this.annTitle.BorderColor = System.Drawing.Color.SeaGreen;
            this.annTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annTitle.ForeColor = System.Drawing.Color.Gray;
            this.annTitle.Location = new System.Drawing.Point(20, 14);
            this.annTitle.Multiline = true;
            this.annTitle.Name = "annTitle";
            this.annTitle.Size = new System.Drawing.Size(284, 31);
            this.annTitle.TabIndex = 1;
            this.annTitle.Text = "Title";
            this.annTitle.TextChanged += new System.EventHandler(this.title_TextChanged);
            this.annTitle.Enter += new System.EventHandler(this.title_Enter);
            this.annTitle.Leave += new System.EventHandler(this.title_Leave);
            // 
            // create
            // 
            this.create.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.create.BorderRadius = 5;
            this.create.ButtonText = "    Create";
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.DisabledColor = System.Drawing.Color.Gray;
            this.create.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Iconcolor = System.Drawing.Color.Transparent;
            this.create.Iconimage = ((System.Drawing.Image)(resources.GetObject("create.Iconimage")));
            this.create.Iconimage_right = null;
            this.create.Iconimage_right_Selected = null;
            this.create.Iconimage_Selected = null;
            this.create.IconMarginLeft = 0;
            this.create.IconMarginRight = 0;
            this.create.IconRightVisible = true;
            this.create.IconRightZoom = 0D;
            this.create.IconVisible = true;
            this.create.IconZoom = 50D;
            this.create.IsTab = false;
            this.create.Location = new System.Drawing.Point(522, 198);
            this.create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create.Name = "create";
            this.create.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.create.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(227)))));
            this.create.OnHoverTextColor = System.Drawing.Color.White;
            this.create.selected = false;
            this.create.Size = new System.Drawing.Size(103, 35);
            this.create.TabIndex = 5;
            this.create.Text = "    Create";
            this.create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.Textcolor = System.Drawing.Color.White;
            this.create.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Visible = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // save
            // 
            this.save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.BorderRadius = 5;
            this.save.ButtonText = "    Save";
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.DisabledColor = System.Drawing.Color.Gray;
            this.save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Iconcolor = System.Drawing.Color.Transparent;
            this.save.Iconimage = ((System.Drawing.Image)(resources.GetObject("save.Iconimage")));
            this.save.Iconimage_right = null;
            this.save.Iconimage_right_Selected = null;
            this.save.Iconimage_Selected = null;
            this.save.IconMarginLeft = 0;
            this.save.IconMarginRight = 0;
            this.save.IconRightVisible = true;
            this.save.IconRightZoom = 0D;
            this.save.IconVisible = true;
            this.save.IconZoom = 50D;
            this.save.IsTab = false;
            this.save.Location = new System.Drawing.Point(522, 198);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(227)))));
            this.save.OnHoverTextColor = System.Drawing.Color.White;
            this.save.selected = false;
            this.save.Size = new System.Drawing.Size(103, 35);
            this.save.TabIndex = 6;
            this.save.Text = "    Save";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Textcolor = System.Drawing.Color.White;
            this.save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.contentPanel;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 275);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Size = new System.Drawing.Size(647, 212);
            this.panel1.TabIndex = 1;
            // 
            // delBtn
            // 
            this.delBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.delBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtn.BorderRadius = 5;
            this.delBtn.ButtonText = " Delete";
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.DisabledColor = System.Drawing.Color.Gray;
            this.delBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.delBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("delBtn.Iconimage")));
            this.delBtn.Iconimage_right = null;
            this.delBtn.Iconimage_right_Selected = null;
            this.delBtn.Iconimage_Selected = null;
            this.delBtn.IconMarginLeft = 0;
            this.delBtn.IconMarginRight = 0;
            this.delBtn.IconRightVisible = true;
            this.delBtn.IconRightZoom = 0D;
            this.delBtn.IconVisible = true;
            this.delBtn.IconZoom = 50D;
            this.delBtn.IsTab = false;
            this.delBtn.Location = new System.Drawing.Point(521, 53);
            this.delBtn.Name = "delBtn";
            this.delBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.delBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.delBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.delBtn.selected = false;
            this.delBtn.Size = new System.Drawing.Size(103, 35);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = " Delete";
            this.delBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delBtn.Textcolor = System.Drawing.Color.White;
            this.delBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.BorderRadius = 5;
            this.editBtn.ButtonText = "    Edit";
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.DisabledColor = System.Drawing.Color.Gray;
            this.editBtn.Enabled = false;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.editBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("editBtn.Iconimage")));
            this.editBtn.Iconimage_right = null;
            this.editBtn.Iconimage_right_Selected = null;
            this.editBtn.Iconimage_Selected = null;
            this.editBtn.IconMarginLeft = 0;
            this.editBtn.IconMarginRight = 0;
            this.editBtn.IconRightVisible = true;
            this.editBtn.IconRightZoom = 0D;
            this.editBtn.IconVisible = true;
            this.editBtn.IconZoom = 50D;
            this.editBtn.IsTab = false;
            this.editBtn.Location = new System.Drawing.Point(521, 11);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.editBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.editBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.editBtn.selected = false;
            this.editBtn.Size = new System.Drawing.Size(103, 35);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "    Edit";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Textcolor = System.Drawing.Color.White;
            this.editBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.data);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(8, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 190);
            this.panel2.TabIndex = 0;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data.ColumnHeadersHeight = 40;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ANNOUNCEMENT_NAME,
            this.ANNOUNCEMENT_DATE,
            this.ANNOUNCEMENT_CONTENT,
            this.ANNOUNCEMENT_ID,
            this.ANNOUNCEMENT_POSTEDON});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle3;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.DoubleBuffered = true;
            this.data.EnableHeadersVisualStyles = false;
            this.data.GridColor = System.Drawing.Color.White;
            this.data.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.data.HeaderForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.data.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.data.RowTemplate.Height = 30;
            this.data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(505, 188);
            this.data.TabIndex = 0;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // ANNOUNCEMENT_NAME
            // 
            this.ANNOUNCEMENT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANNOUNCEMENT_NAME.DataPropertyName = "ANNOUNCEMENT_NAME";
            this.ANNOUNCEMENT_NAME.HeaderText = "Title";
            this.ANNOUNCEMENT_NAME.Name = "ANNOUNCEMENT_NAME";
            this.ANNOUNCEMENT_NAME.ReadOnly = true;
            // 
            // ANNOUNCEMENT_DATE
            // 
            this.ANNOUNCEMENT_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANNOUNCEMENT_DATE.DataPropertyName = "ANNOUNCEMENT_DATE";
            this.ANNOUNCEMENT_DATE.HeaderText = "Date";
            this.ANNOUNCEMENT_DATE.Name = "ANNOUNCEMENT_DATE";
            this.ANNOUNCEMENT_DATE.ReadOnly = true;
            // 
            // ANNOUNCEMENT_CONTENT
            // 
            this.ANNOUNCEMENT_CONTENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ANNOUNCEMENT_CONTENT.DataPropertyName = "ANNOUNCEMENT_CONTENT";
            this.ANNOUNCEMENT_CONTENT.HeaderText = "Content";
            this.ANNOUNCEMENT_CONTENT.Name = "ANNOUNCEMENT_CONTENT";
            this.ANNOUNCEMENT_CONTENT.ReadOnly = true;
            this.ANNOUNCEMENT_CONTENT.Visible = false;
            // 
            // ANNOUNCEMENT_ID
            // 
            this.ANNOUNCEMENT_ID.DataPropertyName = "ANNOUNCEMENT_ID";
            this.ANNOUNCEMENT_ID.HeaderText = "ID";
            this.ANNOUNCEMENT_ID.Name = "ANNOUNCEMENT_ID";
            this.ANNOUNCEMENT_ID.ReadOnly = true;
            this.ANNOUNCEMENT_ID.Visible = false;
            // 
            // ANNOUNCEMENT_POSTEDON
            // 
            this.ANNOUNCEMENT_POSTEDON.DataPropertyName = "ANNOUNCEMENT_POSTEDON";
            this.ANNOUNCEMENT_POSTEDON.HeaderText = "DATE POSTED";
            this.ANNOUNCEMENT_POSTEDON.Name = "ANNOUNCEMENT_POSTEDON";
            this.ANNOUNCEMENT_POSTEDON.ReadOnly = true;
            this.ANNOUNCEMENT_POSTEDON.Visible = false;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.panel1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 481);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tab_announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(682, 501);
            this.Name = "tab_announcements";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Size = new System.Drawing.Size(682, 501);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tab_announcements_ControlRemoved);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentPanel;
        private Bunifu.Framework.UI.BunifuFlatButton postBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox annContent;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox annTitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton delBtn;
        private Bunifu.Framework.UI.BunifuFlatButton editBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private MetroFramework.Controls.MetroDateTime annDate;
        //private ilikebarangayDataSet1TableAdapters.announcementTableAdapter announcementTableAdapter;
        private System.Windows.Forms.BindingSource announcementBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton create;
        private Bunifu.Framework.UI.BunifuFlatButton save;
        private Bunifu.Framework.UI.BunifuCustomDataGrid data;
        private System.Windows.Forms.Panel panel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox dateTaken;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANNOUNCEMENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANNOUNCEMENT_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANNOUNCEMENT_CONTENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANNOUNCEMENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANNOUNCEMENT_POSTEDON;
    }
}

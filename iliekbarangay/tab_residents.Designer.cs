namespace iliekbarangay
{
    partial class tab_residents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tab_residents));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bckground = new System.Windows.Forms.Panel();
            this.addResidentBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.identification = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.residentData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.II = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Civil_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.familyData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.FAMILY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Household_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Registered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addFamily = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bckground.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentData)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familyData)).BeginInit();
            this.SuspendLayout();
            // 
            // bckground
            // 
            this.bckground.BackColor = System.Drawing.Color.Gainsboro;
            this.bckground.Controls.Add(this.addResidentBtn);
            this.bckground.Controls.Add(this.identification);
            this.bckground.Controls.Add(this.metroTabControl1);
            this.bckground.Controls.Add(this.addFamily);
            this.bckground.Controls.Add(this.searchBox);
            this.bckground.Controls.Add(this.searchBtn);
            this.bckground.Location = new System.Drawing.Point(0, 0);
            this.bckground.Name = "bckground";
            this.bckground.Size = new System.Drawing.Size(682, 501);
            this.bckground.TabIndex = 0;
            // 
            // addResidentBtn
            // 
            this.addResidentBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addResidentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addResidentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addResidentBtn.BorderRadius = 5;
            this.addResidentBtn.ButtonText = "  Add Family Member";
            this.addResidentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addResidentBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addResidentBtn.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResidentBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addResidentBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addResidentBtn.Iconimage")));
            this.addResidentBtn.Iconimage_right = null;
            this.addResidentBtn.Iconimage_right_Selected = null;
            this.addResidentBtn.Iconimage_Selected = null;
            this.addResidentBtn.IconMarginLeft = 0;
            this.addResidentBtn.IconMarginRight = 0;
            this.addResidentBtn.IconRightVisible = true;
            this.addResidentBtn.IconRightZoom = 0D;
            this.addResidentBtn.IconVisible = true;
            this.addResidentBtn.IconZoom = 50D;
            this.addResidentBtn.IsTab = false;
            this.addResidentBtn.Location = new System.Drawing.Point(175, 26);
            this.addResidentBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addResidentBtn.Name = "addResidentBtn";
            this.addResidentBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addResidentBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.addResidentBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addResidentBtn.selected = false;
            this.addResidentBtn.Size = new System.Drawing.Size(169, 34);
            this.addResidentBtn.TabIndex = 8;
            this.addResidentBtn.Text = "  Add Family Member";
            this.addResidentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addResidentBtn.Textcolor = System.Drawing.Color.White;
            this.addResidentBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResidentBtn.Visible = false;
            this.addResidentBtn.Click += new System.EventHandler(this.addResidentBtn_Click);
            // 
            // identification
            // 
            this.identification.AutoSize = true;
            this.identification.Location = new System.Drawing.Point(15, 13);
            this.identification.Name = "identification";
            this.identification.Size = new System.Drawing.Size(13, 13);
            this.identification.TabIndex = 7;
            this.identification.Text = "a";
            this.identification.Visible = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(18, 66);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(643, 408);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.residentData);
            this.metroTabPage1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(635, 366);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "                                 Residents                                 ";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // residentData
            // 
            this.residentData.AllowUserToAddRows = false;
            this.residentData.AllowUserToDeleteRows = false;
            this.residentData.AllowUserToResizeColumns = false;
            this.residentData.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.residentData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.residentData.BackgroundColor = System.Drawing.Color.White;
            this.residentData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.residentData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.residentData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.residentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.residentData.ColumnHeadersHeight = 55;
            this.residentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.residentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.II,
            this.NAME,
            this.Age,
            this.Civil_Status,
            this.Gender});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.residentData.DefaultCellStyle = dataGridViewCellStyle7;
            this.residentData.DoubleBuffered = true;
            this.residentData.EnableHeadersVisualStyles = false;
            this.residentData.GridColor = System.Drawing.Color.White;
            this.residentData.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.residentData.HeaderForeColor = System.Drawing.Color.White;
            this.residentData.Location = new System.Drawing.Point(3, 3);
            this.residentData.MultiSelect = false;
            this.residentData.Name = "residentData";
            this.residentData.ReadOnly = true;
            this.residentData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.residentData.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.residentData.RowHeadersVisible = false;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.residentData.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.residentData.RowTemplate.Height = 45;
            this.residentData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.residentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.residentData.Size = new System.Drawing.Size(629, 323);
            this.residentData.TabIndex = 0;
            this.residentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.residentData_CellClick);
            this.residentData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.residentData_CellDoubleClick);
            // 
            // II
            // 
            this.II.DataPropertyName = "II";
            this.II.HeaderText = "ID";
            this.II.Name = "II";
            this.II.ReadOnly = true;
            this.II.Visible = false;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Name";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Civil_Status
            // 
            this.Civil_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Civil_Status.DataPropertyName = "Civil_Status";
            this.Civil_Status.HeaderText = "Civil Status";
            this.Civil_Status.Name = "Civil_Status";
            this.Civil_Status.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.familyData);
            this.metroTabPage2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(635, 366);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "                                Family                                ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // familyData
            // 
            this.familyData.AllowUserToAddRows = false;
            this.familyData.AllowUserToDeleteRows = false;
            this.familyData.AllowUserToResizeColumns = false;
            this.familyData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.familyData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.familyData.BackgroundColor = System.Drawing.Color.White;
            this.familyData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.familyData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.familyData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.familyData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.familyData.ColumnHeadersHeight = 55;
            this.familyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.familyData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FAMILY_NAME,
            this.Address,
            this.Household_Num,
            this.Date_Registered,
            this.FAMILY_ID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.familyData.DefaultCellStyle = dataGridViewCellStyle3;
            this.familyData.DoubleBuffered = true;
            this.familyData.EnableHeadersVisualStyles = false;
            this.familyData.GridColor = System.Drawing.Color.White;
            this.familyData.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.familyData.HeaderForeColor = System.Drawing.Color.White;
            this.familyData.Location = new System.Drawing.Point(3, 3);
            this.familyData.MultiSelect = false;
            this.familyData.Name = "familyData";
            this.familyData.ReadOnly = true;
            this.familyData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.familyData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.familyData.RowHeadersVisible = false;
            this.familyData.RowTemplate.Height = 45;
            this.familyData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.familyData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.familyData.Size = new System.Drawing.Size(629, 320);
            this.familyData.TabIndex = 2;
            this.familyData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.familyData_CellClick);
            this.familyData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.familyData_CellDoubleClick);
            // 
            // FAMILY_NAME
            // 
            this.FAMILY_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FAMILY_NAME.DataPropertyName = "Family_Name";
            this.FAMILY_NAME.HeaderText = "Family Name";
            this.FAMILY_NAME.Name = "FAMILY_NAME";
            this.FAMILY_NAME.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Household_Num
            // 
            this.Household_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Household_Num.DataPropertyName = "Household_Num";
            this.Household_Num.HeaderText = "Household Number";
            this.Household_Num.Name = "Household_Num";
            this.Household_Num.ReadOnly = true;
            // 
            // Date_Registered
            // 
            this.Date_Registered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date_Registered.DataPropertyName = "Date_Registered";
            this.Date_Registered.HeaderText = "Date Registered";
            this.Date_Registered.Name = "Date_Registered";
            this.Date_Registered.ReadOnly = true;
            // 
            // FAMILY_ID
            // 
            this.FAMILY_ID.DataPropertyName = "FAMILY_ID";
            this.FAMILY_ID.HeaderText = "ID";
            this.FAMILY_ID.Name = "FAMILY_ID";
            this.FAMILY_ID.ReadOnly = true;
            this.FAMILY_ID.Visible = false;
            // 
            // addFamily
            // 
            this.addFamily.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addFamily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFamily.BorderRadius = 5;
            this.addFamily.ButtonText = "  Add Family";
            this.addFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFamily.DisabledColor = System.Drawing.Color.Gray;
            this.addFamily.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFamily.Iconcolor = System.Drawing.Color.Transparent;
            this.addFamily.Iconimage = ((System.Drawing.Image)(resources.GetObject("addFamily.Iconimage")));
            this.addFamily.Iconimage_right = null;
            this.addFamily.Iconimage_right_Selected = null;
            this.addFamily.Iconimage_Selected = null;
            this.addFamily.IconMarginLeft = 0;
            this.addFamily.IconMarginRight = 0;
            this.addFamily.IconRightVisible = true;
            this.addFamily.IconRightZoom = 0D;
            this.addFamily.IconVisible = true;
            this.addFamily.IconZoom = 50D;
            this.addFamily.IsTab = false;
            this.addFamily.Location = new System.Drawing.Point(18, 26);
            this.addFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addFamily.Name = "addFamily";
            this.addFamily.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addFamily.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.addFamily.OnHoverTextColor = System.Drawing.Color.White;
            this.addFamily.selected = false;
            this.addFamily.Size = new System.Drawing.Size(137, 34);
            this.addFamily.TabIndex = 5;
            this.addFamily.Text = "  Add Family";
            this.addFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addFamily.Textcolor = System.Drawing.Color.White;
            this.addFamily.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFamily.Click += new System.EventHandler(this.addFamily_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.searchBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.searchBox.BorderThickness = 1;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.isPassword = false;
            this.searchBox.Location = new System.Drawing.Point(376, 24);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(194, 29);
            this.searchBox.TabIndex = 4;
            this.searchBox.Text = "Search";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // searchBtn
            // 
            this.searchBtn.Activecolor = System.Drawing.Color.DarkGray;
            this.searchBtn.BackColor = System.Drawing.Color.DarkGray;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.BorderRadius = 5;
            this.searchBtn.ButtonText = "Search";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("searchBtn.Iconimage")));
            this.searchBtn.Iconimage_right = null;
            this.searchBtn.Iconimage_right_Selected = null;
            this.searchBtn.Iconimage_Selected = null;
            this.searchBtn.IconMarginLeft = 0;
            this.searchBtn.IconMarginRight = 0;
            this.searchBtn.IconRightVisible = true;
            this.searchBtn.IconRightZoom = 0D;
            this.searchBtn.IconVisible = true;
            this.searchBtn.IconZoom = 50D;
            this.searchBtn.IsTab = false;
            this.searchBtn.Location = new System.Drawing.Point(577, 24);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Normalcolor = System.Drawing.Color.DarkGray;
            this.searchBtn.OnHovercolor = System.Drawing.Color.Gray;
            this.searchBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBtn.selected = false;
            this.searchBtn.Size = new System.Drawing.Size(84, 30);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Textcolor = System.Drawing.Color.White;
            this.searchBtn.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.metroTabControl1;
            // 
            // tab_residents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bckground);
            this.Name = "tab_residents";
            this.Size = new System.Drawing.Size(682, 501);
            this.Load += new System.EventHandler(this.tab_residents_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tab_residents_ControlRemoved);
            this.bckground.ResumeLayout(false);
            this.bckground.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.residentData)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.familyData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bckground;
        private Bunifu.Framework.UI.BunifuFlatButton searchBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchBox;
       // private ilikebarangayDataSet ilikebarangayDataSet;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid familyData;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuFlatButton addFamily;
        private System.Windows.Forms.Label identification;
        public Bunifu.Framework.UI.BunifuCustomDataGrid residentData;
        private System.Windows.Forms.DataGridViewTextBoxColumn II;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Civil_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILY_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Household_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Registered;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILY_ID;
        public Bunifu.Framework.UI.BunifuFlatButton addResidentBtn;
    }
}

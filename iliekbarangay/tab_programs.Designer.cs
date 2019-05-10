namespace iliekbarangay
{
    partial class tab_programs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tab_programs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.verifyBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.removeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.programData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.verifyBtn);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 501);
            this.panel1.TabIndex = 0;
            this.panel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlRemoved);
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // verifyBtn
            // 
            this.verifyBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.verifyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verifyBtn.BorderRadius = 5;
            this.verifyBtn.ButtonText = "   Verify";
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.DisabledColor = System.Drawing.Color.Gray;
            this.verifyBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.verifyBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("verifyBtn.Iconimage")));
            this.verifyBtn.Iconimage_right = null;
            this.verifyBtn.Iconimage_right_Selected = null;
            this.verifyBtn.Iconimage_Selected = null;
            this.verifyBtn.IconMarginLeft = 0;
            this.verifyBtn.IconMarginRight = 0;
            this.verifyBtn.IconRightVisible = true;
            this.verifyBtn.IconRightZoom = 0D;
            this.verifyBtn.IconVisible = true;
            this.verifyBtn.IconZoom = 50D;
            this.verifyBtn.IsTab = false;
            this.verifyBtn.Location = new System.Drawing.Point(277, 41);
            this.verifyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.verifyBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.verifyBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.verifyBtn.selected = false;
            this.verifyBtn.Size = new System.Drawing.Size(106, 34);
            this.verifyBtn.TabIndex = 4;
            this.verifyBtn.Text = "   Verify";
            this.verifyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verifyBtn.Textcolor = System.Drawing.Color.White;
            this.verifyBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.Visible = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Activecolor = System.Drawing.Color.Maroon;
            this.removeBtn.BackColor = System.Drawing.Color.Maroon;
            this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeBtn.BorderRadius = 5;
            this.removeBtn.ButtonText = "   Remove";
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.removeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.removeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("removeBtn.Iconimage")));
            this.removeBtn.Iconimage_right = null;
            this.removeBtn.Iconimage_right_Selected = null;
            this.removeBtn.Iconimage_Selected = null;
            this.removeBtn.IconMarginLeft = 0;
            this.removeBtn.IconMarginRight = 0;
            this.removeBtn.IconRightVisible = true;
            this.removeBtn.IconRightZoom = 0D;
            this.removeBtn.IconVisible = true;
            this.removeBtn.IconZoom = 50D;
            this.removeBtn.IsTab = false;
            this.removeBtn.Location = new System.Drawing.Point(136, 41);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Normalcolor = System.Drawing.Color.Maroon;
            this.removeBtn.OnHovercolor = System.Drawing.Color.Firebrick;
            this.removeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.removeBtn.selected = false;
            this.removeBtn.Size = new System.Drawing.Size(106, 34);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "   Remove";
            this.removeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBtn.Textcolor = System.Drawing.Color.White;
            this.removeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.BorderRadius = 5;
            this.addBtn.ButtonText = "     Add";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addBtn.Iconimage")));
            this.addBtn.Iconimage_right = null;
            this.addBtn.Iconimage_right_Selected = null;
            this.addBtn.Iconimage_Selected = null;
            this.addBtn.IconMarginLeft = 0;
            this.addBtn.IconMarginRight = 0;
            this.addBtn.IconRightVisible = true;
            this.addBtn.IconRightZoom = 0D;
            this.addBtn.IconVisible = true;
            this.addBtn.IconZoom = 50D;
            this.addBtn.IsTab = false;
            this.addBtn.Location = new System.Drawing.Point(22, 41);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.addBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.addBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addBtn.selected = false;
            this.addBtn.Size = new System.Drawing.Size(106, 34);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "     Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Textcolor = System.Drawing.Color.White;
            this.addBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.programData);
            this.panel2.Location = new System.Drawing.Point(22, 82);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(629, 397);
            this.panel2.TabIndex = 6;
            // 
            // programData
            // 
            this.programData.AllowUserToAddRows = false;
            this.programData.AllowUserToDeleteRows = false;
            this.programData.AllowUserToResizeColumns = false;
            this.programData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.programData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.programData.BackgroundColor = System.Drawing.Color.White;
            this.programData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.programData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.programData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.programData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.programData.ColumnHeadersHeight = 55;
            this.programData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.programData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.A,
            this.B,
            this.C,
            this.D,
            this.E});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.programData.DefaultCellStyle = dataGridViewCellStyle3;
            this.programData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programData.DoubleBuffered = true;
            this.programData.EnableHeadersVisualStyles = false;
            this.programData.GridColor = System.Drawing.Color.White;
            this.programData.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.programData.HeaderForeColor = System.Drawing.Color.White;
            this.programData.Location = new System.Drawing.Point(5, 5);
            this.programData.MultiSelect = false;
            this.programData.Name = "programData";
            this.programData.ReadOnly = true;
            this.programData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.programData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.programData.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.programData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.programData.RowTemplate.Height = 45;
            this.programData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.programData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.programData.Size = new System.Drawing.Size(619, 387);
            this.programData.TabIndex = 1;
            this.programData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.programData_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // A
            // 
            this.A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A.DataPropertyName = "A";
            this.A.HeaderText = "Program Name";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // B
            // 
            this.B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.B.DataPropertyName = "B";
            this.B.HeaderText = "Program Date";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            // 
            // C
            // 
            this.C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C.DataPropertyName = "C";
            this.C.HeaderText = "Program Participants";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // D
            // 
            this.D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.D.DataPropertyName = "D";
            this.D.HeaderText = "Participants Count";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // E
            // 
            this.E.DataPropertyName = "E";
            this.E.HeaderText = "Remaining";
            this.E.Name = "E";
            this.E.ReadOnly = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.panel2;
            // 
            // tab_programs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "tab_programs";
            this.Size = new System.Drawing.Size(682, 501);
            this.Load += new System.EventHandler(this.tab_programs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton addBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid programData;
        private Bunifu.Framework.UI.BunifuFlatButton removeBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton verifyBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

namespace iliekbarangay
{
    partial class program_verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program_verification));
            this.header = new System.Windows.Forms.Panel();
            this.clsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MR = new System.Windows.Forms.TextBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FR = new System.Windows.Forms.TextBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.header.Controls.Add(this.clsBtn);
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(459, 44);
            this.header.TabIndex = 0;
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
            this.clsBtn.Location = new System.Drawing.Point(416, 4);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.clsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.clsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clsBtn.selected = false;
            this.clsBtn.Size = new System.Drawing.Size(38, 28);
            this.clsBtn.TabIndex = 3;
            this.clsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clsBtn.Textcolor = System.Drawing.Color.White;
            this.clsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verification";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(92, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MR
            // 
            this.MR.Enabled = false;
            this.MR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MR.Location = new System.Drawing.Point(92, 355);
            this.MR.Multiline = true;
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(270, 60);
            this.MR.TabIndex = 6;
            this.MR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // SP
            // 
            this.SP.Enabled = false;
            this.SP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP.Location = new System.Drawing.Point(92, 45);
            this.SP.Multiline = true;
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(270, 31);
            this.SP.TabIndex = 7;
            this.SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "programID";
            this.label2.Visible = false;
            // 
            // FR
            // 
            this.FR.Enabled = false;
            this.FR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FR.Location = new System.Drawing.Point(92, 421);
            this.FR.Multiline = true;
            this.FR.Name = "FR";
            this.FR.Size = new System.Drawing.Size(270, 31);
            this.FR.TabIndex = 9;
            this.FR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // program_verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 485);
            this.Controls.Add(this.FR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SP);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "program_verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.program_verification_FormClosing);
            this.Load += new System.EventHandler(this.program_verification_Load);
            this.Leave += new System.EventHandler(this.program_verification_Leave);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton clsBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox MR;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.TextBox SP;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FR;
    }
}
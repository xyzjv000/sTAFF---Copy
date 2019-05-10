namespace iliekbarangay
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ans = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.un = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.headerR = new System.Windows.Forms.Panel();
            this.clsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.headerR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.ans);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.un);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 185);
            this.panel1.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submit.BorderRadius = 5;
            this.submit.ButtonText = "  Submit";
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.DisabledColor = System.Drawing.Color.Gray;
            this.submit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Iconcolor = System.Drawing.Color.Transparent;
            this.submit.Iconimage = ((System.Drawing.Image)(resources.GetObject("submit.Iconimage")));
            this.submit.Iconimage_right = null;
            this.submit.Iconimage_right_Selected = null;
            this.submit.Iconimage_Selected = null;
            this.submit.IconMarginLeft = 0;
            this.submit.IconMarginRight = 0;
            this.submit.IconRightVisible = true;
            this.submit.IconRightZoom = 0D;
            this.submit.IconVisible = true;
            this.submit.IconZoom = 50D;
            this.submit.IsTab = false;
            this.submit.Location = new System.Drawing.Point(171, 127);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit.Name = "submit";
            this.submit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.submit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(164)))), ((int)(((byte)(209)))));
            this.submit.OnHoverTextColor = System.Drawing.Color.White;
            this.submit.selected = false;
            this.submit.Size = new System.Drawing.Size(94, 34);
            this.submit.TabIndex = 9;
            this.submit.Text = "  Submit";
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submit.Textcolor = System.Drawing.Color.White;
            this.submit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ans
            // 
            this.ans.BorderColorFocused = System.Drawing.Color.Blue;
            this.ans.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ans.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.ans.BorderThickness = 3;
            this.ans.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ans.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ans.isPassword = false;
            this.ans.Location = new System.Drawing.Point(86, 87);
            this.ans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(311, 29);
            this.ans.TabIndex = 8;
            this.ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Secret Question";
            // 
            // un
            // 
            this.un.BorderColorFocused = System.Drawing.Color.Blue;
            this.un.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.un.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.un.BorderThickness = 3;
            this.un.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.un.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.un.isPassword = false;
            this.un.Location = new System.Drawing.Point(86, 21);
            this.un.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(311, 29);
            this.un.TabIndex = 5;
            this.un.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.un.OnValueChanged += new System.EventHandler(this.un_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // headerR
            // 
            this.headerR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(119)))), ((int)(((byte)(186)))));
            this.headerR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerR.Controls.Add(this.clsBtn);
            this.headerR.Controls.Add(this.label1);
            this.headerR.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerR.Location = new System.Drawing.Point(0, 0);
            this.headerR.Name = "headerR";
            this.headerR.Size = new System.Drawing.Size(416, 37);
            this.headerR.TabIndex = 2;
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
            this.clsBtn.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.clsBtn.Location = new System.Drawing.Point(376, 0);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.clsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.clsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clsBtn.selected = false;
            this.clsBtn.Size = new System.Drawing.Size(38, 35);
            this.clsBtn.TabIndex = 1;
            this.clsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clsBtn.Textcolor = System.Drawing.Color.White;
            this.clsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.label1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 222);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.headerR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headerR;
        private Bunifu.Framework.UI.BunifuFlatButton clsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox un;
        private Bunifu.Framework.UI.BunifuMetroTextbox ans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton submit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
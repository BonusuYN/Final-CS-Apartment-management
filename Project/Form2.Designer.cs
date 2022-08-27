namespace Project
{
    partial class userpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userpage));
            this.userpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maintananceBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.receiptBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usershowtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.contactbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userpic
            // 
            this.userpic.BackColor = System.Drawing.Color.Transparent;
            this.userpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userpic.Image = global::Project.Properties.Resources.user;
            this.userpic.Location = new System.Drawing.Point(124, 92);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(96, 85);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpic.TabIndex = 0;
            this.userpic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Itim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(230, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome ";
            // 
            // maintananceBtn
            // 
            this.maintananceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maintananceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maintananceBtn.Image = global::Project.Properties.Resources.แจ้งงานซ่อมbutton;
            this.maintananceBtn.Location = new System.Drawing.Point(247, 240);
            this.maintananceBtn.Name = "maintananceBtn";
            this.maintananceBtn.Size = new System.Drawing.Size(309, 78);
            this.maintananceBtn.TabIndex = 10;
            this.maintananceBtn.UseVisualStyleBackColor = true;
            this.maintananceBtn.Click += new System.EventHandler(this.maintananceBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project.Properties.Resources.ช่าง;
            this.pictureBox1.Location = new System.Drawing.Point(524, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // receiptBtn
            // 
            this.receiptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiptBtn.Image = global::Project.Properties.Resources.ดูค่าเช่าห้องbutton;
            this.receiptBtn.Location = new System.Drawing.Point(488, 359);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(309, 78);
            this.receiptBtn.TabIndex = 12;
            this.receiptBtn.UseVisualStyleBackColor = true;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedbackBtn.Image = global::Project.Properties.Resources.ร้องเรียนbutton;
            this.feedbackBtn.Location = new System.Drawing.Point(740, 478);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(309, 78);
            this.feedbackBtn.TabIndex = 13;
            this.feedbackBtn.UseVisualStyleBackColor = true;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Project.Properties.Resources.log_out_button;
            this.button1.Location = new System.Drawing.Point(1158, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 55);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logout_click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Project.Properties.Resources.Guild;
            this.pictureBox2.Location = new System.Drawing.Point(12, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 382);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // usershowtxt
            // 
            this.usershowtxt.Location = new System.Drawing.Point(237, 137);
            this.usershowtxt.Name = "usershowtxt";
            this.usershowtxt.ReadOnly = true;
            this.usershowtxt.Size = new System.Drawing.Size(209, 40);
            this.usershowtxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.usershowtxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.usershowtxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.usershowtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.usershowtxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.usershowtxt.StateCommon.Border.Rounding = 20;
            this.usershowtxt.StateCommon.Border.Width = 1;
            this.usershowtxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.usershowtxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usershowtxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.usershowtxt.TabIndex = 54;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // contactbtn
            // 
            this.contactbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contactbtn.Image = global::Project.Properties.Resources.Contact_us_button;
            this.contactbtn.Location = new System.Drawing.Point(1158, 12);
            this.contactbtn.Name = "contactbtn";
            this.contactbtn.Size = new System.Drawing.Size(94, 55);
            this.contactbtn.TabIndex = 15;
            this.contactbtn.UseVisualStyleBackColor = true;
            this.contactbtn.Click += new System.EventHandler(this.contactbtn_Click);
            // 
            // userpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.allbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.usershowtxt);
            this.Controls.Add(this.contactbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feedbackBtn);
            this.Controls.Add(this.receiptBtn);
            this.Controls.Add(this.maintananceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userpic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "userpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place";
            this.Load += new System.EventHandler(this.userpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button maintananceBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button receiptBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usershowtxt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button contactbtn;
    }
}
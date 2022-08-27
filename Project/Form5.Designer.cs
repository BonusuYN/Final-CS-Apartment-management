namespace Project
{
    partial class adminpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpage));
            this.label1 = new System.Windows.Forms.Label();
            this.adminBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.viewroom_Btn = new System.Windows.Forms.Button();
            this.viewserviceBtn = new System.Windows.Forms.Button();
            this.feedbackviewBtn = new System.Windows.Forms.Button();
            this.manageresident_btn = new System.Windows.Forms.Button();
            this.rentalfeemanage_Btn = new System.Windows.Forms.Button();
            this.logout_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Itim", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(206, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome ";
            // 
            // adminBox
            // 
            this.adminBox.Location = new System.Drawing.Point(202, 126);
            this.adminBox.Name = "adminBox";
            this.adminBox.ReadOnly = true;
            this.adminBox.Size = new System.Drawing.Size(235, 40);
            this.adminBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.adminBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.adminBox.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.adminBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.adminBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.adminBox.StateCommon.Border.Rounding = 20;
            this.adminBox.StateCommon.Border.Width = 1;
            this.adminBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.adminBox.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.adminBox.TabIndex = 11;
            this.adminBox.Text = "\r\nadmin";
            // 
            // userpic
            // 
            this.userpic.BackColor = System.Drawing.Color.Transparent;
            this.userpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userpic.Image = global::Project.Properties.Resources.admin;
            this.userpic.Location = new System.Drawing.Point(100, 81);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(96, 85);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpic.TabIndex = 10;
            this.userpic.TabStop = false;
            // 
            // viewroom_Btn
            // 
            this.viewroom_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewroom_Btn.Font = new System.Drawing.Font("Itim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewroom_Btn.Image = global::Project.Properties.Resources.viewroombtn;
            this.viewroom_Btn.Location = new System.Drawing.Point(252, 214);
            this.viewroom_Btn.Name = "viewroom_Btn";
            this.viewroom_Btn.Size = new System.Drawing.Size(269, 75);
            this.viewroom_Btn.TabIndex = 13;
            this.viewroom_Btn.UseVisualStyleBackColor = true;
            this.viewroom_Btn.Click += new System.EventHandler(this.viewroom_Btn_Click);
            // 
            // viewserviceBtn
            // 
            this.viewserviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewserviceBtn.Font = new System.Drawing.Font("Itim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewserviceBtn.Image = global::Project.Properties.Resources.viewservicebtn;
            this.viewserviceBtn.Location = new System.Drawing.Point(694, 348);
            this.viewserviceBtn.Name = "viewserviceBtn";
            this.viewserviceBtn.Size = new System.Drawing.Size(269, 75);
            this.viewserviceBtn.TabIndex = 14;
            this.viewserviceBtn.UseVisualStyleBackColor = true;
            this.viewserviceBtn.Click += new System.EventHandler(this.viewserviceBtn_Click);
            // 
            // feedbackviewBtn
            // 
            this.feedbackviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedbackviewBtn.Font = new System.Drawing.Font("Itim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackviewBtn.Image = global::Project.Properties.Resources.viewfeedbackbtn;
            this.feedbackviewBtn.Location = new System.Drawing.Point(252, 348);
            this.feedbackviewBtn.Name = "feedbackviewBtn";
            this.feedbackviewBtn.Size = new System.Drawing.Size(269, 75);
            this.feedbackviewBtn.TabIndex = 15;
            this.feedbackviewBtn.UseVisualStyleBackColor = true;
            this.feedbackviewBtn.Click += new System.EventHandler(this.feedbackviewBtn_Click);
            // 
            // manageresident_btn
            // 
            this.manageresident_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageresident_btn.Font = new System.Drawing.Font("Itim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageresident_btn.Image = global::Project.Properties.Resources.viewpeoplebtn;
            this.manageresident_btn.Location = new System.Drawing.Point(694, 214);
            this.manageresident_btn.Name = "manageresident_btn";
            this.manageresident_btn.Size = new System.Drawing.Size(269, 75);
            this.manageresident_btn.TabIndex = 16;
            this.manageresident_btn.UseVisualStyleBackColor = true;
            this.manageresident_btn.Click += new System.EventHandler(this.manageresident_btn_Click);
            // 
            // rentalfeemanage_Btn
            // 
            this.rentalfeemanage_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rentalfeemanage_Btn.Font = new System.Drawing.Font("Itim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalfeemanage_Btn.Image = global::Project.Properties.Resources.managerentalbtn;
            this.rentalfeemanage_Btn.Location = new System.Drawing.Point(486, 483);
            this.rentalfeemanage_Btn.Name = "rentalfeemanage_Btn";
            this.rentalfeemanage_Btn.Size = new System.Drawing.Size(269, 75);
            this.rentalfeemanage_Btn.TabIndex = 17;
            this.rentalfeemanage_Btn.UseVisualStyleBackColor = true;
            this.rentalfeemanage_Btn.Click += new System.EventHandler(this.rentalfeemanage_Btn_Click);
            // 
            // logout_Btn
            // 
            this.logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout_Btn.Image = global::Project.Properties.Resources.log_out_button;
            this.logout_Btn.Location = new System.Drawing.Point(1158, 614);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(94, 55);
            this.logout_Btn.TabIndex = 18;
            this.logout_Btn.UseVisualStyleBackColor = true;
            this.logout_Btn.Click += new System.EventHandler(this.logout_Click);
            // 
            // adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.adminBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.logout_Btn);
            this.Controls.Add(this.rentalfeemanage_Btn);
            this.Controls.Add(this.manageresident_btn);
            this.Controls.Add(this.feedbackviewBtn);
            this.Controls.Add(this.viewserviceBtn);
            this.Controls.Add(this.viewroom_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.userpic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "adminpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place (ADMIN)";
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox adminBox;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Button viewroom_Btn;
        private System.Windows.Forms.Button viewserviceBtn;
        private System.Windows.Forms.Button feedbackviewBtn;
        private System.Windows.Forms.Button manageresident_btn;
        private System.Windows.Forms.Button rentalfeemanage_Btn;
        private System.Windows.Forms.Button logout_Btn;
    }
}
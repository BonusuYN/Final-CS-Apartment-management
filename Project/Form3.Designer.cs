namespace Project
{
    partial class servicepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(servicepage));
            this.userpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maintenancetxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.summitBtn = new System.Windows.Forms.Button();
            this.datepicktxt = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.backBtn = new System.Windows.Forms.Button();
            this.allowtxt_check = new System.Windows.Forms.CheckBox();
            this.usershowtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // userpic
            // 
            this.userpic.BackColor = System.Drawing.Color.Transparent;
            this.userpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userpic.Image = global::Project.Properties.Resources.user;
            this.userpic.Location = new System.Drawing.Point(103, 66);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(96, 85);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpic.TabIndex = 10;
            this.userpic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Itim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "แจ้งงานที่ต้องการซ่อม";
            // 
            // maintenancetxt
            // 
            this.maintenancetxt.Location = new System.Drawing.Point(514, 257);
            this.maintenancetxt.Multiline = true;
            this.maintenancetxt.Name = "maintenancetxt";
            this.maintenancetxt.Size = new System.Drawing.Size(426, 51);
            this.maintenancetxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.maintenancetxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.maintenancetxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.maintenancetxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.maintenancetxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.maintenancetxt.StateCommon.Border.Rounding = 20;
            this.maintenancetxt.StateCommon.Border.Width = 1;
            this.maintenancetxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.maintenancetxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenancetxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.maintenancetxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Itim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "เลือกวันที่ต้องการให้ช่างเข้าซ่อม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Itim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(769, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "หรือหากน้องๆต้องการให้พี่ช่างนำกุญแจสำรองเข้าซ่อมได้เลย ให้กดที่ปุ่มด้านล่าง**";
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.AnimateShowHideButton = false;
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.DrawShadows = true;
            this.materialFloatingActionButton1.Icon = null;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(-23, -46);
            this.materialFloatingActionButton1.Mini = false;
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 17;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // summitBtn
            // 
            this.summitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.summitBtn.Image = global::Project.Properties.Resources.summitbutton;
            this.summitBtn.Location = new System.Drawing.Point(482, 547);
            this.summitBtn.Name = "summitBtn";
            this.summitBtn.Size = new System.Drawing.Size(260, 60);
            this.summitBtn.TabIndex = 18;
            this.summitBtn.UseVisualStyleBackColor = true;
            this.summitBtn.Click += new System.EventHandler(this.summitBtn_Click);
            // 
            // datepicktxt
            // 
            this.datepicktxt.Location = new System.Drawing.Point(567, 336);
            this.datepicktxt.Name = "datepicktxt";
            this.datepicktxt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.datepicktxt.Size = new System.Drawing.Size(241, 37);
            this.datepicktxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.datepicktxt.StateCommon.Border.Rounding = 20;
            this.datepicktxt.StateCommon.Border.Width = 1;
            this.datepicktxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicktxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1);
            this.datepicktxt.TabIndex = 22;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Image = global::Project.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(12, 625);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 44);
            this.backBtn.TabIndex = 25;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // allowtxt_check
            // 
            this.allowtxt_check.AutoSize = true;
            this.allowtxt_check.BackColor = System.Drawing.Color.Transparent;
            this.allowtxt_check.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowtxt_check.Location = new System.Drawing.Point(255, 458);
            this.allowtxt_check.Name = "allowtxt_check";
            this.allowtxt_check.Size = new System.Drawing.Size(280, 29);
            this.allowtxt_check.TabIndex = 26;
            this.allowtxt_check.Text = "ต้องการให้พี่ช่างเข้าซ่อมได้เลย";
            this.allowtxt_check.UseVisualStyleBackColor = false;
            // 
            // usershowtxt
            // 
            this.usershowtxt.Location = new System.Drawing.Point(205, 94);
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
            this.usershowtxt.TabIndex = 55;
            // 
            // servicepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.ServiceBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.usershowtxt);
            this.Controls.Add(this.allowtxt_check);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.datepicktxt);
            this.Controls.Add(this.summitBtn);
            this.Controls.Add(this.materialFloatingActionButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maintenancetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userpic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "servicepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place";
            this.Load += new System.EventHandler(this.servicepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox maintenancetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private System.Windows.Forms.Button summitBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datepicktxt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.CheckBox allowtxt_check;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usershowtxt;
    }
}
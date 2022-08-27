namespace Project
{
    partial class feedbackpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feedbackpage));
            this.userpic = new System.Windows.Forms.PictureBox();
            this.feedbacksubtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feedbackinfotxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.summitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.usershowtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // userpic
            // 
            this.userpic.BackColor = System.Drawing.Color.Transparent;
            this.userpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userpic.Image = global::Project.Properties.Resources.user;
            this.userpic.Location = new System.Drawing.Point(69, 66);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(96, 85);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpic.TabIndex = 12;
            this.userpic.TabStop = false;
            // 
            // feedbacksubtxt
            // 
            this.feedbacksubtxt.Location = new System.Drawing.Point(526, 265);
            this.feedbacksubtxt.Name = "feedbacksubtxt";
            this.feedbacksubtxt.Size = new System.Drawing.Size(426, 40);
            this.feedbacksubtxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.feedbacksubtxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.feedbacksubtxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.feedbacksubtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.feedbacksubtxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.feedbacksubtxt.StateCommon.Border.Rounding = 20;
            this.feedbacksubtxt.StateCommon.Border.Width = 1;
            this.feedbacksubtxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.feedbacksubtxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbacksubtxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.feedbacksubtxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Itim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "แจ้งเรื่องที่ต้องการร้องเรียน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Itim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "รายละเอียดของเรื่อง";
            // 
            // feedbackinfotxt
            // 
            this.feedbackinfotxt.Location = new System.Drawing.Point(526, 342);
            this.feedbackinfotxt.Multiline = true;
            this.feedbackinfotxt.Name = "feedbackinfotxt";
            this.feedbackinfotxt.Size = new System.Drawing.Size(426, 132);
            this.feedbackinfotxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.feedbackinfotxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.feedbackinfotxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.feedbackinfotxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.feedbackinfotxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.feedbackinfotxt.StateCommon.Border.Rounding = 20;
            this.feedbackinfotxt.StateCommon.Border.Width = 1;
            this.feedbackinfotxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.feedbackinfotxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackinfotxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.feedbackinfotxt.TabIndex = 17;
            // 
            // summitBtn
            // 
            this.summitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.summitBtn.Image = global::Project.Properties.Resources.summitbutton;
            this.summitBtn.Location = new System.Drawing.Point(486, 536);
            this.summitBtn.Name = "summitBtn";
            this.summitBtn.Size = new System.Drawing.Size(260, 60);
            this.summitBtn.TabIndex = 18;
            this.summitBtn.UseVisualStyleBackColor = true;
            this.summitBtn.Click += new System.EventHandler(this.summitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Image = global::Project.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(12, 625);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 44);
            this.backBtn.TabIndex = 29;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // usershowtxt
            // 
            this.usershowtxt.Location = new System.Drawing.Point(171, 98);
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
            this.usershowtxt.TabIndex = 57;
            // 
            // feedbackpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Reportbutton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.usershowtxt);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.summitBtn);
            this.Controls.Add(this.feedbackinfotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feedbacksubtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userpic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "feedbackpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.feedbackpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox userpic;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox feedbacksubtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox feedbackinfotxt;
        private System.Windows.Forms.Button summitBtn;
        private System.Windows.Forms.Button backBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usershowtxt;
    }
}
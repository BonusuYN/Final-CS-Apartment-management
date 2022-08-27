namespace Project
{
    partial class Bill
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roomtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.electotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.watertotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.totaltxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roompricetxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(507, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 44);
            this.label4.TabIndex = 39;
            this.label4.Text = "แจ้งยอดค่าเช่า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(65, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 44);
            this.label1.TabIndex = 40;
            this.label1.Text = "หมายเลขห้อง";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(65, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 44);
            this.label2.TabIndex = 41;
            this.label2.Text = "ค่าไฟ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(65, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 44);
            this.label3.TabIndex = 42;
            this.label3.Text = "ค่าน้ำ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(65, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 44);
            this.label5.TabIndex = 43;
            this.label5.Text = "รวม";
            // 
            // roomtxt
            // 
            this.roomtxt.Location = new System.Drawing.Point(376, 172);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.ReadOnly = true;
            this.roomtxt.Size = new System.Drawing.Size(242, 40);
            this.roomtxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.roomtxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.roomtxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.roomtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomtxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.roomtxt.StateCommon.Border.Rounding = 20;
            this.roomtxt.StateCommon.Border.Width = 1;
            this.roomtxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.roomtxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roomtxt.TabIndex = 44;
            // 
            // electotal
            // 
            this.electotal.Location = new System.Drawing.Point(376, 254);
            this.electotal.Name = "electotal";
            this.electotal.ReadOnly = true;
            this.electotal.Size = new System.Drawing.Size(242, 40);
            this.electotal.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.electotal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.electotal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.electotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.electotal.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.electotal.StateCommon.Border.Rounding = 20;
            this.electotal.StateCommon.Border.Width = 1;
            this.electotal.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.electotal.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electotal.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.electotal.TabIndex = 45;
            // 
            // watertotal
            // 
            this.watertotal.Location = new System.Drawing.Point(376, 342);
            this.watertotal.Name = "watertotal";
            this.watertotal.ReadOnly = true;
            this.watertotal.Size = new System.Drawing.Size(242, 40);
            this.watertotal.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.watertotal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.watertotal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.watertotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.watertotal.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.watertotal.StateCommon.Border.Rounding = 20;
            this.watertotal.StateCommon.Border.Width = 1;
            this.watertotal.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.watertotal.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watertotal.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.watertotal.TabIndex = 46;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(376, 520);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(242, 40);
            this.totaltxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.totaltxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.totaltxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.totaltxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.totaltxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.totaltxt.StateCommon.Border.Rounding = 20;
            this.totaltxt.StateCommon.Border.Width = 1;
            this.totaltxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.totaltxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.totaltxt.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(673, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 44);
            this.label6.TabIndex = 48;
            this.label6.Text = "บาท";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(673, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 44);
            this.label7.TabIndex = 49;
            this.label7.Text = "บาท";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(673, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 44);
            this.label8.TabIndex = 50;
            this.label8.Text = "บาท";
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Image = global::Project.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(12, 625);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 44);
            this.backBtn.TabIndex = 51;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // userpic
            // 
            this.userpic.BackColor = System.Drawing.Color.Transparent;
            this.userpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userpic.Image = global::Project.Properties.Resources.user;
            this.userpic.Location = new System.Drawing.Point(78, 58);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(96, 85);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userpic.TabIndex = 52;
            this.userpic.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(65, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 44);
            this.label9.TabIndex = 53;
            this.label9.Text = "ค่าเช่าห้อง";
            // 
            // roompricetxt
            // 
            this.roompricetxt.Location = new System.Drawing.Point(376, 434);
            this.roompricetxt.Name = "roompricetxt";
            this.roompricetxt.ReadOnly = true;
            this.roompricetxt.Size = new System.Drawing.Size(242, 40);
            this.roompricetxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.roompricetxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.roompricetxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.roompricetxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roompricetxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.roompricetxt.StateCommon.Border.Rounding = 20;
            this.roompricetxt.StateCommon.Border.Width = 1;
            this.roompricetxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.roompricetxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roompricetxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roompricetxt.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(673, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 44);
            this.label10.TabIndex = 55;
            this.label10.Text = "บาท";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.roompricetxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userpic);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.watertotal);
            this.Controls.Add(this.electotal);
            this.Controls.Add(this.roomtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Bill";
            this.Text = "Lucky Place Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox electotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox watertotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox totaltxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roompricetxt;
        private System.Windows.Forms.Label label10;
    }
}
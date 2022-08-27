namespace Project
{
    partial class rentalfee_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentalfee_management));
            this.datarental = new System.Windows.Forms.DataGridView();
            this.summitwatertxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.summitelectxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.oldelectxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newelectxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.oldwatertxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newwatertxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nowelectxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nowwatertxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.roomtxt_combo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.addtodbBtn = new System.Windows.Forms.Button();
            this.cleardatBtn = new System.Windows.Forms.Button();
            this.totaltxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cleardbBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datarental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtxt_combo)).BeginInit();
            this.SuspendLayout();
            // 
            // datarental
            // 
            this.datarental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datarental.Location = new System.Drawing.Point(696, 128);
            this.datarental.Name = "datarental";
            this.datarental.ReadOnly = true;
            this.datarental.RowHeadersVisible = false;
            this.datarental.Size = new System.Drawing.Size(539, 482);
            this.datarental.TabIndex = 0;
            // 
            // summitwatertxt
            // 
            this.summitwatertxt.Location = new System.Drawing.Point(411, 378);
            this.summitwatertxt.Name = "summitwatertxt";
            this.summitwatertxt.ReadOnly = true;
            this.summitwatertxt.Size = new System.Drawing.Size(242, 40);
            this.summitwatertxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.summitwatertxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.summitwatertxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.summitwatertxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.summitwatertxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.summitwatertxt.StateCommon.Border.Rounding = 20;
            this.summitwatertxt.StateCommon.Border.Width = 1;
            this.summitwatertxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.summitwatertxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summitwatertxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.summitwatertxt.TabIndex = 29;
            this.summitwatertxt.Text = "ค่าน้ำ(บาท)";
            this.summitwatertxt.Enter += new System.EventHandler(this.summitwatertxt_Enter);
            this.summitwatertxt.Leave += new System.EventHandler(this.summitwatertxt_Leave);
            // 
            // summitelectxt
            // 
            this.summitelectxt.Location = new System.Drawing.Point(95, 378);
            this.summitelectxt.Name = "summitelectxt";
            this.summitelectxt.ReadOnly = true;
            this.summitelectxt.Size = new System.Drawing.Size(232, 40);
            this.summitelectxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.summitelectxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.summitelectxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.summitelectxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.summitelectxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.summitelectxt.StateCommon.Border.Rounding = 20;
            this.summitelectxt.StateCommon.Border.Width = 1;
            this.summitelectxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.summitelectxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summitelectxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.summitelectxt.TabIndex = 28;
            this.summitelectxt.Text = "ค่าไฟ(บาท)";
            this.summitelectxt.Enter += new System.EventHandler(this.summitelectxt_Enter);
            this.summitelectxt.Leave += new System.EventHandler(this.summitelectxt_Leave);
            // 
            // oldelectxt
            // 
            this.oldelectxt.Location = new System.Drawing.Point(86, 205);
            this.oldelectxt.Name = "oldelectxt";
            this.oldelectxt.Size = new System.Drawing.Size(153, 40);
            this.oldelectxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.oldelectxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.oldelectxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.oldelectxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.oldelectxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.oldelectxt.StateCommon.Border.Rounding = 20;
            this.oldelectxt.StateCommon.Border.Width = 1;
            this.oldelectxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.oldelectxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldelectxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.oldelectxt.TabIndex = 26;
            this.oldelectxt.Text = "หน่วยไฟเดิม";
            this.oldelectxt.Enter += new System.EventHandler(this.oldelectxt_Enter);
            this.oldelectxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldelectxt_KeyPress);
            this.oldelectxt.Leave += new System.EventHandler(this.oldelectxt_Leave);
            // 
            // newelectxt
            // 
            this.newelectxt.Location = new System.Drawing.Point(302, 205);
            this.newelectxt.Name = "newelectxt";
            this.newelectxt.Size = new System.Drawing.Size(153, 40);
            this.newelectxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.newelectxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.newelectxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.newelectxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newelectxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.newelectxt.StateCommon.Border.Rounding = 20;
            this.newelectxt.StateCommon.Border.Width = 1;
            this.newelectxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.newelectxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newelectxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.newelectxt.TabIndex = 31;
            this.newelectxt.Text = "หน่วยไฟใหม่";
            this.newelectxt.Enter += new System.EventHandler(this.newelectxt_Enter);
            this.newelectxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newelectxt_KeyPress);
            this.newelectxt.Leave += new System.EventHandler(this.newelectxt_Leave);
            // 
            // oldwatertxt
            // 
            this.oldwatertxt.Location = new System.Drawing.Point(83, 283);
            this.oldwatertxt.Name = "oldwatertxt";
            this.oldwatertxt.Size = new System.Drawing.Size(153, 40);
            this.oldwatertxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.oldwatertxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.oldwatertxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.oldwatertxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.oldwatertxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.oldwatertxt.StateCommon.Border.Rounding = 20;
            this.oldwatertxt.StateCommon.Border.Width = 1;
            this.oldwatertxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.oldwatertxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldwatertxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.oldwatertxt.TabIndex = 32;
            this.oldwatertxt.Text = "หน่วยน้ำเดิม";
            this.oldwatertxt.Enter += new System.EventHandler(this.oldwatertxt_Enter);
            this.oldwatertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldwatertxt_KeyPress);
            this.oldwatertxt.Leave += new System.EventHandler(this.oldwatertxt_Leave);
            // 
            // newwatertxt
            // 
            this.newwatertxt.Location = new System.Drawing.Point(302, 283);
            this.newwatertxt.Name = "newwatertxt";
            this.newwatertxt.Size = new System.Drawing.Size(153, 40);
            this.newwatertxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.newwatertxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.newwatertxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.newwatertxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newwatertxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.newwatertxt.StateCommon.Border.Rounding = 20;
            this.newwatertxt.StateCommon.Border.Width = 1;
            this.newwatertxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.newwatertxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newwatertxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.newwatertxt.TabIndex = 33;
            this.newwatertxt.Text = "หน่วยน้ำใหม่";
            this.newwatertxt.Enter += new System.EventHandler(this.newwatertxt_Enter);
            this.newwatertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newwatertxt_KeyPress);
            this.newwatertxt.Leave += new System.EventHandler(this.newwatertxt_Leave);
            // 
            // nowelectxt
            // 
            this.nowelectxt.Location = new System.Drawing.Point(519, 205);
            this.nowelectxt.Name = "nowelectxt";
            this.nowelectxt.ReadOnly = true;
            this.nowelectxt.Size = new System.Drawing.Size(153, 40);
            this.nowelectxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.nowelectxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.nowelectxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.nowelectxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nowelectxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nowelectxt.StateCommon.Border.Rounding = 20;
            this.nowelectxt.StateCommon.Border.Width = 1;
            this.nowelectxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.nowelectxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowelectxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nowelectxt.TabIndex = 34;
            this.nowelectxt.Text = "จำนวนที่ใช้";
            this.nowelectxt.Enter += new System.EventHandler(this.nowelectxt_Enter);
            this.nowelectxt.Leave += new System.EventHandler(this.nowelectxt_Leave);
            // 
            // nowwatertxt
            // 
            this.nowwatertxt.Location = new System.Drawing.Point(519, 283);
            this.nowwatertxt.Name = "nowwatertxt";
            this.nowwatertxt.ReadOnly = true;
            this.nowwatertxt.Size = new System.Drawing.Size(153, 40);
            this.nowwatertxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.nowwatertxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.nowwatertxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.nowwatertxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nowwatertxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nowwatertxt.StateCommon.Border.Rounding = 20;
            this.nowwatertxt.StateCommon.Border.Width = 1;
            this.nowwatertxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.nowwatertxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowwatertxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nowwatertxt.TabIndex = 35;
            this.nowwatertxt.Text = "จำนวนที่ใช้";
            this.nowwatertxt.Enter += new System.EventHandler(this.nowwatertxt_Enter);
            this.nowwatertxt.Leave += new System.EventHandler(this.nowwatertxt_Leave);
            // 
            // roomtxt_combo
            // 
            this.roomtxt_combo.DropDownWidth = 163;
            this.roomtxt_combo.Items.AddRange(new object[] {
            "1101",
            "1102",
            "1103",
            "1104",
            "1105",
            "1201",
            "1202",
            "1203",
            "1204",
            "1205"});
            this.roomtxt_combo.Location = new System.Drawing.Point(95, 121);
            this.roomtxt_combo.Name = "roomtxt_combo";
            this.roomtxt_combo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.roomtxt_combo.Size = new System.Drawing.Size(212, 37);
            this.roomtxt_combo.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.roomtxt_combo.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomtxt_combo.StateCommon.ComboBox.Border.Rounding = 20;
            this.roomtxt_combo.StateCommon.ComboBox.Border.Width = 1;
            this.roomtxt_combo.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtxt_combo.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.roomtxt_combo.TabIndex = 36;
            this.roomtxt_combo.Text = "เลือกหมายเลขห้อง";
            // 
            // calculateBtn
            // 
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateBtn.Image = global::Project.Properties.Resources.calculator_btn;
            this.calculateBtn.Location = new System.Drawing.Point(12, 516);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(218, 60);
            this.calculateBtn.TabIndex = 37;
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // addtodbBtn
            // 
            this.addtodbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addtodbBtn.Image = global::Project.Properties.Resources.addtodb_btn;
            this.addtodbBtn.Location = new System.Drawing.Point(245, 516);
            this.addtodbBtn.Name = "addtodbBtn";
            this.addtodbBtn.Size = new System.Drawing.Size(218, 60);
            this.addtodbBtn.TabIndex = 38;
            this.addtodbBtn.UseVisualStyleBackColor = true;
            this.addtodbBtn.Click += new System.EventHandler(this.addtodbBtn_Click);
            // 
            // cleardatBtn
            // 
            this.cleardatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleardatBtn.Image = global::Project.Properties.Resources.clear_btn;
            this.cleardatBtn.Location = new System.Drawing.Point(472, 516);
            this.cleardatBtn.Name = "cleardatBtn";
            this.cleardatBtn.Size = new System.Drawing.Size(218, 60);
            this.cleardatBtn.TabIndex = 39;
            this.cleardatBtn.UseVisualStyleBackColor = true;
            this.cleardatBtn.Click += new System.EventHandler(this.cleardatBtn_Click);
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(245, 452);
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
            this.totaltxt.TabIndex = 40;
            this.totaltxt.Text = "รวม(บาท)";
            this.totaltxt.Enter += new System.EventHandler(this.totaltxt_Enter);
            this.totaltxt.Leave += new System.EventHandler(this.totaltxt_Leave);
            // 
            // cleardbBtn
            // 
            this.cleardbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cleardbBtn.Image = global::Project.Properties.Resources.resetdb_btn;
            this.cleardbBtn.Location = new System.Drawing.Point(246, 591);
            this.cleardbBtn.Name = "cleardbBtn";
            this.cleardbBtn.Size = new System.Drawing.Size(217, 60);
            this.cleardbBtn.TabIndex = 41;
            this.cleardbBtn.UseVisualStyleBackColor = true;
            this.cleardbBtn.Click += new System.EventHandler(this.cleardbBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Image = global::Project.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(12, 625);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 44);
            this.backBtn.TabIndex = 52;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Itim", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(491, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 58);
            this.label4.TabIndex = 53;
            this.label4.Text = "จัดการค่าเช่า";
            // 
            // rentalfee_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cleardbBtn);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.cleardatBtn);
            this.Controls.Add(this.addtodbBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.roomtxt_combo);
            this.Controls.Add(this.nowwatertxt);
            this.Controls.Add(this.nowelectxt);
            this.Controls.Add(this.newwatertxt);
            this.Controls.Add(this.oldwatertxt);
            this.Controls.Add(this.newelectxt);
            this.Controls.Add(this.summitwatertxt);
            this.Controls.Add(this.summitelectxt);
            this.Controls.Add(this.oldelectxt);
            this.Controls.Add(this.datarental);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "rentalfee_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place (ADMIN)";
            this.Load += new System.EventHandler(this.rentalfee_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datarental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtxt_combo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datarental;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox summitwatertxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox summitelectxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox oldelectxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newelectxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox oldwatertxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newwatertxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nowelectxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nowwatertxt;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox roomtxt_combo;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button addtodbBtn;
        private System.Windows.Forms.Button cleardatBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox totaltxt;
        private System.Windows.Forms.Button cleardbBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label4;
    }
}
namespace Project
{
    partial class leasePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leasePage));
            this.nameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.telephonrBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addressBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.yearBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.telophonepaBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parentnameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.user_Box = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pass_Box = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.register_Btn = new System.Windows.Forms.Button();
            this.roomtxt_combo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.dobpickBox = new System.Windows.Forms.DateTimePicker();
            this.arrivedatepick = new System.Windows.Forms.DateTimePicker();
            this.facBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cfpasstxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomtxt_combo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Location = new System.Drawing.Point(40, 127);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(416, 40);
            this.nameBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.nameBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.nameBox.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.nameBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nameBox.StateCommon.Border.Rounding = 20;
            this.nameBox.StateCommon.Border.Width = 1;
            this.nameBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.nameBox.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nameBox.TabIndex = 8;
            this.nameBox.Text = "ชื่อ-นามสกุล";
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // telephonrBox
            // 
            this.telephonrBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telephonrBox.Location = new System.Drawing.Point(477, 127);
            this.telephonrBox.MaxLength = 10;
            this.telephonrBox.Name = "telephonrBox";
            this.telephonrBox.Size = new System.Drawing.Size(381, 40);
            this.telephonrBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.telephonrBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.telephonrBox.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.telephonrBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.telephonrBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.telephonrBox.StateCommon.Border.Rounding = 20;
            this.telephonrBox.StateCommon.Border.Width = 1;
            this.telephonrBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.telephonrBox.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephonrBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.telephonrBox.TabIndex = 10;
            this.telephonrBox.Text = "เบอร์โทรศัพท์";
            this.telephonrBox.Enter += new System.EventHandler(this.telephonrBox_Enter);
            this.telephonrBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telephonrBox_KeyPress);
            this.telephonrBox.Leave += new System.EventHandler(this.telephonrBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressBox.Location = new System.Drawing.Point(683, 198);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(569, 60);
            this.addressBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.addressBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.addressBox.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.addressBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addressBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.addressBox.StateCommon.Border.Rounding = 20;
            this.addressBox.StateCommon.Border.Width = 1;
            this.addressBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.addressBox.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.addressBox.TabIndex = 24;
            this.addressBox.Text = "ที่อยู่ตามทะเบียนบ้าน";
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // yearBox
            // 
            this.yearBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yearBox.Location = new System.Drawing.Point(477, 198);
            this.yearBox.MaxLength = 1;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(160, 40);
            this.yearBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.yearBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.yearBox.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.yearBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.yearBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.yearBox.StateCommon.Border.Rounding = 20;
            this.yearBox.StateCommon.Border.Width = 1;
            this.yearBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.yearBox.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.yearBox.TabIndex = 26;
            this.yearBox.Text = "ชั้นปี";
            this.yearBox.Enter += new System.EventHandler(this.yearBox_Enter);
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            this.yearBox.Leave += new System.EventHandler(this.yearBox_Leave);
            // 
            // telophonepaBox
            // 
            this.telophonepaBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telophonepaBox.Location = new System.Drawing.Point(477, 285);
            this.telophonepaBox.MaxLength = 10;
            this.telophonepaBox.Name = "telophonepaBox";
            this.telophonepaBox.Size = new System.Drawing.Size(381, 40);
            this.telophonepaBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.telophonepaBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.telophonepaBox.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.telophonepaBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.telophonepaBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.telophonepaBox.StateCommon.Border.Rounding = 20;
            this.telophonepaBox.StateCommon.Border.Width = 1;
            this.telophonepaBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.telophonepaBox.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telophonepaBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.telophonepaBox.TabIndex = 27;
            this.telophonepaBox.Text = "เบอร์โทรศัพท์ผู้ปกครอง";
            this.telophonepaBox.Enter += new System.EventHandler(this.telophonepaBox_Enter);
            this.telophonepaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telophonepaBox_KeyPress);
            this.telophonepaBox.Leave += new System.EventHandler(this.telophonepaBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(889, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "ว/ด/ป เกิด";
            // 
            // parentnameBox
            // 
            this.parentnameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parentnameBox.Location = new System.Drawing.Point(40, 285);
            this.parentnameBox.Name = "parentnameBox";
            this.parentnameBox.Size = new System.Drawing.Size(416, 40);
            this.parentnameBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.parentnameBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.parentnameBox.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.parentnameBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.parentnameBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.parentnameBox.StateCommon.Border.Rounding = 20;
            this.parentnameBox.StateCommon.Border.Width = 1;
            this.parentnameBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.parentnameBox.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentnameBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.parentnameBox.TabIndex = 29;
            this.parentnameBox.Text = "ชื่อ-นามสกุล ผู้ปกครอง";
            this.parentnameBox.Enter += new System.EventHandler(this.parentnameBox_Enter);
            this.parentnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parentnameBox_KeyPress);
            this.parentnameBox.Leave += new System.EventHandler(this.parentnameBox_Leave);
            // 
            // user_Box
            // 
            this.user_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_Box.Location = new System.Drawing.Point(442, 399);
            this.user_Box.Name = "user_Box";
            this.user_Box.Size = new System.Drawing.Size(416, 40);
            this.user_Box.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.user_Box.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.user_Box.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.user_Box.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.user_Box.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.user_Box.StateCommon.Border.Rounding = 20;
            this.user_Box.StateCommon.Border.Width = 1;
            this.user_Box.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.user_Box.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_Box.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.user_Box.TabIndex = 31;
            this.user_Box.Text = "Username";
            this.user_Box.Enter += new System.EventHandler(this.usernameBox_Enter);
            this.user_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_Box_KeyPress);
            this.user_Box.Leave += new System.EventHandler(this.usernameBox_Leave);
            // 
            // pass_Box
            // 
            this.pass_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_Box.Location = new System.Drawing.Point(442, 465);
            this.pass_Box.Name = "pass_Box";
            this.pass_Box.Size = new System.Drawing.Size(416, 40);
            this.pass_Box.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.pass_Box.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.pass_Box.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.pass_Box.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pass_Box.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pass_Box.StateCommon.Border.Rounding = 20;
            this.pass_Box.StateCommon.Border.Width = 1;
            this.pass_Box.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.pass_Box.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_Box.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pass_Box.TabIndex = 32;
            this.pass_Box.Text = "Password";
            this.pass_Box.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.pass_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_Box_KeyPress);
            this.pass_Box.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Itim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(299, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(692, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "**กรุณาตั้งUsernameและPasswordในการเข้าใช้งานระบบ**";
            // 
            // register_Btn
            // 
            this.register_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_Btn.Image = global::Project.Properties.Resources.registerbutton;
            this.register_Btn.Location = new System.Drawing.Point(512, 604);
            this.register_Btn.Name = "register_Btn";
            this.register_Btn.Size = new System.Drawing.Size(302, 65);
            this.register_Btn.TabIndex = 34;
            this.register_Btn.UseVisualStyleBackColor = true;
            this.register_Btn.Click += new System.EventHandler(this.register_Btn_Click);
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
            this.roomtxt_combo.Location = new System.Drawing.Point(98, 64);
            this.roomtxt_combo.Name = "roomtxt_combo";
            this.roomtxt_combo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.roomtxt_combo.Size = new System.Drawing.Size(212, 37);
            this.roomtxt_combo.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.roomtxt_combo.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.roomtxt_combo.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.roomtxt_combo.StateCommon.ComboBox.Border.Rounding = 20;
            this.roomtxt_combo.StateCommon.ComboBox.Border.Width = 1;
            this.roomtxt_combo.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtxt_combo.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.roomtxt_combo.TabIndex = 35;
            this.roomtxt_combo.Text = "เลือกหมายเลขห้อง";
            this.roomtxt_combo.SelectedIndexChanged += new System.EventHandler(this.roomtxt_combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(868, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "ว/ด/ป ที่เข้าพัก";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Itim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(434, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 44);
            this.label4.TabIndex = 38;
            this.label4.Text = "แบบลงทะเบียนเข้าหอพัก";
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Image = global::Project.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(22, 615);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 44);
            this.backBtn.TabIndex = 39;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dobpickBox
            // 
            this.dobpickBox.Font = new System.Drawing.Font("Itim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobpickBox.Location = new System.Drawing.Point(1011, 139);
            this.dobpickBox.Name = "dobpickBox";
            this.dobpickBox.Size = new System.Drawing.Size(200, 25);
            this.dobpickBox.TabIndex = 40;
            // 
            // arrivedatepick
            // 
            this.arrivedatepick.Font = new System.Drawing.Font("Itim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivedatepick.Location = new System.Drawing.Point(1011, 297);
            this.arrivedatepick.Name = "arrivedatepick";
            this.arrivedatepick.Size = new System.Drawing.Size(200, 25);
            this.arrivedatepick.TabIndex = 41;
            // 
            // facBox
            // 
            this.facBox.DropDownWidth = 163;
            this.facBox.Items.AddRange(new object[] {
            "คณะวิทยาศาสตร์",
            "คณะเกษตรศาสตร์",
            "คณะวิศวกรรมศาสตร์",
            "คณะศึกษาศาสตร์",
            "คณะพยาบาลศาสตร์",
            "คณะแพทยศาสตร์",
            "คณะมนุษยศาสตร์และสังคมศาสตร์",
            "คณะเทคนิคการแพทย์",
            "คณะสาธารณสุขศาสตร์",
            "คณะทันตแพทยศาสตร์",
            "คณะเภสัชศาสตร์",
            "คณะเทคโนโลยี",
            "คณะสัตวแพทยศาสตร์",
            "คณะสถาปัตยกรรมศาสตร์",
            "คณะบริหารธุรกิจและการบัญชี",
            "คณะศิลปกรรมศาสตร์",
            "คณะนิติศาสตร์",
            "วิทยาลัยการปกครองท้องถิ่น",
            "วิทยาลัยนานาชาติ",
            "คณะเศรษฐศาสตร์",
            "วิทยาลัยการคอมพิวเตอร์"});
            this.facBox.Location = new System.Drawing.Point(40, 201);
            this.facBox.Name = "facBox";
            this.facBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.facBox.Size = new System.Drawing.Size(416, 37);
            this.facBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.facBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.facBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.facBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.facBox.StateCommon.ComboBox.Border.Width = 1;
            this.facBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facBox.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(1);
            this.facBox.TabIndex = 42;
            this.facBox.Text = "คณะที่กำลังศึกษา";
            // 
            // cfpasstxt
            // 
            this.cfpasstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cfpasstxt.Location = new System.Drawing.Point(442, 533);
            this.cfpasstxt.Name = "cfpasstxt";
            this.cfpasstxt.Size = new System.Drawing.Size(416, 40);
            this.cfpasstxt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cfpasstxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.cfpasstxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.cfpasstxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cfpasstxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cfpasstxt.StateCommon.Border.Rounding = 20;
            this.cfpasstxt.StateCommon.Border.Width = 1;
            this.cfpasstxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.cfpasstxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfpasstxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cfpasstxt.TabIndex = 43;
            this.cfpasstxt.Text = "Confirm Password";
            this.cfpasstxt.Enter += new System.EventHandler(this.cfpasstxt_Enter);
            this.cfpasstxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cfpasstxt_KeyPress);
            this.cfpasstxt.Leave += new System.EventHandler(this.cfpasstxt_Leave);
            // 
            // leasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cfpasstxt);
            this.Controls.Add(this.facBox);
            this.Controls.Add(this.arrivedatepick);
            this.Controls.Add(this.dobpickBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomtxt_combo);
            this.Controls.Add(this.register_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass_Box);
            this.Controls.Add(this.user_Box);
            this.Controls.Add(this.parentnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telophonepaBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.telephonrBox);
            this.Controls.Add(this.nameBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "leasePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place ";
            this.Load += new System.EventHandler(this.leasePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomtxt_combo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox telephonrBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox yearBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox telophonepaBox;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox parentnameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox user_Box;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pass_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button register_Btn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox roomtxt_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DateTimePicker dobpickBox;
        private System.Windows.Forms.DateTimePicker arrivedatepick;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox facBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cfpasstxt;
    }
}
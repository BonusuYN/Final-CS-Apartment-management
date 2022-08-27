namespace Project
{
    partial class view_roomstatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_roomstatus));
            this.dataroomlist = new System.Windows.Forms.DataGridView();
            this.unaviableBtn = new System.Windows.Forms.Button();
            this.howtotxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.aviableBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataroomlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataroomlist
            // 
            this.dataroomlist.AllowUserToResizeColumns = false;
            this.dataroomlist.AllowUserToResizeRows = false;
            this.dataroomlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataroomlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataroomlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataroomlist.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataroomlist.Location = new System.Drawing.Point(68, 151);
            this.dataroomlist.Name = "dataroomlist";
            this.dataroomlist.RowHeadersVisible = false;
            this.dataroomlist.Size = new System.Drawing.Size(516, 445);
            this.dataroomlist.TabIndex = 0;
            this.dataroomlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataroomlist_CellClick);
            // 
            // unaviableBtn
            // 
            this.unaviableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unaviableBtn.Image = global::Project.Properties.Resources.setstatustounavaiablebtn;
            this.unaviableBtn.Location = new System.Drawing.Point(739, 360);
            this.unaviableBtn.Name = "unaviableBtn";
            this.unaviableBtn.Size = new System.Drawing.Size(272, 65);
            this.unaviableBtn.TabIndex = 1;
            this.unaviableBtn.UseVisualStyleBackColor = true;
            this.unaviableBtn.Click += new System.EventHandler(this.unaviableBtn_Click);
            // 
            // howtotxt
            // 
            this.howtotxt.Location = new System.Drawing.Point(658, 205);
            this.howtotxt.Multiline = true;
            this.howtotxt.Name = "howtotxt";
            this.howtotxt.Size = new System.Drawing.Size(440, 121);
            this.howtotxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.howtotxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.howtotxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.howtotxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.howtotxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.howtotxt.StateCommon.Border.Rounding = 20;
            this.howtotxt.StateCommon.Border.Width = 1;
            this.howtotxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.howtotxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtotxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.howtotxt.TabIndex = 33;
            this.howtotxt.Text = "สาเหตุในการปรับสถานะ";
            this.howtotxt.Enter += new System.EventHandler(this.howtotxt_Enter);
            this.howtotxt.Leave += new System.EventHandler(this.howtotxt_Leave);
            // 
            // aviableBtn
            // 
            this.aviableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aviableBtn.Image = global::Project.Properties.Resources.setstatustoavaiablebtn;
            this.aviableBtn.Location = new System.Drawing.Point(739, 477);
            this.aviableBtn.Name = "aviableBtn";
            this.aviableBtn.Size = new System.Drawing.Size(272, 65);
            this.aviableBtn.TabIndex = 34;
            this.aviableBtn.UseVisualStyleBackColor = true;
            this.aviableBtn.Click += new System.EventHandler(this.aviableBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Image = global::Project.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(12, 625);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 44);
            this.backBtn.TabIndex = 35;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // view_roomstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.roomstatusbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.aviableBtn);
            this.Controls.Add(this.howtotxt);
            this.Controls.Add(this.unaviableBtn);
            this.Controls.Add(this.dataroomlist);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "view_roomstatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place(ADMN)";
            this.Load += new System.EventHandler(this.veiw_roomstatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataroomlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataroomlist;
        private System.Windows.Forms.Button unaviableBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox howtotxt;
        private System.Windows.Forms.Button aviableBtn;
        private System.Windows.Forms.Button backBtn;
    }
}
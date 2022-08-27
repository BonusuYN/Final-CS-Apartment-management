namespace Project
{
    partial class service_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(service_view));
            this.dataService = new System.Windows.Forms.DataGridView();
            this.editstatusBtn = new System.Windows.Forms.Button();
            this.serviceinfotxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.roomtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.timetxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.allowtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.statustxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataService
            // 
            this.dataService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataService.Location = new System.Drawing.Point(541, 152);
            this.dataService.Name = "dataService";
            this.dataService.Size = new System.Drawing.Size(677, 447);
            this.dataService.TabIndex = 0;
            this.dataService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataService_CellClick);
            // 
            // editstatusBtn
            // 
            this.editstatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editstatusBtn.Image = global::Project.Properties.Resources.editstatusbtn;
            this.editstatusBtn.Location = new System.Drawing.Point(150, 576);
            this.editstatusBtn.Name = "editstatusBtn";
            this.editstatusBtn.Size = new System.Drawing.Size(250, 60);
            this.editstatusBtn.TabIndex = 19;
            this.editstatusBtn.UseVisualStyleBackColor = true;
            this.editstatusBtn.Click += new System.EventHandler(this.editstatusBtn_Click);
            // 
            // serviceinfotxt
            // 
            this.serviceinfotxt.Location = new System.Drawing.Point(102, 221);
            this.serviceinfotxt.Multiline = true;
            this.serviceinfotxt.Name = "serviceinfotxt";
            this.serviceinfotxt.Size = new System.Drawing.Size(346, 119);
            this.serviceinfotxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.serviceinfotxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.serviceinfotxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.serviceinfotxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.serviceinfotxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.serviceinfotxt.StateCommon.Border.Rounding = 20;
            this.serviceinfotxt.StateCommon.Border.Width = 1;
            this.serviceinfotxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.serviceinfotxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceinfotxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.serviceinfotxt.TabIndex = 22;
            // 
            // roomtxt
            // 
            this.roomtxt.Location = new System.Drawing.Point(102, 152);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.Size = new System.Drawing.Size(346, 40);
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
            this.roomtxt.TabIndex = 20;
            // 
            // timetxt
            // 
            this.timetxt.Location = new System.Drawing.Point(102, 364);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(346, 40);
            this.timetxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.timetxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.timetxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.timetxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.timetxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.timetxt.StateCommon.Border.Rounding = 20;
            this.timetxt.StateCommon.Border.Width = 1;
            this.timetxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.timetxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.timetxt.TabIndex = 23;
            // 
            // allowtxt
            // 
            this.allowtxt.Location = new System.Drawing.Point(102, 436);
            this.allowtxt.Name = "allowtxt";
            this.allowtxt.Size = new System.Drawing.Size(346, 40);
            this.allowtxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.allowtxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.allowtxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.allowtxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.allowtxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.allowtxt.StateCommon.Border.Rounding = 20;
            this.allowtxt.StateCommon.Border.Width = 1;
            this.allowtxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.allowtxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowtxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.allowtxt.TabIndex = 24;
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(102, 512);
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(346, 40);
            this.statustxt.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.statustxt.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.statustxt.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.statustxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.statustxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.statustxt.StateCommon.Border.Rounding = 20;
            this.statustxt.StateCommon.Border.Width = 1;
            this.statustxt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.statustxt.StateCommon.Content.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustxt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.statustxt.TabIndex = 25;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Image = global::Project.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(12, 625);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 44);
            this.backBtn.TabIndex = 31;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // service_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.viewserviceBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.allowtxt);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.serviceinfotxt);
            this.Controls.Add(this.roomtxt);
            this.Controls.Add(this.editstatusBtn);
            this.Controls.Add(this.dataService);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "service_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place(ADMIN)";
            this.Load += new System.EventHandler(this.service_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataService;
        private System.Windows.Forms.Button editstatusBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox serviceinfotxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox timetxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox allowtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox statustxt;
        private System.Windows.Forms.Button backBtn;
    }
}
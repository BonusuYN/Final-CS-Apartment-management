namespace Project
{
    partial class veiw_people
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(veiw_people));
            this.datapeople = new System.Windows.Forms.DataGridView();
            this.aviableBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datapeople)).BeginInit();
            this.SuspendLayout();
            // 
            // datapeople
            // 
            this.datapeople.AllowUserToAddRows = false;
            this.datapeople.AllowUserToDeleteRows = false;
            this.datapeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datapeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datapeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datapeople.DefaultCellStyle = dataGridViewCellStyle1;
            this.datapeople.Location = new System.Drawing.Point(47, 189);
            this.datapeople.Name = "datapeople";
            this.datapeople.ReadOnly = true;
            this.datapeople.Size = new System.Drawing.Size(1172, 333);
            this.datapeople.TabIndex = 0;
            this.datapeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datapeople_CellClick);
            // 
            // aviableBtn
            // 
            this.aviableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aviableBtn.Image = global::Project.Properties.Resources.setstatustoavaiablebtn;
            this.aviableBtn.Location = new System.Drawing.Point(947, 539);
            this.aviableBtn.Name = "aviableBtn";
            this.aviableBtn.Size = new System.Drawing.Size(272, 67);
            this.aviableBtn.TabIndex = 1;
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
            this.backBtn.TabIndex = 36;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // veiw_people
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.bg_people;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.aviableBtn);
            this.Controls.Add(this.datapeople);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "veiw_people";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place(ADMIN)";
            this.Load += new System.EventHandler(this.veiw_people_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datapeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datapeople;
        private System.Windows.Forms.Button aviableBtn;
        private System.Windows.Forms.Button backBtn;
    }
}
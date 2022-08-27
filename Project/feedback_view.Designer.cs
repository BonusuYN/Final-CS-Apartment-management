namespace Project
{
    partial class feedback_view
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feedback_view));
            this.dataFeedback = new System.Windows.Forms.DataGridView();
            this.roomtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.feedbacksubtxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.feedbackinfotxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.statustxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.editstatusBtn = new System.Windows.Forms.Button();
            this.howtotxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFeedback
            // 
            this.dataFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFeedback.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFeedback.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFeedback.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFeedback.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataFeedback.Location = new System.Drawing.Point(545, 154);
            this.dataFeedback.Name = "dataFeedback";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFeedback.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataFeedback.RowHeadersVisible = false;
            this.dataFeedback.Size = new System.Drawing.Size(693, 467);
            this.dataFeedback.TabIndex = 1;
            this.dataFeedback.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFeedback_CellClick);
            // 
            // roomtxt
            // 
            this.roomtxt.Location = new System.Drawing.Point(132, 142);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.ReadOnly = true;
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
            this.roomtxt.TabIndex = 16;
            // 
            // feedbacksubtxt
            // 
            this.feedbacksubtxt.Location = new System.Drawing.Point(132, 223);
            this.feedbacksubtxt.Name = "feedbacksubtxt";
            this.feedbacksubtxt.ReadOnly = true;
            this.feedbacksubtxt.Size = new System.Drawing.Size(346, 40);
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
            this.feedbacksubtxt.TabIndex = 17;
            // 
            // feedbackinfotxt
            // 
            this.feedbackinfotxt.Location = new System.Drawing.Point(132, 297);
            this.feedbackinfotxt.Multiline = true;
            this.feedbackinfotxt.Name = "feedbackinfotxt";
            this.feedbackinfotxt.ReadOnly = true;
            this.feedbackinfotxt.Size = new System.Drawing.Size(346, 140);
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
            this.feedbackinfotxt.TabIndex = 18;
            // 
            // statustxt
            // 
            this.statustxt.Location = new System.Drawing.Point(132, 473);
            this.statustxt.Name = "statustxt";
            this.statustxt.ReadOnly = true;
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
            this.statustxt.TabIndex = 19;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Image = global::Project.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(12, 625);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 44);
            this.backBtn.TabIndex = 30;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // editstatusBtn
            // 
            this.editstatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editstatusBtn.Image = global::Project.Properties.Resources.editstatusbtn;
            this.editstatusBtn.Location = new System.Drawing.Point(180, 597);
            this.editstatusBtn.Name = "editstatusBtn";
            this.editstatusBtn.Size = new System.Drawing.Size(250, 60);
            this.editstatusBtn.TabIndex = 31;
            this.editstatusBtn.UseVisualStyleBackColor = true;
            this.editstatusBtn.Click += new System.EventHandler(this.editstatusBtn_Click);
            // 
            // howtotxt
            // 
            this.howtotxt.Location = new System.Drawing.Point(132, 537);
            this.howtotxt.Name = "howtotxt";
            this.howtotxt.Size = new System.Drawing.Size(346, 40);
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
            this.howtotxt.TabIndex = 32;
            // 
            // feedback_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.feedbackBg;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.howtotxt);
            this.Controls.Add(this.editstatusBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.feedbackinfotxt);
            this.Controls.Add(this.feedbacksubtxt);
            this.Controls.Add(this.roomtxt);
            this.Controls.Add(this.dataFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "feedback_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Place";
            this.Load += new System.EventHandler(this.feedback_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFeedback;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox roomtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox feedbacksubtxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox feedbackinfotxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox statustxt;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button editstatusBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox howtotxt;
    }
}
namespace AttendanceSystem
{
    partial class ScheduleForm
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
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.cpnlSearch = new GUI.TruniControls.CustomPanel();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customTextBox3 = new GUI.TruniControls.CustomTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ccbxToday = new GUI.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbxWeek = new GUI.CustomButton();
            this.customPanel1.SuspendLayout();
            this.cpnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.ccbxWeek);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.ccbxToday);
            this.customPanel1.Controls.Add(this.dataGridView1);
            this.customPanel1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(23, 78);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1030, 572);
            this.customPanel1.TabIndex = 0;
            // 
            // cpnlSearch
            // 
            this.cpnlSearch.BackColor = System.Drawing.SystemColors.Control;
            this.cpnlSearch.BorderColor = System.Drawing.Color.Black;
            this.cpnlSearch.BorderRadius = 0;
            this.cpnlSearch.BorderSize = 0;
            this.cpnlSearch.Controls.Add(this.lblSchoolName);
            this.cpnlSearch.Controls.Add(this.pictureBox3);
            this.cpnlSearch.Controls.Add(this.customTextBox3);
            this.cpnlSearch.ForeColor = System.Drawing.Color.Black;
            this.cpnlSearch.GradientAngle = 90F;
            this.cpnlSearch.GradientBottomColor = System.Drawing.SystemColors.Control;
            this.cpnlSearch.GradientTopColor = System.Drawing.SystemColors.Control;
            this.cpnlSearch.Location = new System.Drawing.Point(12, 13);
            this.cpnlSearch.Name = "cpnlSearch";
            this.cpnlSearch.Size = new System.Drawing.Size(1044, 52);
            this.cpnlSearch.TabIndex = 1;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(12, 6);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(231, 39);
            this.lblSchoolName.TabIndex = 7;
            this.lblSchoolName.Text = "Thời khóa biểu";
            this.lblSchoolName.Click += new System.EventHandler(this.lblSchoolName_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI.Properties.Resources.icons8_search_500;
            this.pictureBox3.Location = new System.Drawing.Point(789, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.Color.White;
            this.customTextBox3.BorderColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderRadius = 8;
            this.customTextBox3.BorderSize = 1;
            this.customTextBox3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.Black;
            this.customTextBox3.Location = new System.Drawing.Point(778, 6);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(40, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "Tìm kiếm";
            this.customTextBox3.Size = new System.Drawing.Size(263, 36);
            this.customTextBox3.TabIndex = 6;
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(986, 469);
            this.dataGridView1.TabIndex = 0;
            // 
            // ccbxToday
            // 
            this.ccbxToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.ccbxToday.BorderColor = System.Drawing.Color.White;
            this.ccbxToday.BorderRadius = 8;
            this.ccbxToday.BorderSize = 0;
            this.ccbxToday.FlatAppearance.BorderSize = 0;
            this.ccbxToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccbxToday.ForeColor = System.Drawing.Color.Black;
            this.ccbxToday.Location = new System.Drawing.Point(122, 27);
            this.ccbxToday.Name = "ccbxToday";
            this.ccbxToday.Size = new System.Drawing.Size(150, 40);
            this.ccbxToday.TabIndex = 1;
            this.ccbxToday.Text = "Hôm nay";
            this.ccbxToday.UseVisualStyleBackColor = false;
            this.ccbxToday.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lựa chọn: ";
            // 
            // ccbxWeek
            // 
            this.ccbxWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.ccbxWeek.BorderColor = System.Drawing.Color.White;
            this.ccbxWeek.BorderRadius = 8;
            this.ccbxWeek.BorderSize = 0;
            this.ccbxWeek.FlatAppearance.BorderSize = 0;
            this.ccbxWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccbxWeek.ForeColor = System.Drawing.Color.Black;
            this.ccbxWeek.Location = new System.Drawing.Point(304, 27);
            this.ccbxWeek.Name = "ccbxWeek";
            this.ccbxWeek.Size = new System.Drawing.Size(150, 40);
            this.ccbxWeek.TabIndex = 3;
            this.ccbxWeek.Text = "Tuần";
            this.ccbxWeek.UseVisualStyleBackColor = false;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.cpnlSearch);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.cpnlSearch.ResumeLayout(false);
            this.cpnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.TruniControls.CustomPanel customPanel1;
        private GUI.TruniControls.CustomPanel cpnlSearch;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private GUI.TruniControls.CustomTextBox customTextBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private GUI.CustomButton ccbxToday;
        private GUI.CustomButton ccbxWeek;
    }
}
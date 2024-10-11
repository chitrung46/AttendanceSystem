namespace AttendanceSystem
{
    partial class SchoolForm
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
            this.ccpnlTotal = new GUI.TruniControls.CustomPanel();
            this.btnSchool = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.pnlSchool = new System.Windows.Forms.Panel();
            this.pnlFaculty = new System.Windows.Forms.Panel();
            this.pnlSubject = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customTextBox3 = new GUI.TruniControls.CustomTextBox();
            this.ccpnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ccpnlTotal
            // 
            this.ccpnlTotal.BackColor = System.Drawing.Color.White;
            this.ccpnlTotal.BorderColor = System.Drawing.Color.Black;
            this.ccpnlTotal.BorderRadius = 30;
            this.ccpnlTotal.BorderSize = 0;
            this.ccpnlTotal.Controls.Add(this.pictureBox3);
            this.ccpnlTotal.Controls.Add(this.customTextBox3);
            this.ccpnlTotal.Controls.Add(this.mainPanel);
            this.ccpnlTotal.Controls.Add(this.pnlSubject);
            this.ccpnlTotal.Controls.Add(this.pnlFaculty);
            this.ccpnlTotal.Controls.Add(this.pnlSchool);
            this.ccpnlTotal.Controls.Add(this.btnSubject);
            this.ccpnlTotal.Controls.Add(this.btnFaculty);
            this.ccpnlTotal.Controls.Add(this.btnSchool);
            this.ccpnlTotal.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccpnlTotal.ForeColor = System.Drawing.Color.Black;
            this.ccpnlTotal.GradientAngle = 90F;
            this.ccpnlTotal.GradientBottomColor = System.Drawing.Color.White;
            this.ccpnlTotal.GradientTopColor = System.Drawing.Color.White;
            this.ccpnlTotal.Location = new System.Drawing.Point(18, 18);
            this.ccpnlTotal.Name = "ccpnlTotal";
            this.ccpnlTotal.Size = new System.Drawing.Size(1038, 634);
            this.ccpnlTotal.TabIndex = 1;
            // 
            // btnSchool
            // 
            this.btnSchool.FlatAppearance.BorderSize = 0;
            this.btnSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchool.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchool.Location = new System.Drawing.Point(21, 18);
            this.btnSchool.Name = "btnSchool";
            this.btnSchool.Size = new System.Drawing.Size(113, 47);
            this.btnSchool.TabIndex = 0;
            this.btnSchool.Text = "Trường";
            this.btnSchool.UseVisualStyleBackColor = true;
            this.btnSchool.Click += new System.EventHandler(this.btnSchool_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.FlatAppearance.BorderSize = 0;
            this.btnFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaculty.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaculty.Location = new System.Drawing.Point(133, 18);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(113, 47);
            this.btnFaculty.TabIndex = 1;
            this.btnFaculty.Text = "Khoa";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.Location = new System.Drawing.Point(245, 18);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(113, 47);
            this.btnSubject.TabIndex = 2;
            this.btnSubject.Text = "Môn";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // pnlSchool
            // 
            this.pnlSchool.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlSchool.Location = new System.Drawing.Point(21, 60);
            this.pnlSchool.Name = "pnlSchool";
            this.pnlSchool.Size = new System.Drawing.Size(113, 5);
            this.pnlSchool.TabIndex = 3;
            // 
            // pnlFaculty
            // 
            this.pnlFaculty.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlFaculty.Location = new System.Drawing.Point(133, 60);
            this.pnlFaculty.Name = "pnlFaculty";
            this.pnlFaculty.Size = new System.Drawing.Size(113, 5);
            this.pnlFaculty.TabIndex = 4;
            // 
            // pnlSubject
            // 
            this.pnlSubject.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlSubject.Location = new System.Drawing.Point(245, 60);
            this.pnlSubject.Name = "pnlSubject";
            this.pnlSubject.Size = new System.Drawing.Size(113, 5);
            this.pnlSubject.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(21, 87);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(996, 531);
            this.mainPanel.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = global::GUI.Properties.Resources.icons8_search_500;
            this.pictureBox3.Location = new System.Drawing.Point(769, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.customTextBox3.BorderColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderRadius = 8;
            this.customTextBox3.BorderSize = 1;
            this.customTextBox3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox3.Location = new System.Drawing.Point(758, 24);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(40, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "Tìm kiếm";
            this.customTextBox3.Size = new System.Drawing.Size(259, 36);
            this.customTextBox3.TabIndex = 8;
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // SchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.ccpnlTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SchoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolForm";
            this.ccpnlTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.TruniControls.CustomPanel ccpnlTotal;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel pnlSubject;
        private System.Windows.Forms.Panel pnlFaculty;
        private System.Windows.Forms.Panel pnlSchool;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnSchool;
        private System.Windows.Forms.PictureBox pictureBox3;
        private GUI.TruniControls.CustomTextBox customTextBox3;
    }
}
namespace GUI
{
    partial class GroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            this.ccpnlTotal = new GUI.TruniControls.CustomPanel();
            this.ccpnlSchoolInformation = new GUI.TruniControls.CustomPanel();
            this.dgvGroupInformation = new System.Windows.Forms.DataGridView();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.ccbxMaximumAbsences = new GUI.TruniControls.CustomTextBox();
            this.lblMaximumAbsences = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.ccbxStudentCount = new GUI.TruniControls.CustomTextBox();
            this.ctxtGroupName = new GUI.TruniControls.CustomTextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupInformation = new System.Windows.Forms.Label();
            this.cpnlSearch = new GUI.TruniControls.CustomPanel();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customTextBox3 = new GUI.TruniControls.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton3 = new GUI.TruniControls.CustomButton();
            this.customButton4 = new GUI.TruniControls.CustomButton();
            this.customButton9 = new GUI.TruniControls.CustomButton();
            this.customButton10 = new GUI.TruniControls.CustomButton();
            this.ccpnlTotal.SuspendLayout();
            this.ccpnlSchoolInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupInformation)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.cpnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ccpnlTotal
            // 
            this.ccpnlTotal.BackColor = System.Drawing.Color.White;
            this.ccpnlTotal.BorderColor = System.Drawing.Color.Black;
            this.ccpnlTotal.BorderRadius = 30;
            this.ccpnlTotal.BorderSize = 0;
            this.ccpnlTotal.Controls.Add(this.ccpnlSchoolInformation);
            this.ccpnlTotal.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccpnlTotal.ForeColor = System.Drawing.Color.Black;
            this.ccpnlTotal.GradientAngle = 90F;
            this.ccpnlTotal.GradientBottomColor = System.Drawing.Color.White;
            this.ccpnlTotal.GradientTopColor = System.Drawing.Color.White;
            this.ccpnlTotal.Location = new System.Drawing.Point(18, 71);
            this.ccpnlTotal.Name = "ccpnlTotal";
            this.ccpnlTotal.Size = new System.Drawing.Size(1038, 596);
            this.ccpnlTotal.TabIndex = 0;
            // 
            // ccpnlSchoolInformation
            // 
            this.ccpnlSchoolInformation.BackColor = System.Drawing.Color.White;
            this.ccpnlSchoolInformation.BorderColor = System.Drawing.Color.Black;
            this.ccpnlSchoolInformation.BorderRadius = 30;
            this.ccpnlSchoolInformation.BorderSize = 0;
            this.ccpnlSchoolInformation.Controls.Add(this.panel2);
            this.ccpnlSchoolInformation.Controls.Add(this.dgvGroupInformation);
            this.ccpnlSchoolInformation.Controls.Add(this.customPanel1);
            this.ccpnlSchoolInformation.Controls.Add(this.panel1);
            this.ccpnlSchoolInformation.ForeColor = System.Drawing.Color.Black;
            this.ccpnlSchoolInformation.GradientAngle = 90F;
            this.ccpnlSchoolInformation.GradientBottomColor = System.Drawing.Color.White;
            this.ccpnlSchoolInformation.GradientTopColor = System.Drawing.Color.White;
            this.ccpnlSchoolInformation.Location = new System.Drawing.Point(0, 24);
            this.ccpnlSchoolInformation.Name = "ccpnlSchoolInformation";
            this.ccpnlSchoolInformation.Size = new System.Drawing.Size(1030, 572);
            this.ccpnlSchoolInformation.TabIndex = 1;
            // 
            // dgvGroupInformation
            // 
            this.dgvGroupInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupInformation.Location = new System.Drawing.Point(17, 217);
            this.dgvGroupInformation.Name = "dgvGroupInformation";
            this.dgvGroupInformation.RowHeadersWidth = 51;
            this.dgvGroupInformation.RowTemplate.Height = 24;
            this.dgvGroupInformation.Size = new System.Drawing.Size(1005, 338);
            this.dgvGroupInformation.TabIndex = 1;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.ccbxMaximumAbsences);
            this.customPanel1.Controls.Add(this.lblMaximumAbsences);
            this.customPanel1.Controls.Add(this.lblStudentCount);
            this.customPanel1.Controls.Add(this.ccbxStudentCount);
            this.customPanel1.Controls.Add(this.ctxtGroupName);
            this.customPanel1.Controls.Add(this.lblGroupName);
            this.customPanel1.Controls.Add(this.lblGroupInformation);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(26, -1);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1001, 143);
            this.customPanel1.TabIndex = 0;
            // 
            // ccbxMaximumAbsences
            // 
            this.ccbxMaximumAbsences.BackColor = System.Drawing.SystemColors.Window;
            this.ccbxMaximumAbsences.BorderColor = System.Drawing.Color.Black;
            this.ccbxMaximumAbsences.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.ccbxMaximumAbsences.BorderRadius = 8;
            this.ccbxMaximumAbsences.BorderSize = 1;
            this.ccbxMaximumAbsences.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbxMaximumAbsences.ForeColor = System.Drawing.Color.Black;
            this.ccbxMaximumAbsences.Location = new System.Drawing.Point(538, 97);
            this.ccbxMaximumAbsences.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccbxMaximumAbsences.Multiline = false;
            this.ccbxMaximumAbsences.Name = "ccbxMaximumAbsences";
            this.ccbxMaximumAbsences.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ccbxMaximumAbsences.PasswordChar = false;
            this.ccbxMaximumAbsences.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ccbxMaximumAbsences.PlaceholderText = "";
            this.ccbxMaximumAbsences.Size = new System.Drawing.Size(65, 36);
            this.ccbxMaximumAbsences.TabIndex = 5;
            this.ccbxMaximumAbsences.UnderlinedStyle = false;
            // 
            // lblMaximumAbsences
            // 
            this.lblMaximumAbsences.AutoSize = true;
            this.lblMaximumAbsences.Location = new System.Drawing.Point(335, 106);
            this.lblMaximumAbsences.Name = "lblMaximumAbsences";
            this.lblMaximumAbsences.Size = new System.Drawing.Size(158, 21);
            this.lblMaximumAbsences.TabIndex = 1;
            this.lblMaximumAbsences.Text = "Số buổi vắng tối đa:";
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Location = new System.Drawing.Point(2, 106);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(155, 21);
            this.lblStudentCount.TabIndex = 6;
            this.lblStudentCount.Text = "Số lượng sinh viên: ";
            // 
            // ccbxStudentCount
            // 
            this.ccbxStudentCount.BackColor = System.Drawing.SystemColors.Window;
            this.ccbxStudentCount.BorderColor = System.Drawing.Color.Black;
            this.ccbxStudentCount.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.ccbxStudentCount.BorderRadius = 8;
            this.ccbxStudentCount.BorderSize = 1;
            this.ccbxStudentCount.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbxStudentCount.ForeColor = System.Drawing.Color.Black;
            this.ccbxStudentCount.Location = new System.Drawing.Point(197, 98);
            this.ccbxStudentCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccbxStudentCount.Multiline = false;
            this.ccbxStudentCount.Name = "ccbxStudentCount";
            this.ccbxStudentCount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ccbxStudentCount.PasswordChar = false;
            this.ccbxStudentCount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ccbxStudentCount.PlaceholderText = "";
            this.ccbxStudentCount.Size = new System.Drawing.Size(77, 36);
            this.ccbxStudentCount.TabIndex = 4;
            this.ccbxStudentCount.UnderlinedStyle = false;
            // 
            // ctxtGroupName
            // 
            this.ctxtGroupName.BackColor = System.Drawing.SystemColors.Window;
            this.ctxtGroupName.BorderColor = System.Drawing.Color.Black;
            this.ctxtGroupName.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.ctxtGroupName.BorderRadius = 8;
            this.ctxtGroupName.BorderSize = 1;
            this.ctxtGroupName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtGroupName.ForeColor = System.Drawing.Color.Black;
            this.ctxtGroupName.Location = new System.Drawing.Point(119, 45);
            this.ctxtGroupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctxtGroupName.Multiline = false;
            this.ctxtGroupName.Name = "ctxtGroupName";
            this.ctxtGroupName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctxtGroupName.PasswordChar = false;
            this.ctxtGroupName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctxtGroupName.PlaceholderText = "";
            this.ctxtGroupName.Size = new System.Drawing.Size(484, 36);
            this.ctxtGroupName.TabIndex = 3;
            this.ctxtGroupName.UnderlinedStyle = false;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(2, 53);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(90, 21);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "Tên nhóm:";
            // 
            // lblGroupInformation
            // 
            this.lblGroupInformation.AutoSize = true;
            this.lblGroupInformation.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupInformation.Location = new System.Drawing.Point(3, 0);
            this.lblGroupInformation.Name = "lblGroupInformation";
            this.lblGroupInformation.Size = new System.Drawing.Size(181, 27);
            this.lblGroupInformation.TabIndex = 1;
            this.lblGroupInformation.Text = "Thông tin nhóm";
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
            this.cpnlSearch.TabIndex = 0;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(12, 6);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(467, 39);
            this.lblSchoolName.TabIndex = 7;
            this.lblSchoolName.Text = "Trường Đại học Tôn Đức Thắng";
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
            this.customTextBox3.Load += new System.EventHandler(this.customTextBox3_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(21, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 2);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customButton3);
            this.panel2.Controls.Add(this.customButton4);
            this.panel2.Controls.Add(this.customButton9);
            this.panel2.Controls.Add(this.customButton10);
            this.panel2.Location = new System.Drawing.Point(16, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 47);
            this.panel2.TabIndex = 12;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.customButton3.BorderColor = System.Drawing.Color.Black;
            this.customButton3.BorderRadius = 20;
            this.customButton3.BorderSize = 0;
            this.customButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Image = ((System.Drawing.Image)(resources.GetObject("customButton3.Image")));
            this.customButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.Location = new System.Drawing.Point(321, 1);
            this.customButton3.Name = "customButton3";
            this.customButton3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton3.Size = new System.Drawing.Size(97, 45);
            this.customButton3.TabIndex = 8;
            this.customButton3.Text = "Chọn";
            this.customButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(29)))));
            this.customButton4.BorderColor = System.Drawing.Color.Black;
            this.customButton4.BorderRadius = 20;
            this.customButton4.BorderSize = 0;
            this.customButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Image = ((System.Drawing.Image)(resources.GetObject("customButton4.Image")));
            this.customButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.Location = new System.Drawing.Point(214, 1);
            this.customButton4.Name = "customButton4";
            this.customButton4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customButton4.Size = new System.Drawing.Size(97, 45);
            this.customButton4.TabIndex = 7;
            this.customButton4.Text = "Sửa";
            this.customButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton9
            // 
            this.customButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.customButton9.BorderColor = System.Drawing.Color.Black;
            this.customButton9.BorderRadius = 20;
            this.customButton9.BorderSize = 0;
            this.customButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton9.FlatAppearance.BorderSize = 0;
            this.customButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton9.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton9.ForeColor = System.Drawing.Color.White;
            this.customButton9.Image = ((System.Drawing.Image)(resources.GetObject("customButton9.Image")));
            this.customButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton9.Location = new System.Drawing.Point(108, 1);
            this.customButton9.Name = "customButton9";
            this.customButton9.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.customButton9.Size = new System.Drawing.Size(97, 45);
            this.customButton9.TabIndex = 6;
            this.customButton9.Text = "Xóa";
            this.customButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton9.UseVisualStyleBackColor = false;
            // 
            // customButton10
            // 
            this.customButton10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customButton10.BackColor = System.Drawing.Color.DarkGreen;
            this.customButton10.BorderColor = System.Drawing.Color.Black;
            this.customButton10.BorderRadius = 20;
            this.customButton10.BorderSize = 0;
            this.customButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton10.FlatAppearance.BorderSize = 0;
            this.customButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton10.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton10.ForeColor = System.Drawing.Color.White;
            this.customButton10.Image = ((System.Drawing.Image)(resources.GetObject("customButton10.Image")));
            this.customButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton10.Location = new System.Drawing.Point(1, 1);
            this.customButton10.Name = "customButton10";
            this.customButton10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton10.Size = new System.Drawing.Size(97, 45);
            this.customButton10.TabIndex = 9;
            this.customButton10.Text = "Thêm";
            this.customButton10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton10.UseVisualStyleBackColor = false;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.ccpnlTotal);
            this.Controls.Add(this.cpnlSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupForm";
            this.ccpnlTotal.ResumeLayout(false);
            this.ccpnlSchoolInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupInformation)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.cpnlSearch.ResumeLayout(false);
            this.cpnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TruniControls.CustomPanel ccpnlTotal;
        private TruniControls.CustomPanel cpnlSearch;
        private TruniControls.CustomPanel ccpnlSchoolInformation;
        private System.Windows.Forms.PictureBox pictureBox3;
        private TruniControls.CustomTextBox customTextBox3;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Panel panel1;
        private TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label lblGroupInformation;
        private System.Windows.Forms.Label lblGroupName;
        private TruniControls.CustomTextBox ctxtGroupName;
        private System.Windows.Forms.Label lblStudentCount;
        private TruniControls.CustomTextBox ccbxMaximumAbsences;
        private TruniControls.CustomTextBox ccbxStudentCount;
        private System.Windows.Forms.Label lblMaximumAbsences;
        private System.Windows.Forms.DataGridView dgvGroupInformation;
        private System.Windows.Forms.Panel panel2;
        private TruniControls.CustomButton customButton3;
        private TruniControls.CustomButton customButton4;
        private TruniControls.CustomButton customButton9;
        private TruniControls.CustomButton customButton10;
    }
}
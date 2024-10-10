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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ccpnlSchoolInformation = new GUI.TruniControls.CustomPanel();
            this.dgvGroupInformation = new System.Windows.Forms.DataGridView();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton6 = new GUI.CustomButton();
            this.customButton7 = new GUI.CustomButton();
            this.customButton8 = new GUI.CustomButton();
            this.customButton5 = new GUI.CustomButton();
            this.lblMaximumAbsences = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.ccbxMaximumAbsences = new GUI.TruniControls.CustomTextBox();
            this.ccbxStudentCount = new GUI.TruniControls.CustomTextBox();
            this.ctxtGroupName = new GUI.TruniControls.CustomTextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupInformation = new System.Windows.Forms.Label();
            this.cpnlSearch = new GUI.TruniControls.CustomPanel();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customTextBox3 = new GUI.TruniControls.CustomTextBox();
            this.ccpnlTotal.SuspendLayout();
            this.ccpnlSchoolInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupInformation)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cpnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ccpnlTotal
            // 
            this.ccpnlTotal.BackColor = System.Drawing.Color.White;
            this.ccpnlTotal.BorderRadius = 30;
            this.ccpnlTotal.Controls.Add(this.panel1);
            this.ccpnlTotal.Controls.Add(this.panel2);
            this.ccpnlTotal.Controls.Add(this.ccpnlSchoolInformation);
            this.ccpnlTotal.Controls.Add(this.cpnlSearch);
            this.ccpnlTotal.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccpnlTotal.ForeColor = System.Drawing.Color.Black;
            this.ccpnlTotal.GradientAngle = 90F;
            this.ccpnlTotal.GradientBottomColor = System.Drawing.Color.White;
            this.ccpnlTotal.GradientTopColor = System.Drawing.Color.White;
            this.ccpnlTotal.Location = new System.Drawing.Point(23, 24);
            this.ccpnlTotal.Name = "ccpnlTotal";
            this.ccpnlTotal.Size = new System.Drawing.Size(1027, 643);
            this.ccpnlTotal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(21, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 3);
            this.panel1.TabIndex = 9;
            // 
            // ccpnlSchoolInformation
            // 
            this.ccpnlSchoolInformation.BackColor = System.Drawing.Color.White;
            this.ccpnlSchoolInformation.BorderRadius = 30;
            this.ccpnlSchoolInformation.Controls.Add(this.dgvGroupInformation);
            this.ccpnlSchoolInformation.Controls.Add(this.customPanel1);
            this.ccpnlSchoolInformation.ForeColor = System.Drawing.Color.Black;
            this.ccpnlSchoolInformation.GradientAngle = 90F;
            this.ccpnlSchoolInformation.GradientBottomColor = System.Drawing.Color.White;
            this.ccpnlSchoolInformation.GradientTopColor = System.Drawing.Color.White;
            this.ccpnlSchoolInformation.Location = new System.Drawing.Point(19, 88);
            this.ccpnlSchoolInformation.Name = "ccpnlSchoolInformation";
            this.ccpnlSchoolInformation.Size = new System.Drawing.Size(984, 546);
            this.ccpnlSchoolInformation.TabIndex = 1;
            // 
            // dgvGroupInformation
            // 
            this.dgvGroupInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupInformation.Location = new System.Drawing.Point(12, 214);
            this.dgvGroupInformation.Name = "dgvGroupInformation";
            this.dgvGroupInformation.RowHeadersWidth = 51;
            this.dgvGroupInformation.RowTemplate.Height = 24;
            this.dgvGroupInformation.Size = new System.Drawing.Size(965, 326);
            this.dgvGroupInformation.TabIndex = 1;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
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
            this.customPanel1.Location = new System.Drawing.Point(10, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(966, 146);
            this.customPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customButton6);
            this.panel2.Controls.Add(this.customButton7);
            this.panel2.Controls.Add(this.customButton8);
            this.panel2.Controls.Add(this.customButton5);
            this.panel2.Location = new System.Drawing.Point(-2, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 56);
            this.panel2.TabIndex = 12;
            // 
            // customButton6
            // 
            this.customButton6.BackColor = System.Drawing.Color.RoyalBlue;
            this.customButton6.BorderColor = System.Drawing.Color.Black;
            this.customButton6.BorderRadius = 20;
            this.customButton6.BorderSize = 0;
            this.customButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton6.FlatAppearance.BorderSize = 0;
            this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton6.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton6.ForeColor = System.Drawing.Color.White;
            this.customButton6.Image = ((System.Drawing.Image)(resources.GetObject("customButton6.Image")));
            this.customButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton6.Location = new System.Drawing.Point(344, 3);
            this.customButton6.Name = "customButton6";
            this.customButton6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton6.Size = new System.Drawing.Size(97, 45);
            this.customButton6.TabIndex = 8;
            this.customButton6.Text = "Chọn";
            this.customButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton6.UseVisualStyleBackColor = false;
            // 
            // customButton7
            // 
            this.customButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(29)))));
            this.customButton7.BorderColor = System.Drawing.Color.Black;
            this.customButton7.BorderRadius = 20;
            this.customButton7.BorderSize = 0;
            this.customButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton7.FlatAppearance.BorderSize = 0;
            this.customButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton7.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton7.ForeColor = System.Drawing.Color.White;
            this.customButton7.Image = ((System.Drawing.Image)(resources.GetObject("customButton7.Image")));
            this.customButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton7.Location = new System.Drawing.Point(241, 3);
            this.customButton7.Name = "customButton7";
            this.customButton7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customButton7.Size = new System.Drawing.Size(97, 45);
            this.customButton7.TabIndex = 7;
            this.customButton7.Text = "Sửa";
            this.customButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton7.UseVisualStyleBackColor = false;
            // 
            // customButton8
            // 
            this.customButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.customButton8.BorderColor = System.Drawing.Color.Black;
            this.customButton8.BorderRadius = 20;
            this.customButton8.BorderSize = 0;
            this.customButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton8.FlatAppearance.BorderSize = 0;
            this.customButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton8.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton8.ForeColor = System.Drawing.Color.White;
            this.customButton8.Image = ((System.Drawing.Image)(resources.GetObject("customButton8.Image")));
            this.customButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton8.Location = new System.Drawing.Point(138, 3);
            this.customButton8.Name = "customButton8";
            this.customButton8.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.customButton8.Size = new System.Drawing.Size(97, 45);
            this.customButton8.TabIndex = 6;
            this.customButton8.Text = "Xóa";
            this.customButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton8.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            this.customButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customButton5.BackColor = System.Drawing.Color.DarkGreen;
            this.customButton5.BorderColor = System.Drawing.Color.Black;
            this.customButton5.BorderRadius = 20;
            this.customButton5.BorderSize = 0;
            this.customButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Image = ((System.Drawing.Image)(resources.GetObject("customButton5.Image")));
            this.customButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton5.Location = new System.Drawing.Point(33, 3);
            this.customButton5.Name = "customButton5";
            this.customButton5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton5.Size = new System.Drawing.Size(97, 45);
            this.customButton5.TabIndex = 9;
            this.customButton5.Text = "Thêm";
            this.customButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // lblMaximumAbsences
            // 
            this.lblMaximumAbsences.AutoSize = true;
            this.lblMaximumAbsences.Location = new System.Drawing.Point(335, 106);
            this.lblMaximumAbsences.Name = "lblMaximumAbsences";
            this.lblMaximumAbsences.Size = new System.Drawing.Size(178, 21);
            this.lblMaximumAbsences.TabIndex = 1;
            this.lblMaximumAbsences.Text = "Số buổi vắng tối đa:";
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Location = new System.Drawing.Point(2, 106);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(175, 21);
            this.lblStudentCount.TabIndex = 6;
            this.lblStudentCount.Text = "Số lượng sinh viên: ";
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
            this.ccbxMaximumAbsences.Texts = "";
            this.ccbxMaximumAbsences.UnderlinedStyle = false;
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
            this.ccbxStudentCount.Texts = "";
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
            this.ctxtGroupName.Texts = "";
            this.ctxtGroupName.UnderlinedStyle = false;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(2, 53);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(99, 21);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "Tên nhóm:";
            // 
            // lblGroupInformation
            // 
            this.lblGroupInformation.AutoSize = true;
            this.lblGroupInformation.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupInformation.Location = new System.Drawing.Point(-5, 0);
            this.lblGroupInformation.Name = "lblGroupInformation";
            this.lblGroupInformation.Size = new System.Drawing.Size(219, 32);
            this.lblGroupInformation.TabIndex = 1;
            this.lblGroupInformation.Text = "Thông tin nhóm";
            // 
            // cpnlSearch
            // 
            this.cpnlSearch.BackColor = System.Drawing.Color.White;
            this.cpnlSearch.BorderRadius = 30;
            this.cpnlSearch.Controls.Add(this.lblSchoolName);
            this.cpnlSearch.Controls.Add(this.pictureBox3);
            this.cpnlSearch.Controls.Add(this.customTextBox3);
            this.cpnlSearch.ForeColor = System.Drawing.Color.Black;
            this.cpnlSearch.GradientAngle = 90F;
            this.cpnlSearch.GradientBottomColor = System.Drawing.Color.White;
            this.cpnlSearch.GradientTopColor = System.Drawing.Color.White;
            this.cpnlSearch.Location = new System.Drawing.Point(19, 21);
            this.cpnlSearch.Name = "cpnlSearch";
            this.cpnlSearch.Size = new System.Drawing.Size(984, 52);
            this.cpnlSearch.TabIndex = 0;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(3, 6);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(232, 41);
            this.lblSchoolName.TabIndex = 7;
            this.lblSchoolName.Text = "Trường TDTU";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = global::GUI.Properties.Resources.icons8_search_500;
            this.pictureBox3.Location = new System.Drawing.Point(724, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.customTextBox3.BorderColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderRadius = 8;
            this.customTextBox3.BorderSize = 1;
            this.customTextBox3.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.customTextBox3.ForeColor = System.Drawing.Color.Black;
            this.customTextBox3.Location = new System.Drawing.Point(713, 7);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(40, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "Tìm kiếm";
            this.customTextBox3.Size = new System.Drawing.Size(263, 35);
            this.customTextBox3.TabIndex = 6;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            this.customTextBox3.Load += new System.EventHandler(this.customTextBox3_Load);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.ccpnlTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupForm";
            this.ccpnlTotal.ResumeLayout(false);
            this.ccpnlSchoolInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupInformation)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.cpnlSearch.ResumeLayout(false);
            this.cpnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private CustomButton customButton6;
        private CustomButton customButton7;
        private CustomButton customButton8;
        private CustomButton customButton5;
        private System.Windows.Forms.DataGridView dgvGroupInformation;
    }
}
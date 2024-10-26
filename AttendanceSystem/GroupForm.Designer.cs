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
            this.lblGroupInformation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton3 = new GUI.CustomButton();
            this.customButton4 = new GUI.CustomButton();
            this.customButton9 = new GUI.CustomButton();
            this.btnAdd = new GUI.CustomButton();
            this.dgvGroupInformation = new System.Windows.Forms.DataGridView();
            this.cpnlSearch = new GUI.TruniControls.CustomPanel();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customTextBox3 = new GUI.TruniControls.CustomTextBox();
            this.ccpnlTotal.SuspendLayout();
            this.ccpnlSchoolInformation.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupInformation)).BeginInit();
            this.cpnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ccpnlTotal
            // 
            this.ccpnlTotal.BackColor = System.Drawing.Color.White;
            this.ccpnlTotal.BorderColor = System.Drawing.Color.Black;
            this.ccpnlTotal.BorderRadius = 30;
            this.ccpnlTotal.BorderSize = 0;
            this.ccpnlTotal.Controls.Add(this.ccpnlSchoolInformation);
            this.ccpnlTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ccpnlSchoolInformation.Controls.Add(this.lblGroupInformation);
            this.ccpnlSchoolInformation.Controls.Add(this.panel2);
            this.ccpnlSchoolInformation.Controls.Add(this.dgvGroupInformation);
            this.ccpnlSchoolInformation.ForeColor = System.Drawing.Color.Black;
            this.ccpnlSchoolInformation.GradientAngle = 90F;
            this.ccpnlSchoolInformation.GradientBottomColor = System.Drawing.Color.White;
            this.ccpnlSchoolInformation.GradientTopColor = System.Drawing.Color.White;
            this.ccpnlSchoolInformation.Location = new System.Drawing.Point(0, 24);
            this.ccpnlSchoolInformation.Name = "ccpnlSchoolInformation";
            this.ccpnlSchoolInformation.Size = new System.Drawing.Size(1030, 572);
            this.ccpnlSchoolInformation.TabIndex = 1;
            // 
            // lblGroupInformation
            // 
            this.lblGroupInformation.AutoSize = true;
            this.lblGroupInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupInformation.Location = new System.Drawing.Point(12, 0);
            this.lblGroupInformation.Name = "lblGroupInformation";
            this.lblGroupInformation.Size = new System.Drawing.Size(162, 25);
            this.lblGroupInformation.TabIndex = 1;
            this.lblGroupInformation.Text = "Thông tin nhóm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customButton3);
            this.panel2.Controls.Add(this.customButton4);
            this.panel2.Controls.Add(this.customButton9);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(17, 51);
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
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.customButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.customButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(97, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvGroupInformation
            // 
            this.dgvGroupInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupInformation.Location = new System.Drawing.Point(17, 107);
            this.dgvGroupInformation.Name = "dgvGroupInformation";
            this.dgvGroupInformation.RowHeadersWidth = 51;
            this.dgvGroupInformation.RowTemplate.Height = 24;
            this.dgvGroupInformation.Size = new System.Drawing.Size(1005, 448);
            this.dgvGroupInformation.TabIndex = 1;
            this.dgvGroupInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupInformation_CellContentClick);
            this.dgvGroupInformation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupInformation_CellDoubleClick);
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
            this.lblSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(12, 6);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(436, 32);
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
            this.customTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.Black;
            this.customTextBox3.Location = new System.Drawing.Point(778, 6);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(40, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "Tìm kiếm";
            this.customTextBox3.Size = new System.Drawing.Size(263, 33);
            this.customTextBox3.TabIndex = 6;
            this.customTextBox3.UnderlinedStyle = false;
            this.customTextBox3.Load += new System.EventHandler(this.customTextBox3_Load);
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
            this.ccpnlSchoolInformation.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupInformation)).EndInit();
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
        private System.Windows.Forms.Label lblGroupInformation;
        private System.Windows.Forms.DataGridView dgvGroupInformation;
        private System.Windows.Forms.Panel panel2;
        private CustomButton customButton3;
        private CustomButton customButton4;
        private CustomButton customButton9;
        private CustomButton btnAdd;
    }
}
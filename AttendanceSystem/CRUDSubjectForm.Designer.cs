namespace GUI
{
    partial class CRUDSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDSubjectForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.subjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblGroupInformation = new System.Windows.Forms.Label();
            this.cmbFacultyName = new System.Windows.Forms.ComboBox();
            this.cmbSchoolName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new GUI.TruniControls.CustomButton();
            this.btnSave = new GUI.TruniControls.CustomButton();
            this.btnUpdate = new GUI.TruniControls.CustomButton();
            this.btnDelete = new GUI.TruniControls.CustomButton();
            this.btnAdd = new GUI.TruniControls.CustomButton();
            this.txtSubjectName = new GUI.TruniControls.CustomTextBox();
            this.customTextBox1 = new GUI.TruniControls.CustomTextBox();
            this.customComboBox1 = new GUI.TruniControls.CustomComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(7, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 47);
            this.panel2.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên Môn:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(11, 114);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(85, 18);
            this.lblFaculty.TabIndex = 35;
            this.lblFaculty.Text = "Tên Khoa:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(9, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 2);
            this.panel1.TabIndex = 34;
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.AllowUserToResizeColumns = false;
            this.dgvSubject.AllowUserToResizeRows = false;
            this.dgvSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubject.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubject.ColumnHeadersHeight = 30;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.subjectId,
            this.facultyId,
            this.schoolId,
            this.subjectName,
            this.facultyName,
            this.schoolName});
            this.dgvSubject.Location = new System.Drawing.Point(8, 221);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.RowHeadersVisible = false;
            this.dgvSubject.RowHeadersWidth = 51;
            this.dgvSubject.RowTemplate.Height = 24;
            this.dgvSubject.Size = new System.Drawing.Size(985, 299);
            this.dgvSubject.TabIndex = 33;
            this.dgvSubject.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellLeave);
            this.dgvSubject.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubject_CellMouseClick);
            this.dgvSubject.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSubject_CurrentCellDirtyStateChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.checkBox.HeaderText = "";
            this.checkBox.MinimumWidth = 6;
            this.checkBox.Name = "checkBox";
            this.checkBox.ReadOnly = true;
            this.checkBox.Width = 30;
            // 
            // subjectId
            // 
            this.subjectId.HeaderText = "Mã môn";
            this.subjectId.MinimumWidth = 6;
            this.subjectId.Name = "subjectId";
            this.subjectId.ReadOnly = true;
            this.subjectId.Visible = false;
            // 
            // facultyId
            // 
            this.facultyId.HeaderText = "Mã khoa";
            this.facultyId.MinimumWidth = 6;
            this.facultyId.Name = "facultyId";
            this.facultyId.ReadOnly = true;
            this.facultyId.Visible = false;
            // 
            // schoolId
            // 
            this.schoolId.HeaderText = "Mã trường";
            this.schoolId.MinimumWidth = 6;
            this.schoolId.Name = "schoolId";
            this.schoolId.ReadOnly = true;
            this.schoolId.Visible = false;
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "Tên Môn";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            // 
            // facultyName
            // 
            this.facultyName.HeaderText = "Tên Khoa";
            this.facultyName.MinimumWidth = 6;
            this.facultyName.Name = "facultyName";
            this.facultyName.ReadOnly = true;
            // 
            // schoolName
            // 
            this.schoolName.HeaderText = "Tên Trường";
            this.schoolName.MinimumWidth = 6;
            this.schoolName.Name = "schoolName";
            this.schoolName.ReadOnly = true;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(11, 63);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(99, 18);
            this.lblSchool.TabIndex = 31;
            this.lblSchool.Text = "Tên Trường:";
            // 
            // lblGroupInformation
            // 
            this.lblGroupInformation.AutoSize = true;
            this.lblGroupInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupInformation.Location = new System.Drawing.Point(4, 10);
            this.lblGroupInformation.Name = "lblGroupInformation";
            this.lblGroupInformation.Size = new System.Drawing.Size(151, 25);
            this.lblGroupInformation.TabIndex = 30;
            this.lblGroupInformation.Text = "Thông tin Môn";
            // 
            // cmbFacultyName
            // 
            this.cmbFacultyName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacultyName.FormattingEnabled = true;
            this.cmbFacultyName.Location = new System.Drawing.Point(117, 108);
            this.cmbFacultyName.Name = "cmbFacultyName";
            this.cmbFacultyName.Size = new System.Drawing.Size(392, 29);
            this.cmbFacultyName.TabIndex = 42;
            // 
            // cmbSchoolName
            // 
            this.cmbSchoolName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchoolName.FormattingEnabled = true;
            this.cmbSchoolName.Location = new System.Drawing.Point(116, 58);
            this.cmbSchoolName.Name = "cmbSchoolName";
            this.cmbSchoolName.Size = new System.Drawing.Size(393, 29);
            this.cmbSchoolName.TabIndex = 43;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(887, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(97, 45);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(765, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(97, 45);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(29)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(214, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(97, 45);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(108, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(97, 45);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubjectName.BorderColor = System.Drawing.Color.Black;
            this.txtSubjectName.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtSubjectName.BorderRadius = 8;
            this.txtSubjectName.BorderSize = 1;
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.ForeColor = System.Drawing.Color.Black;
            this.txtSubjectName.Location = new System.Drawing.Point(638, 108);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectName.Multiline = false;
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSubjectName.PasswordChar = false;
            this.txtSubjectName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSubjectName.PlaceholderText = "";
            this.txtSubjectName.ReadOnly = false;
            this.txtSubjectName.Size = new System.Drawing.Size(346, 33);
            this.txtSubjectName.TabIndex = 37;
            this.txtSubjectName.UnderlinedStyle = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.Black;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.customTextBox1.BorderRadius = 8;
            this.customTextBox1.BorderSize = 1;
            this.customTextBox1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.Black;
            this.customTextBox1.Location = new System.Drawing.Point(638, 108);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.ReadOnly = false;
            this.customTextBox1.Size = new System.Drawing.Size(346, 36);
            this.customTextBox1.TabIndex = 37;
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.BorderRadius = 10;
            this.customComboBox1.BorderSize = 1;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.customComboBox1.Location = new System.Drawing.Point(115, 60);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.customComboBox1.Size = new System.Drawing.Size(484, 30);
            this.customComboBox1.TabIndex = 36;
            this.customComboBox1.Texts = "";
            // 
            // CRUDSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 531);
            this.Controls.Add(this.cmbSchoolName);
            this.Controls.Add(this.cmbFacultyName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblGroupInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDSubjectForm";
            this.Text = "CRUDSubjectForm";
            this.Click += new System.EventHandler(this.CRUDSubjectForm_Click);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private TruniControls.CustomButton btnUpdate;
        private TruniControls.CustomButton btnDelete;
        private TruniControls.CustomButton btnAdd;
        private System.Windows.Forms.Label label1;
        private TruniControls.CustomTextBox txtSubjectName;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblGroupInformation;
        private TruniControls.CustomButton btnCancel;
        private TruniControls.CustomButton btnSave;
        private TruniControls.CustomTextBox customTextBox1;
        private TruniControls.CustomComboBox customComboBox1;
        private System.Windows.Forms.ComboBox cmbFacultyName;
        private System.Windows.Forms.ComboBox cmbSchoolName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolName;
    }
}
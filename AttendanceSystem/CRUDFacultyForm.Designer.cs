namespace GUI
{
    partial class CRUDFacultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDFacultyForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new GUI.TruniControls.CustomButton();
            this.btnDelete = new GUI.TruniControls.CustomButton();
            this.btnAdd = new GUI.TruniControls.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.facultyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblGroupInformation = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.cmbSchoolName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new GUI.TruniControls.CustomButton();
            this.btnSave = new GUI.TruniControls.CustomButton();
            this.txtFaculty = new GUI.TruniControls.CustomTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
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
            this.panel2.TabIndex = 19;
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
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(218, 1);
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
            this.btnDelete.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GUI.Properties.Resources.icons8_delete_20__1_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(109, 1);
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
            this.btnAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::GUI.Properties.Resources.icons8_plus_20__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 1);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(9, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 2);
            this.panel1.TabIndex = 24;
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AllowUserToDeleteRows = false;
            this.dgvFaculty.AllowUserToResizeColumns = false;
            this.dgvFaculty.AllowUserToResizeRows = false;
            this.dgvFaculty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFaculty.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaculty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFaculty.ColumnHeadersHeight = 30;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.facultyId,
            this.schoolId,
            this.facultyName,
            this.schoolName});
            this.dgvFaculty.Location = new System.Drawing.Point(8, 221);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.RowHeadersVisible = false;
            this.dgvFaculty.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFaculty.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.Size = new System.Drawing.Size(985, 299);
            this.dgvFaculty.TabIndex = 23;
            this.dgvFaculty.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellLeave);
            this.dgvFaculty.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFaculty_CellMouseClick);
            this.dgvFaculty.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvFaculty_CurrentCellDirtyStateChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.checkBox.FillWeight = 9.625667F;
            this.checkBox.HeaderText = "";
            this.checkBox.MinimumWidth = 6;
            this.checkBox.Name = "checkBox";
            this.checkBox.ReadOnly = true;
            this.checkBox.Width = 30;
            // 
            // facultyId
            // 
            this.facultyId.HeaderText = "Mã Khoa";
            this.facultyId.MinimumWidth = 6;
            this.facultyId.Name = "facultyId";
            this.facultyId.ReadOnly = true;
            this.facultyId.Visible = false;
            // 
            // schoolId
            // 
            this.schoolId.HeaderText = "Mã Trường";
            this.schoolId.MinimumWidth = 6;
            this.schoolId.Name = "schoolId";
            this.schoolId.ReadOnly = true;
            this.schoolId.Visible = false;
            // 
            // facultyName
            // 
            this.facultyName.FillWeight = 145.1871F;
            this.facultyName.HeaderText = "Tên Khoa";
            this.facultyName.MinimumWidth = 6;
            this.facultyName.Name = "facultyName";
            this.facultyName.ReadOnly = true;
            // 
            // schoolName
            // 
            this.schoolName.FillWeight = 145.1871F;
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
            this.lblSchool.TabIndex = 21;
            this.lblSchool.Text = "Tên Trường:";
            // 
            // lblGroupInformation
            // 
            this.lblGroupInformation.AutoSize = true;
            this.lblGroupInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupInformation.Location = new System.Drawing.Point(4, 10);
            this.lblGroupInformation.Name = "lblGroupInformation";
            this.lblGroupInformation.Size = new System.Drawing.Size(160, 25);
            this.lblGroupInformation.TabIndex = 20;
            this.lblGroupInformation.Text = "Thông tin Khoa";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(11, 114);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(85, 18);
            this.lblFaculty.TabIndex = 25;
            this.lblFaculty.Text = "Tên Khoa:";
            // 
            // cmbSchoolName
            // 
            this.cmbSchoolName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchoolName.FormattingEnabled = true;
            this.cmbSchoolName.Location = new System.Drawing.Point(116, 59);
            this.cmbSchoolName.Name = "cmbSchoolName";
            this.cmbSchoolName.Size = new System.Drawing.Size(384, 29);
            this.cmbSchoolName.TabIndex = 30;
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
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(887, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(97, 45);
            this.btnCancel.TabIndex = 28;
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
            this.btnSave.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(765, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(97, 45);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFaculty
            // 
            this.txtFaculty.BackColor = System.Drawing.SystemColors.Window;
            this.txtFaculty.BorderColor = System.Drawing.Color.Black;
            this.txtFaculty.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtFaculty.BorderRadius = 8;
            this.txtFaculty.BorderSize = 1;
            this.txtFaculty.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaculty.ForeColor = System.Drawing.Color.Black;
            this.txtFaculty.Location = new System.Drawing.Point(115, 105);
            this.txtFaculty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFaculty.Multiline = false;
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFaculty.PasswordChar = false;
            this.txtFaculty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFaculty.PlaceholderText = "";
            this.txtFaculty.ReadOnly = false;
            this.txtFaculty.Size = new System.Drawing.Size(385, 36);
            this.txtFaculty.TabIndex = 22;
            this.txtFaculty.UnderlinedStyle = false;
            // 
            // CRUDFacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 531);
            this.Controls.Add(this.cmbSchoolName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFaculty);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblGroupInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDFacultyForm";
            this.Text = "CRUDFacultyForm";
            this.Click += new System.EventHandler(this.CRUDFacultyForm_Click);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private TruniControls.CustomButton btnUpdate;
        private TruniControls.CustomButton btnDelete;
        private TruniControls.CustomButton btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private TruniControls.CustomTextBox txtFaculty;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblGroupInformation;
        private System.Windows.Forms.Label lblFaculty;
        private TruniControls.CustomButton btnCancel;
        private TruniControls.CustomButton btnSave;
        private System.Windows.Forms.ComboBox cmbSchoolName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolName;
    }
}
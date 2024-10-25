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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblGroupInformation = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_sua = new GUI.CustomButton();
            this.button_xoa = new GUI.CustomButton();
            this.button_them = new GUI.CustomButton();
            this.button_huy = new GUI.CustomButton();
            this.button_luu = new GUI.CustomButton();
            this.comboBoxSchool = new GUI.TruniControls.CustomComboBox();
            this.textBox_faculty = new GUI.TruniControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(9, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 2);
            this.panel1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(985, 299);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button_sua);
            this.panel2.Controls.Add(this.button_xoa);
            this.panel2.Controls.Add(this.button_them);
            this.panel2.Location = new System.Drawing.Point(7, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 47);
            this.panel2.TabIndex = 19;
            // 
            // button_sua
            // 
            this.button_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(29)))));
            this.button_sua.BorderColor = System.Drawing.Color.Black;
            this.button_sua.BorderRadius = 20;
            this.button_sua.BorderSize = 0;
            this.button_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sua.FlatAppearance.BorderSize = 0;
            this.button_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.ForeColor = System.Drawing.Color.White;
            this.button_sua.Image = ((System.Drawing.Image)(resources.GetObject("button_sua.Image")));
            this.button_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sua.Location = new System.Drawing.Point(214, 1);
            this.button_sua.Name = "button_sua";
            this.button_sua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_sua.Size = new System.Drawing.Size(97, 45);
            this.button_sua.TabIndex = 7;
            this.button_sua.Text = "Sửa";
            this.button_sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_sua.UseVisualStyleBackColor = false;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.button_xoa.BorderColor = System.Drawing.Color.Black;
            this.button_xoa.BorderRadius = 20;
            this.button_xoa.BorderSize = 0;
            this.button_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xoa.FlatAppearance.BorderSize = 0;
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.ForeColor = System.Drawing.Color.White;
            this.button_xoa.Image = ((System.Drawing.Image)(resources.GetObject("button_xoa.Image")));
            this.button_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoa.Location = new System.Drawing.Point(108, 1);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.button_xoa.Size = new System.Drawing.Size(97, 45);
            this.button_xoa.TabIndex = 6;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_them
            // 
            this.button_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_them.BackColor = System.Drawing.Color.DarkGreen;
            this.button_them.BorderColor = System.Drawing.Color.Black;
            this.button_them.BorderRadius = 20;
            this.button_them.BorderSize = 0;
            this.button_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_them.FlatAppearance.BorderSize = 0;
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.ForeColor = System.Drawing.Color.White;
            this.button_them.Image = ((System.Drawing.Image)(resources.GetObject("button_them.Image")));
            this.button_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_them.Location = new System.Drawing.Point(1, 1);
            this.button_them.Name = "button_them";
            this.button_them.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button_them.Size = new System.Drawing.Size(97, 45);
            this.button_them.TabIndex = 9;
            this.button_them.Text = "Thêm";
            this.button_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_huy
            // 
            this.button_huy.BackColor = System.Drawing.Color.DimGray;
            this.button_huy.BorderColor = System.Drawing.Color.Black;
            this.button_huy.BorderRadius = 20;
            this.button_huy.BorderSize = 1;
            this.button_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_huy.FlatAppearance.BorderSize = 0;
            this.button_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huy.ForeColor = System.Drawing.Color.White;
            this.button_huy.Image = ((System.Drawing.Image)(resources.GetObject("button_huy.Image")));
            this.button_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_huy.Location = new System.Drawing.Point(887, 108);
            this.button_huy.Name = "button_huy";
            this.button_huy.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button_huy.Size = new System.Drawing.Size(97, 45);
            this.button_huy.TabIndex = 28;
            this.button_huy.Text = "Hủy";
            this.button_huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_huy.UseVisualStyleBackColor = false;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_luu
            // 
            this.button_luu.BackColor = System.Drawing.Color.DimGray;
            this.button_luu.BorderColor = System.Drawing.Color.Black;
            this.button_luu.BorderRadius = 20;
            this.button_luu.BorderSize = 1;
            this.button_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_luu.FlatAppearance.BorderSize = 0;
            this.button_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luu.ForeColor = System.Drawing.Color.White;
            this.button_luu.Image = ((System.Drawing.Image)(resources.GetObject("button_luu.Image")));
            this.button_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_luu.Location = new System.Drawing.Point(765, 108);
            this.button_luu.Name = "button_luu";
            this.button_luu.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button_luu.Size = new System.Drawing.Size(97, 45);
            this.button_luu.TabIndex = 27;
            this.button_luu.Text = "Lưu";
            this.button_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_luu.UseVisualStyleBackColor = false;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // comboBoxSchool
            // 
            this.comboBoxSchool.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxSchool.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxSchool.BorderSize = 1;
            this.comboBoxSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSchool.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxSchool.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxSchool.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxSchool.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxSchool.Location = new System.Drawing.Point(115, 60);
            this.comboBoxSchool.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxSchool.Name = "comboBoxSchool";
            this.comboBoxSchool.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxSchool.Size = new System.Drawing.Size(484, 30);
            this.comboBoxSchool.TabIndex = 26;
            this.comboBoxSchool.Texts = "";
            this.comboBoxSchool.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxSchool_OnSelectedIndexChanged);
            // 
            // textBox_faculty
            // 
            this.textBox_faculty.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_faculty.BorderColor = System.Drawing.Color.Black;
            this.textBox_faculty.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.textBox_faculty.BorderRadius = 8;
            this.textBox_faculty.BorderSize = 1;
            this.textBox_faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_faculty.ForeColor = System.Drawing.Color.Black;
            this.textBox_faculty.Location = new System.Drawing.Point(115, 108);
            this.textBox_faculty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_faculty.Multiline = false;
            this.textBox_faculty.Name = "textBox_faculty";
            this.textBox_faculty.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_faculty.PasswordChar = false;
            this.textBox_faculty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_faculty.PlaceholderText = "";
            this.textBox_faculty.ReadOnly = false;
            this.textBox_faculty.Size = new System.Drawing.Size(385, 33);
            this.textBox_faculty.TabIndex = 22;
            this.textBox_faculty.UnderlinedStyle = false;
            // 
            // CRUDFacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(996, 531);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.comboBoxSchool);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_faculty);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblGroupInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDFacultyForm";
            this.Text = "CRUDFacultyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TruniControls.CustomTextBox textBox_faculty;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblGroupInformation;
        private System.Windows.Forms.Label lblFaculty;
        private TruniControls.CustomComboBox comboBoxSchool;
        private CustomButton button_huy;
        private CustomButton button_luu;
        private CustomButton button_them;
        private CustomButton button_xoa;
        private CustomButton button_sua;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace GUI
{
    using System.Windows.Forms;
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbManual = new System.Windows.Forms.PictureBox();
            this.ptbQRCode = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customTextBox3 = new GUI.TruniControls.CustomTextBox();
            this.txtMSSV = new GUI.TruniControls.CustomTextBox();
            this.tbxStudent = new GUI.TruniControls.CustomTextBox();
            this.btnListData = new GUI.TruniControls.CustomButton();
            this.btnUpdate = new GUI.TruniControls.CustomButton();
            this.btnDelete = new GUI.TruniControls.CustomButton();
            this.btnAdd = new GUI.TruniControls.CustomButton();
            this.customButton2 = new GUI.TruniControls.CustomButton();
            this.customButton1 = new GUI.TruniControls.CustomButton();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQRCode)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMSSV);
            this.panel7.Controls.Add(this.tbxStudent);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(18, 21);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1002, 159);
            this.panel7.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã số sinh viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(342, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 26);
            this.label6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin sinh viên";
            // 
            // ptbManual
            // 
            this.ptbManual.BackColor = System.Drawing.Color.White;
            this.ptbManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbManual.Image = global::GUI.Properties.Resources.icons8_hand_901;
            this.ptbManual.Location = new System.Drawing.Point(184, 200);
            this.ptbManual.Margin = new System.Windows.Forms.Padding(2);
            this.ptbManual.Name = "ptbManual";
            this.ptbManual.Size = new System.Drawing.Size(30, 30);
            this.ptbManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbManual.TabIndex = 3;
            this.ptbManual.TabStop = false;
            // 
            // ptbQRCode
            // 
            this.ptbQRCode.BackColor = System.Drawing.Color.White;
            this.ptbQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbQRCode.Image = global::GUI.Properties.Resources.icons8_qr_code_96;
            this.ptbQRCode.Location = new System.Drawing.Point(132, 200);
            this.ptbQRCode.Margin = new System.Windows.Forms.Padding(2);
            this.ptbQRCode.Name = "ptbQRCode";
            this.ptbQRCode.Size = new System.Drawing.Size(30, 30);
            this.ptbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbQRCode.TabIndex = 3;
            this.ptbQRCode.TabStop = false;
            this.ptbQRCode.Click += new System.EventHandler(this.ptbQRCode_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(22, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điểm danh:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(21, 181);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1001, 2);
            this.panel9.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dataGridViewStudents);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.ptbManual);
            this.panel6.Controls.Add(this.btnListData);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.ptbQRCode);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.customButton2);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.customButton1);
            this.panel6.Location = new System.Drawing.Point(19, 72);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1036, 592);
            this.panel6.TabIndex = 5;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.EnableHeadersVisualStyles = false;
            this.dataGridViewStudents.Location = new System.Drawing.Point(18, 254);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1004, 325);
            this.dataGridViewStudents.TabIndex = 15;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(692, 196);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 48);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhóm TH02";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.customTextBox3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(19, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 52);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::GUI.Properties.Resources.icons8_file_500;
            this.pictureBox2.Location = new System.Drawing.Point(990, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI.Properties.Resources.icons8_search_500;
            this.pictureBox3.Location = new System.Drawing.Point(658, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_download_96;
            this.pictureBox1.Location = new System.Drawing.Point(946, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(985, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(941, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderRadius = 8;
            this.customTextBox3.BorderSize = 1;
            this.customTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox3.Location = new System.Drawing.Point(646, 5);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(40, 8, 10, 8);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "Tìm kiếm";
            this.customTextBox3.ReadOnly = false;
            this.customTextBox3.Size = new System.Drawing.Size(259, 35);
            this.customTextBox3.TabIndex = 4;
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // txtMSSV
            // 
            this.txtMSSV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMSSV.BorderColor = System.Drawing.Color.Black;
            this.txtMSSV.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtMSSV.BorderRadius = 8;
            this.txtMSSV.BorderSize = 1;
            this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.ForeColor = System.Drawing.Color.Black;
            this.txtMSSV.Location = new System.Drawing.Point(151, 106);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMSSV.Multiline = false;
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtMSSV.PasswordChar = false;
            this.txtMSSV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMSSV.PlaceholderText = "";
            this.txtMSSV.ReadOnly = false;
            this.txtMSSV.Size = new System.Drawing.Size(148, 35);
            this.txtMSSV.TabIndex = 16;
            this.txtMSSV.UnderlinedStyle = false;
            // 
            // tbxStudent
            // 
            this.tbxStudent.BackColor = System.Drawing.SystemColors.Window;
            this.tbxStudent.BorderColor = System.Drawing.Color.Black;
            this.tbxStudent.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.tbxStudent.BorderRadius = 8;
            this.tbxStudent.BorderSize = 1;
            this.tbxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudent.ForeColor = System.Drawing.Color.Black;
            this.tbxStudent.Location = new System.Drawing.Point(151, 55);
            this.tbxStudent.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbxStudent.Multiline = false;
            this.tbxStudent.Name = "tbxStudent";
            this.tbxStudent.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.tbxStudent.PasswordChar = false;
            this.tbxStudent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxStudent.PlaceholderText = "";
            this.tbxStudent.ReadOnly = false;
            this.tbxStudent.Size = new System.Drawing.Size(400, 35);
            this.tbxStudent.TabIndex = 15;
            this.tbxStudent.UnderlinedStyle = false;
            // 
            // btnListData
            // 
            this.btnListData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListData.BackColor = System.Drawing.Color.DarkGreen;
            this.btnListData.BorderColor = System.Drawing.Color.Black;
            this.btnListData.BorderRadius = 20;
            this.btnListData.BorderSize = 0;
            this.btnListData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListData.FlatAppearance.BorderSize = 0;
            this.btnListData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListData.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListData.ForeColor = System.Drawing.Color.White;
            this.btnListData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListData.Location = new System.Drawing.Point(462, 196);
            this.btnListData.Margin = new System.Windows.Forms.Padding(2);
            this.btnListData.Name = "btnListData";
            this.btnListData.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnListData.Size = new System.Drawing.Size(124, 45);
            this.btnListData.TabIndex = 9;
            this.btnListData.Text = "Danh sách";
            this.btnListData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListData.UseVisualStyleBackColor = false;
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
            this.btnUpdate.Location = new System.Drawing.Point(230, 1);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(98, 45);
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
            this.btnDelete.Location = new System.Drawing.Point(115, 1);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(98, 45);
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
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(98, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Transparent;
            this.customButton2.BorderColor = System.Drawing.Color.Black;
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 1;
            this.customButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Location = new System.Drawing.Point(179, 198);
            this.customButton2.Margin = new System.Windows.Forms.Padding(2);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(38, 38);
            this.customButton2.TabIndex = 14;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderColor = System.Drawing.Color.Black;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 1;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(129, 198);
            this.customButton1.Margin = new System.Windows.Forms.Padding(2);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(38, 38);
            this.customButton1.TabIndex = 14;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQRCode)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private TruniControls.CustomTextBox txtMSSV;
        private TruniControls.CustomTextBox customTextBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ptbManual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ptbQRCode;
        private TruniControls.CustomButton customButton2;
        private TruniControls.CustomButton customButton1;
        private TruniControls.CustomTextBox ccbxStudentCount;
        private TruniControls.CustomButton btnUpdate;
        private TruniControls.CustomButton btnDelete;
        private TruniControls.CustomButton btnAdd;
        private TruniControls.CustomButton btnListData;
        private TruniControls.CustomTextBox tbxStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1;
    }
}

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.customTextBox1 = new GUI.TruniControls.CustomTextBox();
            this.ccbxStudentCount = new GUI.TruniControls.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.customButton2 = new GUI.TruniControls.CustomButton();
            this.customButton1 = new GUI.TruniControls.CustomButton();
            this.label8 = new System.Windows.Forms.Label();
            this.customTextBox3 = new GUI.TruniControls.CustomTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customButton3 = new GUI.TruniControls.CustomButton();
            this.customButton4 = new GUI.TruniControls.CustomButton();
            this.customButton9 = new GUI.TruniControls.CustomButton();
            this.customButton10 = new GUI.TruniControls.CustomButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListData = new GUI.TruniControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();

            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            this.dataGridViewStudents.ColumnHeadersHeight = 45;
            this.dataGridViewStudents.EnableHeadersVisualStyles = false;
            this.dataGridViewStudents.Location = new System.Drawing.Point(18, 252);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1001, 327);
            this.dataGridViewStudents.TabIndex = 2;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // panel7
            // 

            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.customButton2);
            this.panel7.Controls.Add(this.customButton4);
            this.panel7.Controls.Add(this.customButton1);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.customTextBox1);
            this.panel7.Controls.Add(this.ccbxStudentCount);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(18, 21);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1014, 159);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
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
            this.customTextBox1.Location = new System.Drawing.Point(151, 106);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(148, 36);
            this.customTextBox1.TabIndex = 16;
            this.customTextBox1.UnderlinedStyle = false;
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
            this.ccbxStudentCount.Location = new System.Drawing.Point(151, 55);
            this.ccbxStudentCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccbxStudentCount.Multiline = false;
            this.ccbxStudentCount.Name = "ccbxStudentCount";
            this.ccbxStudentCount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ccbxStudentCount.PasswordChar = false;
            this.ccbxStudentCount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ccbxStudentCount.PlaceholderText = "";
            this.ccbxStudentCount.Size = new System.Drawing.Size(400, 36);
            this.ccbxStudentCount.TabIndex = 15;
            this.ccbxStudentCount.UnderlinedStyle = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::GUI.Properties.Resources.icons8_hand_901;

            this.pictureBox5.Location = new System.Drawing.Point(786, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::GUI.Properties.Resources.icons8_qr_code_96;

            this.pictureBox6.Location = new System.Drawing.Point(735, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 

            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);

            this.label8.Location = new System.Drawing.Point(628, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điểm danh:";
            // 

            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã số sinh viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(343, 65);
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
            this.label4.Location = new System.Drawing.Point(5, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin sinh viên";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::GUI.Properties.Resources.icons8_hand_901;
            this.pictureBox5.Location = new System.Drawing.Point(184, 200);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::GUI.Properties.Resources.icons8_qr_code_96;
            this.pictureBox6.Location = new System.Drawing.Point(133, 200);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.customButton2.Location = new System.Drawing.Point(179, 197);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(37, 37);
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
            this.customButton1.Location = new System.Drawing.Point(129, 197);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(37, 37);
            this.customButton1.TabIndex = 14;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(22, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điểm danh:";
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderRadius = 8;
            this.customTextBox3.BorderSize = 1;
            this.customTextBox3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox3.Location = new System.Drawing.Point(646, 5);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(40, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "Tìm kiếm";
            this.customTextBox3.Size = new System.Drawing.Size(259, 36);
            this.customTextBox3.TabIndex = 4;
            this.customTextBox3.UnderlinedStyle = false;
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
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.btnListData);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.customButton2);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.customButton1);
            this.panel6.Location = new System.Drawing.Point(19, 73);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1036, 593);
            this.panel6.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customButton3);
            this.panel1.Controls.Add(this.customButton4);
            this.panel1.Controls.Add(this.customButton9);
            this.panel1.Controls.Add(this.customButton10);
            this.panel1.Location = new System.Drawing.Point(603, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 47);
            this.panel1.TabIndex = 11;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
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
            this.panel3.Location = new System.Drawing.Point(19, 13);
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
            this.pictureBox3.Location = new System.Drawing.Point(657, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_download_96;
            this.pictureBox1.Location = new System.Drawing.Point(946, 8);
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
            this.button2.Location = new System.Drawing.Point(985, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(941, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
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
            this.btnListData.Name = "btnListData";
            this.btnListData.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnListData.Size = new System.Drawing.Size(124, 45);
            this.btnListData.TabIndex = 9;
            this.btnListData.Text = "Danh sách";
            this.btnListData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListData.UseVisualStyleBackColor = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();

            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
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
        private TruniControls.CustomTextBox customTextBox1;
        private TruniControls.CustomTextBox customTextBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private TruniControls.CustomButton customButton2;
        private TruniControls.CustomButton customButton1;
        private TruniControls.CustomTextBox ccbxStudentCount;
        private TruniControls.CustomButton customButton3;
        private TruniControls.CustomButton customButton4;
        private TruniControls.CustomButton customButton9;
        private TruniControls.CustomButton customButton10;
        private TruniControls.CustomButton btnListData;
    }
}

namespace GUI
{
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton6 = new GUI.CustomButton();
            this.customButton7 = new GUI.CustomButton();
            this.customButton8 = new GUI.CustomButton();
            this.customButton5 = new GUI.CustomButton();
            this.customTextBox2 = new GUI.TruniControls.CustomTextBox();
            this.customTextBox1 = new GUI.TruniControls.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customTextBox3 = new GUI.TruniControls.CustomTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.customButton1 = new GUI.CustomButton();
            this.customButton2 = new GUI.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudents.ColumnHeadersHeight = 45;
            this.dataGridViewStudents.EnableHeadersVisualStyles = false;
            this.dataGridViewStudents.Location = new System.Drawing.Point(21, 170);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1031, 360);
            this.dataGridViewStudents.TabIndex = 2;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.customButton2);
            this.panel7.Controls.Add(this.customButton1);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.customTextBox2);
            this.panel7.Controls.Add(this.customTextBox1);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(21, 21);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1031, 129);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::GUI.Properties.Resources.icons8_hand_901;
            this.pictureBox5.Location = new System.Drawing.Point(788, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customButton6);
            this.panel2.Controls.Add(this.customButton7);
            this.panel2.Controls.Add(this.customButton8);
            this.panel2.Controls.Add(this.customButton5);
            this.panel2.Location = new System.Drawing.Point(590, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 56);
            this.panel2.TabIndex = 11;
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
            this.customButton7.Location = new System.Drawing.Point(242, 3);
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
            this.customButton8.Location = new System.Drawing.Point(141, 3);
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
            this.customButton5.Location = new System.Drawing.Point(40, 3);
            this.customButton5.Name = "customButton5";
            this.customButton5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton5.Size = new System.Drawing.Size(97, 45);
            this.customButton5.TabIndex = 9;
            this.customButton5.Text = "Thêm";
            this.customButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customTextBox2.BorderRadius = 0;
            this.customTextBox2.BorderSize = 1;
            this.customTextBox2.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(136, 86);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(158, 35);
            this.customTextBox2.TabIndex = 4;
            this.customTextBox2.Texts = "52200141";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.BorderSize = 1;
            this.customTextBox1.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(135, 51);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(159, 35);
            this.customTextBox1.TabIndex = 4;
            this.customTextBox1.Texts = "Nhật Toàn";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(5, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
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
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(5, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin sinh viên";
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customTextBox3.BorderRadius = 8;
            this.customTextBox3.BorderSize = 1;
            this.customTextBox3.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.customTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox3.Location = new System.Drawing.Point(713, 11);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(40, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "Tìm kiếm";
            this.customTextBox3.Size = new System.Drawing.Size(259, 35);
            this.customTextBox3.TabIndex = 4;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(21, 151);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1031, 2);
            this.panel9.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dataGridViewStudents);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(13, 73);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1072, 546);
            this.panel6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
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
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 52);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::GUI.Properties.Resources.icons8_file_500;
            this.pictureBox2.Location = new System.Drawing.Point(1038, 14);
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
            this.pictureBox3.Location = new System.Drawing.Point(724, 19);
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
            this.pictureBox1.Location = new System.Drawing.Point(994, 14);
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
            this.button2.Location = new System.Drawing.Point(1033, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(989, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(626, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điểm danh:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::GUI.Properties.Resources.icons8_qr_code_96;
            this.pictureBox6.Location = new System.Drawing.Point(737, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.customButton1.Location = new System.Drawing.Point(733, 20);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(37, 37);
            this.customButton1.TabIndex = 14;
            this.customButton1.UseVisualStyleBackColor = false;
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
            this.customButton2.Location = new System.Drawing.Point(783, 20);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(37, 37);
            this.customButton2.TabIndex = 14;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 632);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TruniControls.CustomTextBox customTextBox2;
        private TruniControls.CustomTextBox customTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private TruniControls.CustomTextBox customTextBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private CustomButton customButton6;
        private CustomButton customButton7;
        private CustomButton customButton8;
        private CustomButton customButton5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CustomButton customButton2;
        private CustomButton customButton1;
    }
}
namespace AttendanceSystem
{
    partial class CreateGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroupForm));
            this.cpnlTotal = new GUI.TruniControls.CustomPanel();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.dttTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dttTimeStart = new System.Windows.Forms.DateTimePicker();
            this.ccbxDay = new System.Windows.Forms.ComboBox();
            this.sgvStudyPeriod = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton1 = new GUI.TruniControls.CustomButton();
            this.customButton4 = new GUI.TruniControls.CustomButton();
            this.customButton3 = new GUI.TruniControls.CustomButton();
            this.customButton2 = new GUI.TruniControls.CustomButton();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.lblStudyPeriod = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.customButton6 = new GUI.CustomButton();
            this.customButton5 = new GUI.CustomButton();
            this.cpnl = new GUI.TruniControls.CustomPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customTextBox2 = new GUI.TruniControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customTextBox1 = new GUI.TruniControls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtnImportFile = new GUI.TruniControls.CustomButton();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.cpnlGroupInfor = new GUI.TruniControls.CustomPanel();
            this.ccbxSubject = new GUI.TruniControls.CustomComboBox();
            this.ccbxDepartment = new GUI.TruniControls.CustomComboBox();
            this.ccbxSchool = new GUI.TruniControls.CustomComboBox();
            this.ctxbGroupName = new GUI.TruniControls.CustomTextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpnlTotal.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgvStudyPeriod)).BeginInit();
            this.panel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.cpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cpnlGroupInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpnlTotal
            // 
            this.cpnlTotal.BackColor = System.Drawing.Color.White;
            this.cpnlTotal.BorderColor = System.Drawing.Color.Black;
            this.cpnlTotal.BorderRadius = 30;
            this.cpnlTotal.BorderSize = 0;
            this.cpnlTotal.Controls.Add(this.customPanel2);
            this.cpnlTotal.Controls.Add(this.panel1);
            this.cpnlTotal.Controls.Add(this.customPanel1);
            this.cpnlTotal.Controls.Add(this.cpnlGroupInfor);
            this.cpnlTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlTotal.ForeColor = System.Drawing.Color.Black;
            this.cpnlTotal.GradientAngle = 90F;
            this.cpnlTotal.GradientBottomColor = System.Drawing.Color.White;
            this.cpnlTotal.GradientTopColor = System.Drawing.Color.White;
            this.cpnlTotal.Location = new System.Drawing.Point(23, 19);
            this.cpnlTotal.Name = "cpnlTotal";
            this.cpnlTotal.Size = new System.Drawing.Size(1027, 643);
            this.cpnlTotal.TabIndex = 0;
            this.cpnlTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderColor = System.Drawing.Color.Black;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.dttTimeEnd);
            this.customPanel2.Controls.Add(this.dttTimeStart);
            this.customPanel2.Controls.Add(this.ccbxDay);
            this.customPanel2.Controls.Add(this.sgvStudyPeriod);
            this.customPanel2.Controls.Add(this.panel2);
            this.customPanel2.Controls.Add(this.lblDay);
            this.customPanel2.Controls.Add(this.lblTimeStart);
            this.customPanel2.Controls.Add(this.lblTimeEnd);
            this.customPanel2.Controls.Add(this.lblStudyPeriod);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.customPanel2.GradientTopColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(28, 158);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(407, 421);
            this.customPanel2.TabIndex = 12;
            // 
            // dttTimeEnd
            // 
            this.dttTimeEnd.Location = new System.Drawing.Point(130, 142);
            this.dttTimeEnd.Name = "dttTimeEnd";
            this.dttTimeEnd.Size = new System.Drawing.Size(200, 24);
            this.dttTimeEnd.TabIndex = 24;
            this.dttTimeEnd.ValueChanged += new System.EventHandler(this.dttTimeEnd_ValueChanged);
            // 
            // dttTimeStart
            // 
            this.dttTimeStart.Location = new System.Drawing.Point(131, 93);
            this.dttTimeStart.Name = "dttTimeStart";
            this.dttTimeStart.Size = new System.Drawing.Size(200, 24);
            this.dttTimeStart.TabIndex = 23;
            this.dttTimeStart.ValueChanged += new System.EventHandler(this.dttTimeStart_ValueChanged);
            // 
            // ccbxDay
            // 
            this.ccbxDay.FormattingEnabled = true;
            this.ccbxDay.Items.AddRange(new object[] {
            "Hai",
            "Ba",
            "Tư",
            "Năm",
            "Sáu",
            "Bảy",
            "Chủ Nhật"});
            this.ccbxDay.Location = new System.Drawing.Point(131, 44);
            this.ccbxDay.Name = "ccbxDay";
            this.ccbxDay.Size = new System.Drawing.Size(199, 26);
            this.ccbxDay.TabIndex = 21;
            this.ccbxDay.SelectedIndexChanged += new System.EventHandler(this.ccbxDay_SelectedIndexChanged);
            // 
            // sgvStudyPeriod
            // 
            this.sgvStudyPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sgvStudyPeriod.Location = new System.Drawing.Point(11, 241);
            this.sgvStudyPeriod.Name = "sgvStudyPeriod";
            this.sgvStudyPeriod.RowHeadersWidth = 51;
            this.sgvStudyPeriod.RowTemplate.Height = 24;
            this.sgvStudyPeriod.Size = new System.Drawing.Size(389, 169);
            this.sgvStudyPeriod.TabIndex = 20;
            this.sgvStudyPeriod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sgvStudyPeriod_CellContentClick);
            this.sgvStudyPeriod.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sgvStudyPeriod_ColumnHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Controls.Add(this.customButton4);
            this.panel2.Controls.Add(this.customButton3);
            this.panel2.Controls.Add(this.customButton2);
            this.panel2.Location = new System.Drawing.Point(197, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 40);
            this.panel2.TabIndex = 19;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customButton1.BorderColor = System.Drawing.Color.Black;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.Location = new System.Drawing.Point(159, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton1.Size = new System.Drawing.Size(45, 40);
            this.customButton1.TabIndex = 10;
            this.customButton1.Text = "OK";
            this.customButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton4
            // 
            this.customButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customButton4.BackColor = System.Drawing.Color.DarkGreen;
            this.customButton4.BorderColor = System.Drawing.Color.Black;
            this.customButton4.BorderRadius = 20;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Image = ((System.Drawing.Image)(resources.GetObject("customButton4.Image")));
            this.customButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.Location = new System.Drawing.Point(6, 0);
            this.customButton4.Name = "customButton4";
            this.customButton4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton4.Size = new System.Drawing.Size(45, 40);
            this.customButton4.TabIndex = 9;
            this.customButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.customButton3.BorderColor = System.Drawing.Color.Black;
            this.customButton3.BorderRadius = 20;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Image = ((System.Drawing.Image)(resources.GetObject("customButton3.Image")));
            this.customButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.Location = new System.Drawing.Point(57, 0);
            this.customButton3.Name = "customButton3";
            this.customButton3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton3.Size = new System.Drawing.Size(45, 40);
            this.customButton3.TabIndex = 6;
            this.customButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(29)))));
            this.customButton2.BorderColor = System.Drawing.Color.Black;
            this.customButton2.BorderRadius = 20;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Image = ((System.Drawing.Image)(resources.GetObject("customButton2.Image")));
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.Location = new System.Drawing.Point(108, 0);
            this.customButton2.Name = "customButton2";
            this.customButton2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton2.Size = new System.Drawing.Size(45, 40);
            this.customButton2.TabIndex = 7;
            this.customButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(3, 47);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(46, 18);
            this.lblDay.TabIndex = 14;
            this.lblDay.Text = "Thứ: ";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(4, 93);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(100, 18);
            this.lblTimeStart.TabIndex = 13;
            this.lblTimeStart.Text = "Giờ bắt đầu:";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Location = new System.Drawing.Point(4, 142);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(110, 18);
            this.lblTimeEnd.TabIndex = 12;
            this.lblTimeEnd.Text = "Giờ kết thúc: ";
            // 
            // lblStudyPeriod
            // 
            this.lblStudyPeriod.AutoSize = true;
            this.lblStudyPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyPeriod.Location = new System.Drawing.Point(3, 9);
            this.lblStudyPeriod.Name = "lblStudyPeriod";
            this.lblStudyPeriod.Size = new System.Drawing.Size(82, 18);
            this.lblStudyPeriod.TabIndex = 11;
            this.lblStudyPeriod.Text = "~Ca học~";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(28, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 3);
            this.panel1.TabIndex = 8;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.customButton6);
            this.customPanel1.Controls.Add(this.customButton5);
            this.customPanel1.Controls.Add(this.cpnl);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(28, 158);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(966, 472);
            this.customPanel1.TabIndex = 7;
            // 
            // customButton6
            // 
            this.customButton6.BackColor = System.Drawing.Color.Black;
            this.customButton6.BorderColor = System.Drawing.Color.Black;
            this.customButton6.BorderRadius = 20;
            this.customButton6.BorderSize = 0;
            this.customButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton6.FlatAppearance.BorderSize = 0;
            this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton6.ForeColor = System.Drawing.Color.White;
            this.customButton6.Image = ((System.Drawing.Image)(resources.GetObject("customButton6.Image")));
            this.customButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton6.Location = new System.Drawing.Point(857, 424);
            this.customButton6.Name = "customButton6";
            this.customButton6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton6.Size = new System.Drawing.Size(97, 45);
            this.customButton6.TabIndex = 13;
            this.customButton6.Text = "Lưu";
            this.customButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton6.UseVisualStyleBackColor = false;
            this.customButton6.Click += new System.EventHandler(this.customButton6_Click);
            // 
            // customButton5
            // 
            this.customButton5.BackColor = System.Drawing.Color.Black;
            this.customButton5.BorderColor = System.Drawing.Color.Black;
            this.customButton5.BorderRadius = 20;
            this.customButton5.BorderSize = 0;
            this.customButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton5.ForeColor = System.Drawing.Color.White;
            this.customButton5.Image = ((System.Drawing.Image)(resources.GetObject("customButton5.Image")));
            this.customButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton5.Location = new System.Drawing.Point(733, 424);
            this.customButton5.Name = "customButton5";
            this.customButton5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton5.Size = new System.Drawing.Size(97, 45);
            this.customButton5.TabIndex = 12;
            this.customButton5.Text = "Hủy";
            this.customButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // cpnl
            // 
            this.cpnl.BackColor = System.Drawing.Color.White;
            this.cpnl.BorderColor = System.Drawing.Color.Black;
            this.cpnl.BorderRadius = 30;
            this.cpnl.BorderSize = 0;
            this.cpnl.Controls.Add(this.label3);
            this.cpnl.Controls.Add(this.dataGridView1);
            this.cpnl.Controls.Add(this.customTextBox2);
            this.cpnl.Controls.Add(this.label2);
            this.cpnl.Controls.Add(this.customTextBox1);
            this.cpnl.Controls.Add(this.label1);
            this.cpnl.Controls.Add(this.cbtnImportFile);
            this.cpnl.Controls.Add(this.lblStudentList);
            this.cpnl.ForeColor = System.Drawing.Color.Black;
            this.cpnl.GradientAngle = 90F;
            this.cpnl.GradientBottomColor = System.Drawing.Color.White;
            this.cpnl.GradientTopColor = System.Drawing.Color.White;
            this.cpnl.Location = new System.Drawing.Point(428, 0);
            this.cpnl.Name = "cpnl";
            this.cpnl.Size = new System.Drawing.Size(538, 421);
            this.cpnl.TabIndex = 11;
            this.cpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.cpnl_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 306);
            this.dataGridView1.TabIndex = 16;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.Black;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.customTextBox2.BorderRadius = 8;
            this.customTextBox2.BorderSize = 1;
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(480, 50);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(52, 35);
            this.customTextBox2.TabIndex = 15;
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số buổi vắng tối đa:";
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.Black;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.customTextBox1.BorderRadius = 8;
            this.customTextBox1.BorderSize = 1;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(178, 51);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(52, 35);
            this.customTextBox1.TabIndex = 13;
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bắt đầu từ dòng:";
            // 
            // cbtnImportFile
            // 
            this.cbtnImportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.cbtnImportFile.BorderColor = System.Drawing.Color.White;
            this.cbtnImportFile.BorderRadius = 8;
            this.cbtnImportFile.BorderSize = 1;
            this.cbtnImportFile.FlatAppearance.BorderSize = 0;
            this.cbtnImportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnImportFile.ForeColor = System.Drawing.Color.Black;
            this.cbtnImportFile.Location = new System.Drawing.Point(178, 3);
            this.cbtnImportFile.Name = "cbtnImportFile";
            this.cbtnImportFile.Size = new System.Drawing.Size(116, 33);
            this.cbtnImportFile.TabIndex = 2;
            this.cbtnImportFile.Text = "Import File";
            this.cbtnImportFile.UseVisualStyleBackColor = false;
            this.cbtnImportFile.Click += new System.EventHandler(this.cbtnImportFile_Click);
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Location = new System.Drawing.Point(-1, 9);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(164, 18);
            this.lblStudentList.TabIndex = 0;
            this.lblStudentList.Text = "Danh sách sinh viên:";
            // 
            // cpnlGroupInfor
            // 
            this.cpnlGroupInfor.BackColor = System.Drawing.Color.White;
            this.cpnlGroupInfor.BorderColor = System.Drawing.Color.Black;
            this.cpnlGroupInfor.BorderRadius = 30;
            this.cpnlGroupInfor.BorderSize = 0;
            this.cpnlGroupInfor.Controls.Add(this.ccbxSubject);
            this.cpnlGroupInfor.Controls.Add(this.ccbxDepartment);
            this.cpnlGroupInfor.Controls.Add(this.ccbxSchool);
            this.cpnlGroupInfor.Controls.Add(this.ctxbGroupName);
            this.cpnlGroupInfor.Controls.Add(this.lblGroupName);
            this.cpnlGroupInfor.Controls.Add(this.lblSchool);
            this.cpnlGroupInfor.Controls.Add(this.lblSubject);
            this.cpnlGroupInfor.Controls.Add(this.lblDepartment);
            this.cpnlGroupInfor.ForeColor = System.Drawing.Color.Black;
            this.cpnlGroupInfor.GradientAngle = 90F;
            this.cpnlGroupInfor.GradientBottomColor = System.Drawing.Color.White;
            this.cpnlGroupInfor.GradientTopColor = System.Drawing.Color.White;
            this.cpnlGroupInfor.Location = new System.Drawing.Point(28, 2);
            this.cpnlGroupInfor.Name = "cpnlGroupInfor";
            this.cpnlGroupInfor.Size = new System.Drawing.Size(966, 120);
            this.cpnlGroupInfor.TabIndex = 6;
            // 
            // ccbxSubject
            // 
            this.ccbxSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ccbxSubject.BorderColor = System.Drawing.Color.Black;
            this.ccbxSubject.BorderSize = 1;
            this.ccbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ccbxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbxSubject.ForeColor = System.Drawing.Color.DimGray;
            this.ccbxSubject.IconColor = System.Drawing.Color.Black;
            this.ccbxSubject.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ccbxSubject.ListTextColor = System.Drawing.Color.DimGray;
            this.ccbxSubject.Location = new System.Drawing.Point(747, 72);
            this.ccbxSubject.MinimumSize = new System.Drawing.Size(200, 30);
            this.ccbxSubject.Name = "ccbxSubject";
            this.ccbxSubject.Padding = new System.Windows.Forms.Padding(1);
            this.ccbxSubject.Size = new System.Drawing.Size(219, 30);
            this.ccbxSubject.TabIndex = 12;
            this.ccbxSubject.Texts = "";
            // 
            // ccbxDepartment
            // 
            this.ccbxDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ccbxDepartment.BorderColor = System.Drawing.Color.Black;
            this.ccbxDepartment.BorderSize = 1;
            this.ccbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ccbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbxDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.ccbxDepartment.IconColor = System.Drawing.Color.Black;
            this.ccbxDepartment.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ccbxDepartment.ListTextColor = System.Drawing.Color.DimGray;
            this.ccbxDepartment.Location = new System.Drawing.Point(439, 72);
            this.ccbxDepartment.MinimumSize = new System.Drawing.Size(200, 30);
            this.ccbxDepartment.Name = "ccbxDepartment";
            this.ccbxDepartment.Padding = new System.Windows.Forms.Padding(1);
            this.ccbxDepartment.Size = new System.Drawing.Size(219, 30);
            this.ccbxDepartment.TabIndex = 11;
            this.ccbxDepartment.Texts = "";
            this.ccbxDepartment.OnSelectedIndexChanged += new System.EventHandler(this.ccbxDepartment_OnSelectedIndexChanged);
            // 
            // ccbxSchool
            // 
            this.ccbxSchool.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ccbxSchool.BorderColor = System.Drawing.Color.Black;
            this.ccbxSchool.BorderSize = 1;
            this.ccbxSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ccbxSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbxSchool.ForeColor = System.Drawing.Color.DimGray;
            this.ccbxSchool.IconColor = System.Drawing.Color.Black;
            this.ccbxSchool.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ccbxSchool.ListTextColor = System.Drawing.Color.DimGray;
            this.ccbxSchool.Location = new System.Drawing.Point(108, 72);
            this.ccbxSchool.MinimumSize = new System.Drawing.Size(200, 30);
            this.ccbxSchool.Name = "ccbxSchool";
            this.ccbxSchool.Padding = new System.Windows.Forms.Padding(1);
            this.ccbxSchool.Size = new System.Drawing.Size(219, 30);
            this.ccbxSchool.TabIndex = 10;
            this.ccbxSchool.Texts = "";
            this.ccbxSchool.OnSelectedIndexChanged += new System.EventHandler(this.ccbxSchool_OnSelectedIndexChanged);
            // 
            // ctxbGroupName
            // 
            this.ctxbGroupName.BackColor = System.Drawing.SystemColors.Window;
            this.ctxbGroupName.BorderColor = System.Drawing.Color.Black;
            this.ctxbGroupName.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.ctxbGroupName.BorderRadius = 8;
            this.ctxbGroupName.BorderSize = 1;
            this.ctxbGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxbGroupName.ForeColor = System.Drawing.Color.DimGray;
            this.ctxbGroupName.Location = new System.Drawing.Point(108, 18);
            this.ctxbGroupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctxbGroupName.Multiline = false;
            this.ctxbGroupName.Name = "ctxbGroupName";
            this.ctxbGroupName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctxbGroupName.PasswordChar = false;
            this.ctxbGroupName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctxbGroupName.PlaceholderText = "";
            this.ctxbGroupName.Size = new System.Drawing.Size(857, 35);
            this.ctxbGroupName.TabIndex = 5;
            this.ctxbGroupName.UnderlinedStyle = false;
            this.ctxbGroupName.Load += new System.EventHandler(this.ctxbGroupName_Load);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Location = new System.Drawing.Point(3, 27);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(88, 18);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "Tên nhóm:";
            this.lblGroupName.Click += new System.EventHandler(this.lblGroupName_Click);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(3, 77);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(71, 18);
            this.lblSchool.TabIndex = 2;
            this.lblSchool.Text = "Trường: ";
            this.lblSchool.Click += new System.EventHandler(this.lblSchool_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(671, 77);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(51, 18);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Môn: ";
            this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(353, 77);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(52, 18);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Khoa:";
            this.lblDepartment.Click += new System.EventHandler(this.lblDepartment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // CreateGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.cpnlTotal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo nhóm mới";
            this.Load += new System.EventHandler(this.CreateGroupForm_Load);
            this.cpnlTotal.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgvStudyPeriod)).EndInit();
            this.panel2.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.cpnl.ResumeLayout(false);
            this.cpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cpnlGroupInfor.ResumeLayout(false);
            this.cpnlGroupInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.TruniControls.CustomPanel cpnlTotal;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblGroupName;
        private GUI.TruniControls.CustomPanel cpnlGroupInfor;
        private GUI.TruniControls.CustomTextBox ctxbGroupName;
        private GUI.TruniControls.CustomPanel customPanel1;
        private GUI.TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Label lblStudyPeriod;
        private GUI.TruniControls.CustomPanel cpnl;
        private System.Windows.Forms.Label lblStudentList;
        private GUI.TruniControls.CustomButton cbtnImportFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private GUI.TruniControls.CustomButton customButton4;
        private GUI.TruniControls.CustomButton customButton3;
        private GUI.TruniControls.CustomButton customButton2;
        private GUI.TruniControls.CustomComboBox ccbxSubject;
        private GUI.TruniControls.CustomComboBox ccbxDepartment;
        private GUI.TruniControls.CustomComboBox ccbxSchool;
        private GUI.CustomButton customButton6;
        private GUI.CustomButton customButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GUI.TruniControls.CustomTextBox customTextBox1;
        private GUI.TruniControls.CustomTextBox customTextBox2;
        private GUI.CustomButton customButton1;
        private System.Windows.Forms.DataGridView sgvStudyPeriod;
        private System.Windows.Forms.ComboBox ccbxDay;
        private System.Windows.Forms.DateTimePicker dttTimeEnd;
        private System.Windows.Forms.DateTimePicker dttTimeStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}
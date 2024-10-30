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
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton1 = new GUI.TruniControls.CustomButton();
            this.customButton4 = new GUI.TruniControls.CustomButton();
            this.customButton3 = new GUI.TruniControls.CustomButton();
            this.customButton2 = new GUI.TruniControls.CustomButton();
            this.sgvStudyPeriod = new System.Windows.Forms.DataGridView();
            this.Thứ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dttTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dttTimeStart = new System.Windows.Forms.DateTimePicker();
            this.ccbxDay = new GUI.TruniControls.CustomComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.lblStudyPeriod = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.cpnl = new GUI.TruniControls.CustomPanel();
            this.cbtnImportFile = new GUI.TruniControls.CustomButton();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.LoaiGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cột = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cpnlTotal.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgvStudyPeriod)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.cpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
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
            this.cpnlTotal.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.customPanel2.Controls.Add(this.panel2);
            this.customPanel2.Controls.Add(this.sgvStudyPeriod);
            this.customPanel2.Controls.Add(this.dttTimeEnd);
            this.customPanel2.Controls.Add(this.dttTimeStart);
            this.customPanel2.Controls.Add(this.ccbxDay);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Controls.Add(this.customButton4);
            this.panel2.Controls.Add(this.customButton3);
            this.panel2.Controls.Add(this.customButton2);
            this.panel2.Location = new System.Drawing.Point(210, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 40);
            this.panel2.TabIndex = 19;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.customButton1.BorderColor = System.Drawing.Color.Black;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = ((System.Drawing.Image)(resources.GetObject("customButton1.Image")));
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.Location = new System.Drawing.Point(152, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton1.Size = new System.Drawing.Size(45, 40);
            this.customButton1.TabIndex = 8;
            this.customButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton1.UseVisualStyleBackColor = false;
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
            this.customButton4.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Image = ((System.Drawing.Image)(resources.GetObject("customButton4.Image")));
            this.customButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.Location = new System.Drawing.Point(0, -1);
            this.customButton4.Name = "customButton4";
            this.customButton4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton4.Size = new System.Drawing.Size(45, 40);
            this.customButton4.TabIndex = 9;
            this.customButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.customButton3.BorderColor = System.Drawing.Color.Black;
            this.customButton3.BorderRadius = 20;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Image = ((System.Drawing.Image)(resources.GetObject("customButton3.Image")));
            this.customButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.Location = new System.Drawing.Point(50, 0);
            this.customButton3.Name = "customButton3";
            this.customButton3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton3.Size = new System.Drawing.Size(45, 40);
            this.customButton3.TabIndex = 6;
            this.customButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(29)))));
            this.customButton2.BorderColor = System.Drawing.Color.Black;
            this.customButton2.BorderRadius = 20;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Image = ((System.Drawing.Image)(resources.GetObject("customButton2.Image")));
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.Location = new System.Drawing.Point(101, 0);
            this.customButton2.Name = "customButton2";
            this.customButton2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton2.Size = new System.Drawing.Size(45, 40);
            this.customButton2.TabIndex = 7;
            this.customButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // sgvStudyPeriod
            // 
            this.sgvStudyPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sgvStudyPeriod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thứ,
            this.GioBD,
            this.GioKT});
            this.sgvStudyPeriod.Location = new System.Drawing.Point(6, 240);
            this.sgvStudyPeriod.Name = "sgvStudyPeriod";
            this.sgvStudyPeriod.RowHeadersWidth = 51;
            this.sgvStudyPeriod.RowTemplate.Height = 24;
            this.sgvStudyPeriod.Size = new System.Drawing.Size(401, 170);
            this.sgvStudyPeriod.TabIndex = 18;
            // 
            // Thứ
            // 
            this.Thứ.HeaderText = "Thứ";
            this.Thứ.MinimumWidth = 6;
            this.Thứ.Name = "Thứ";
            this.Thứ.Width = 125;
            // 
            // GioBD
            // 
            this.GioBD.HeaderText = "Giờ bắt đầu";
            this.GioBD.MinimumWidth = 6;
            this.GioBD.Name = "GioBD";
            this.GioBD.Width = 125;
            // 
            // GioKT
            // 
            this.GioKT.HeaderText = "Giờ kết thúc";
            this.GioKT.MinimumWidth = 6;
            this.GioKT.Name = "GioKT";
            this.GioKT.Width = 125;
            // 
            // dttTimeEnd
            // 
            this.dttTimeEnd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.dttTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttTimeEnd.Location = new System.Drawing.Point(131, 139);
            this.dttTimeEnd.Name = "dttTimeEnd";
            this.dttTimeEnd.Size = new System.Drawing.Size(200, 27);
            this.dttTimeEnd.TabIndex = 17;
            // 
            // dttTimeStart
            // 
            this.dttTimeStart.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttTimeStart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.dttTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttTimeStart.Location = new System.Drawing.Point(131, 90);
            this.dttTimeStart.Name = "dttTimeStart";
            this.dttTimeStart.Size = new System.Drawing.Size(200, 27);
            this.dttTimeStart.TabIndex = 16;
            // 
            // ccbxDay
            // 
            this.ccbxDay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ccbxDay.BorderColor = System.Drawing.Color.Black;
            this.ccbxDay.BorderSize = 1;
            this.ccbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ccbxDay.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbxDay.ForeColor = System.Drawing.Color.DimGray;
            this.ccbxDay.IconColor = System.Drawing.Color.Black;
            this.ccbxDay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ccbxDay.ListTextColor = System.Drawing.Color.DimGray;
            this.ccbxDay.Location = new System.Drawing.Point(131, 43);
            this.ccbxDay.MinimumSize = new System.Drawing.Size(200, 30);
            this.ccbxDay.Name = "ccbxDay";
            this.ccbxDay.Padding = new System.Windows.Forms.Padding(1);
            this.ccbxDay.Size = new System.Drawing.Size(200, 30);
            this.ccbxDay.TabIndex = 15;
            this.ccbxDay.Texts = "";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(3, 47);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(46, 21);
            this.lblDay.TabIndex = 14;
            this.lblDay.Text = "Thứ: ";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Location = new System.Drawing.Point(4, 93);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(101, 21);
            this.lblTimeStart.TabIndex = 13;
            this.lblTimeStart.Text = "Giờ bắt đầu:";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Location = new System.Drawing.Point(4, 142);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(110, 21);
            this.lblTimeEnd.TabIndex = 12;
            this.lblTimeEnd.Text = "Giờ kết thúc: ";
            // 
            // lblStudyPeriod
            // 
            this.lblStudyPeriod.AutoSize = true;
            this.lblStudyPeriod.Font = new System.Drawing.Font("Montserrat Medium", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyPeriod.Location = new System.Drawing.Point(3, 9);
            this.lblStudyPeriod.Name = "lblStudyPeriod";
            this.lblStudyPeriod.Size = new System.Drawing.Size(82, 21);
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
            // cpnl
            // 
            this.cpnl.BackColor = System.Drawing.Color.White;
            this.cpnl.BorderColor = System.Drawing.Color.Black;
            this.cpnl.BorderRadius = 30;
            this.cpnl.BorderSize = 0;
            this.cpnl.Controls.Add(this.cbtnImportFile);
            this.cpnl.Controls.Add(this.dgvStudentList);
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
            // cbtnImportFile
            // 
            this.cbtnImportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.cbtnImportFile.BorderColor = System.Drawing.Color.White;
            this.cbtnImportFile.BorderRadius = 8;
            this.cbtnImportFile.BorderSize = 1;
            this.cbtnImportFile.FlatAppearance.BorderSize = 0;
            this.cbtnImportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnImportFile.ForeColor = System.Drawing.Color.Black;
            this.cbtnImportFile.Location = new System.Drawing.Point(202, 3);
            this.cbtnImportFile.Name = "cbtnImportFile";
            this.cbtnImportFile.Size = new System.Drawing.Size(116, 33);
            this.cbtnImportFile.TabIndex = 2;
            this.cbtnImportFile.Text = "Import File";
            this.cbtnImportFile.UseVisualStyleBackColor = false;
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiGiaTri,
            this.Cột});
            this.dgvStudentList.Location = new System.Drawing.Point(0, 177);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.RowHeadersWidth = 51;
            this.dgvStudentList.RowTemplate.Height = 24;
            this.dgvStudentList.Size = new System.Drawing.Size(535, 233);
            this.dgvStudentList.TabIndex = 1;
            this.dgvStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LoaiGiaTri
            // 
            this.LoaiGiaTri.HeaderText = "Loại Giá Trị";
            this.LoaiGiaTri.MinimumWidth = 6;
            this.LoaiGiaTri.Name = "LoaiGiaTri";
            this.LoaiGiaTri.Width = 125;
            // 
            // Cột
            // 
            this.Cột.HeaderText = "Cột";
            this.Cột.MinimumWidth = 6;
            this.Cột.Name = "Cột";
            this.Cột.Width = 125;
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Location = new System.Drawing.Point(-1, 9);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(165, 21);
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
            this.ccbxSubject.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ccbxDepartment.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // ccbxSchool
            // 
            this.ccbxSchool.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ccbxSchool.BorderColor = System.Drawing.Color.Black;
            this.ccbxSchool.BorderSize = 1;
            this.ccbxSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ccbxSchool.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ctxbGroupName.Load += new System.EventHandler(this.customTextBox1_Load);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Location = new System.Drawing.Point(3, 27);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(90, 21);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "Tên nhóm:";
            this.lblGroupName.Click += new System.EventHandler(this.lblGroupName_Click);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(3, 77);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(72, 21);
            this.lblSchool.TabIndex = 2;
            this.lblSchool.Text = "Trường: ";
            this.lblSchool.Click += new System.EventHandler(this.lblSchool_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(671, 77);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(51, 21);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Môn: ";
            this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(353, 77);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(53, 21);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Khoa:";
            this.lblDepartment.Click += new System.EventHandler(this.lblDepartment_Click);
            // 
            // CreateGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.cpnlTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo nhóm mới";
            this.cpnlTotal.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sgvStudyPeriod)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.cpnl.ResumeLayout(false);
            this.cpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
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
        private System.Windows.Forms.DataGridView sgvStudyPeriod;
        private System.Windows.Forms.DateTimePicker dttTimeEnd;
        private System.Windows.Forms.DateTimePicker dttTimeStart;
        private GUI.TruniControls.CustomComboBox ccbxDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Label lblStudyPeriod;
        private GUI.TruniControls.CustomPanel cpnl;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Label lblStudentList;
        private GUI.TruniControls.CustomButton cbtnImportFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thứ;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cột;
        private System.Windows.Forms.Panel panel2;
        private GUI.TruniControls.CustomButton customButton1;
        private GUI.TruniControls.CustomButton customButton4;
        private GUI.TruniControls.CustomButton customButton3;
        private GUI.TruniControls.CustomButton customButton2;
        private GUI.TruniControls.CustomComboBox ccbxSubject;
        private GUI.TruniControls.CustomComboBox ccbxDepartment;
        private GUI.TruniControls.CustomComboBox ccbxSchool;
    }
}
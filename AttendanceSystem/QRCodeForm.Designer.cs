namespace GUI
{
    partial class QRCodeForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTiming = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenData = new GUI.TruniControls.CustomButton();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.btnCreate = new GUI.TruniControls.CustomButton();
            this.customPanel3 = new GUI.TruniControls.CustomPanel();
            this.mtxtTime = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.pictureQRCode = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new GUI.TruniControls.CustomButton();
            this.customPanel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(865, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "min";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(778, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "hrs";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTiming
            // 
            this.lblTiming.AutoSize = true;
            this.lblTiming.BackColor = System.Drawing.Color.Transparent;
            this.lblTiming.Font = new System.Drawing.Font("Montserrat ExtraBold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming.Location = new System.Drawing.Point(749, 286);
            this.lblTiming.Name = "lblTiming";
            this.lblTiming.Size = new System.Drawing.Size(275, 60);
            this.lblTiming.TabIndex = 7;
            this.lblTiming.Text = "00 : 00 : 00";
            this.lblTiming.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(963, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "sec";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(780, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thời gian còn lại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOpenData
            // 
            this.btnOpenData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnOpenData.BorderColor = System.Drawing.Color.White;
            this.btnOpenData.BorderRadius = 10;
            this.btnOpenData.BorderSize = 0;
            this.btnOpenData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenData.FlatAppearance.BorderSize = 0;
            this.btnOpenData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenData.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenData.ForeColor = System.Drawing.Color.White;
            this.btnOpenData.Location = new System.Drawing.Point(809, 393);
            this.btnOpenData.Name = "btnOpenData";
            this.btnOpenData.Size = new System.Drawing.Size(128, 40);
            this.btnOpenData.TabIndex = 10;
            this.btnOpenData.Text = "Mở danh sách";
            this.btnOpenData.UseVisualStyleBackColor = false;
            this.btnOpenData.Visible = false;
            this.btnOpenData.Click += new System.EventHandler(this.btnOpenData_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.txtCode);
            this.customPanel1.Controls.Add(this.btnCreate);
            this.customPanel1.Controls.Add(this.customPanel3);
            this.customPanel1.Controls.Add(this.panel2);
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.customPanel1.Location = new System.Drawing.Point(106, 28);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(514, 576);
            this.customPanel1.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnCreate.BorderColor = System.Drawing.Color.White;
            this.btnCreate.BorderRadius = 20;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(29, 509);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(443, 44);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Tạo ngay";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderColor = System.Drawing.Color.Black;
            this.customPanel3.BorderRadius = 40;
            this.customPanel3.BorderSize = 0;
            this.customPanel3.Controls.Add(this.mtxtTime);
            this.customPanel3.Controls.Add(this.panel4);
            this.customPanel3.Controls.Add(this.label5);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.Transparent;
            this.customPanel3.GradientTopColor = System.Drawing.Color.Transparent;
            this.customPanel3.Location = new System.Drawing.Point(31, 424);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(443, 68);
            this.customPanel3.TabIndex = 11;
            // 
            // mtxtTime
            // 
            this.mtxtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTime.Location = new System.Drawing.Point(45, 28);
            this.mtxtTime.Mask = "00 : 00 : 00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(361, 18);
            this.mtxtTime.TabIndex = 2;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel4.Location = new System.Drawing.Point(44, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 2);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel2.Location = new System.Drawing.Point(414, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel1.Location = new System.Drawing.Point(31, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 2);
            this.panel1.TabIndex = 1;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderColor = System.Drawing.Color.Black;
            this.customPanel2.BorderRadius = 40;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.pictureQRCode);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.Transparent;
            this.customPanel2.GradientTopColor = System.Drawing.Color.Transparent;
            this.customPanel2.Location = new System.Drawing.Point(128, 83);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(250, 250);
            this.customPanel2.TabIndex = 0;
            // 
            // pictureQRCode
            // 
            this.pictureQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureQRCode.BackColor = System.Drawing.Color.Transparent;
            this.pictureQRCode.Image = global::GUI.Properties.Resources.qr_code_242614120852044;
            this.pictureQRCode.Location = new System.Drawing.Point(16, 15);
            this.pictureQRCode.Name = "pictureQRCode";
            this.pictureQRCode.Size = new System.Drawing.Size(219, 219);
            this.pictureQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQRCode.TabIndex = 0;
            this.pictureQRCode.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập thời gian đếm ngược điểm danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quét QR Code trên thiết bị của bạn để truy cập biểu mẫu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quét QR Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BorderColor = System.Drawing.Color.White;
            this.txtCode.BorderRadius = 15;
            this.txtCode.BorderSize = 0;
            this.txtCode.FlatAppearance.BorderSize = 0;
            this.txtCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCode.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCode.Location = new System.Drawing.Point(151, 347);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 35);
            this.txtCode.TabIndex = 11;
            this.txtCode.Text = "A7BGH4";
            this.txtCode.UseVisualStyleBackColor = false;
            // 
            // QRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1098, 632);
            this.Controls.Add(this.btnOpenData);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTiming);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Name = "QRCodeForm";
            this.Text = "QRCodeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRCodeForm_FormClosing);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TruniControls.CustomButton btnOpenData;
        private TruniControls.CustomPanel customPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private TruniControls.CustomPanel customPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTiming;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private TruniControls.CustomButton btnCreate;
        private TruniControls.CustomPanel customPanel3;
        private System.Windows.Forms.MaskedTextBox mtxtTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureQRCode;
        private TruniControls.CustomButton txtCode;
    }
}
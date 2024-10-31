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
            this.btnOpenData = new GUI.TruniControls.CustomButton();
            this.pictureQRCode = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.customButton1 = new GUI.TruniControls.CustomButton();
            this.txtUrlToCopy = new GUI.TruniControls.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTiming = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnOpenData.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenData.ForeColor = System.Drawing.Color.White;
            this.btnOpenData.Location = new System.Drawing.Point(790, 378);
            this.btnOpenData.Name = "btnOpenData";
            this.btnOpenData.Size = new System.Drawing.Size(128, 40);
            this.btnOpenData.TabIndex = 10;
            this.btnOpenData.Text = "Mở danh sách";
            this.btnOpenData.UseVisualStyleBackColor = false;
            this.btnOpenData.Visible = false;
            // 
            // pictureQRCode
            // 
            this.pictureQRCode.BackColor = System.Drawing.Color.Transparent;
            this.pictureQRCode.Image = global::GUI.Properties.Resources.qr_code_242614120852044;
            this.pictureQRCode.Location = new System.Drawing.Point(21, 16);
            this.pictureQRCode.Name = "pictureQRCode";
            this.pictureQRCode.Size = new System.Drawing.Size(249, 249);
            this.pictureQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQRCode.TabIndex = 0;
            this.pictureQRCode.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.pictureBox2.Image = global::GUI.Properties.Resources.icons8_copy_64;
            this.pictureBox2.Location = new System.Drawing.Point(424, 485);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.pictureBox2);
            this.customPanel1.Controls.Add(this.customButton1);
            this.customPanel1.Controls.Add(this.txtUrlToCopy);
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
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(416, 477);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(41, 40);
            this.customButton1.TabIndex = 3;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // txtUrlToCopy
            // 
            this.txtUrlToCopy.BackColor = System.Drawing.SystemColors.Window;
            this.txtUrlToCopy.BorderColor = System.Drawing.Color.Transparent;
            this.txtUrlToCopy.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.txtUrlToCopy.BorderRadius = 5;
            this.txtUrlToCopy.BorderSize = 1;
            this.txtUrlToCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlToCopy.ForeColor = System.Drawing.Color.Black;
            this.txtUrlToCopy.Location = new System.Drawing.Point(42, 480);
            this.txtUrlToCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrlToCopy.Multiline = false;
            this.txtUrlToCopy.Name = "txtUrlToCopy";
            this.txtUrlToCopy.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUrlToCopy.PasswordChar = false;
            this.txtUrlToCopy.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUrlToCopy.PlaceholderText = "";
            this.txtUrlToCopy.ReadOnly = false;
            this.txtUrlToCopy.Size = new System.Drawing.Size(361, 35);
            this.txtUrlToCopy.TabIndex = 1;
            this.txtUrlToCopy.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel2.Location = new System.Drawing.Point(382, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel1.Location = new System.Drawing.Point(31, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 2);
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
            this.customPanel2.Location = new System.Drawing.Point(102, 125);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(290, 280);
            this.customPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hoặc nhập liên kết bên dưới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 78);
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
            this.label1.Location = new System.Drawing.Point(160, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quét QR Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.label7.Location = new System.Drawing.Point(842, 347);
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
            this.label6.Location = new System.Drawing.Point(742, 347);
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
            this.lblTiming.Location = new System.Drawing.Point(717, 286);
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
            this.label8.Location = new System.Drawing.Point(946, 347);
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
            this.label4.Location = new System.Drawing.Point(748, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thời gian còn lại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Load += new System.EventHandler(this.QRCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TruniControls.CustomButton btnOpenData;
        private System.Windows.Forms.PictureBox pictureQRCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TruniControls.CustomPanel customPanel1;
        private TruniControls.CustomButton customButton1;
        private TruniControls.CustomTextBox txtUrlToCopy;
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
    }
}
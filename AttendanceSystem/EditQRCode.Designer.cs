namespace GUI
{
    partial class EditQRCode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new GUI.TruniControls.CustomPanel();
            this.customButton1 = new GUI.TruniControls.CustomButton();
            this.customPanel2 = new GUI.TruniControls.CustomPanel();
            this.mtxtTime = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrl = new GUI.TruniControls.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._6ef13ee5a0d6e46cfab0da7ef6abd8591;
            this.pictureBox1.Location = new System.Drawing.Point(383, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.customButton1);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            this.customPanel1.Location = new System.Drawing.Point(75, 48);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(514, 534);
            this.customPanel1.TabIndex = 1;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(31, 378);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(443, 44);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Tạo ngay";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 40;
            this.customPanel2.Controls.Add(this.mtxtTime);
            this.customPanel2.Controls.Add(this.panel4);
            this.customPanel2.Controls.Add(this.panel3);
            this.customPanel2.Controls.Add(this.label5);
            this.customPanel2.Controls.Add(this.txtUrl);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.Transparent;
            this.customPanel2.GradientTopColor = System.Drawing.Color.Transparent;
            this.customPanel2.Location = new System.Drawing.Point(31, 155);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(443, 176);
            this.customPanel2.TabIndex = 0;
            // 
            // mtxtTime
            // 
            this.mtxtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTime.Location = new System.Drawing.Point(45, 116);
            this.mtxtTime.Mask = "00:00:00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(361, 18);
            this.mtxtTime.TabIndex = 2;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel4.Location = new System.Drawing.Point(44, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 2);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel3.Location = new System.Drawing.Point(44, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 2);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian";
            // 

            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.Window;
            this.txtUrl.BorderColor = System.Drawing.Color.Transparent;
            this.txtUrl.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtUrl.BorderRadius = 5;
            this.txtUrl.BorderSize = 1;
            this.txtUrl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.ForeColor = System.Drawing.Color.DimGray;
            this.txtUrl.Location = new System.Drawing.Point(34, 45);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrl.Multiline = false;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUrl.PasswordChar = false;
            this.txtUrl.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUrl.PlaceholderText = "https://form.jotform.com/242614120852044";
            this.txtUrl.Size = new System.Drawing.Size(361, 32);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Liên kết URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sử dụng đường dẫn biểu mẫu của bạn nhé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo QR Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1098, 632);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditQRCode";
            this.Load += new System.EventHandler(this.EditQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TruniControls.CustomPanel customPanel1;
        private TruniControls.CustomPanel customPanel2;
        private TruniControls.CustomTextBox txtUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtTime;
        private TruniControls.CustomButton customButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
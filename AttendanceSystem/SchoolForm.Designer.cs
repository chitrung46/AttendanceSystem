namespace AttendanceSystem
{
    partial class SchoolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolForm));
            this.label1 = new System.Windows.Forms.Label();
            this.customButton1 = new GUI.CustomButton();
            this.customButton2 = new GUI.CustomButton();
            this.customButton3 = new GUI.CustomButton();
            this.customButton4 = new GUI.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(285, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkGreen;
            this.customButton1.BorderColor = System.Drawing.Color.Black;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = ((System.Drawing.Image)(resources.GetObject("customButton1.Image")));
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.Location = new System.Drawing.Point(597, 115);
            this.customButton1.Name = "customButton1";
            this.customButton1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.customButton1.Size = new System.Drawing.Size(90, 45);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Create";
            this.customButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.customButton2.BorderColor = System.Drawing.Color.Black;
            this.customButton2.BorderRadius = 20;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Image = ((System.Drawing.Image)(resources.GetObject("customButton2.Image")));
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.Location = new System.Drawing.Point(706, 115);
            this.customButton2.Name = "customButton2";
            this.customButton2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton2.Size = new System.Drawing.Size(90, 45);
            this.customButton2.TabIndex = 2;
            this.customButton2.Text = "Delete";
            this.customButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(29)))));
            this.customButton3.BorderColor = System.Drawing.Color.Black;
            this.customButton3.BorderRadius = 20;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Image = ((System.Drawing.Image)(resources.GetObject("customButton3.Image")));
            this.customButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.Location = new System.Drawing.Point(815, 115);
            this.customButton3.Name = "customButton3";
            this.customButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customButton3.Size = new System.Drawing.Size(90, 45);
            this.customButton3.TabIndex = 3;
            this.customButton3.Text = "Edit";
            this.customButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.RoyalBlue;
            this.customButton4.BorderColor = System.Drawing.Color.Black;
            this.customButton4.BorderRadius = 20;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.ForeColor = System.Drawing.Color.White;
            this.customButton4.Image = ((System.Drawing.Image)(resources.GetObject("customButton4.Image")));
            this.customButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.Location = new System.Drawing.Point(925, 115);
            this.customButton4.Name = "customButton4";
            this.customButton4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.customButton4.Size = new System.Drawing.Size(90, 45);
            this.customButton4.TabIndex = 4;
            this.customButton4.Text = "Select";
            this.customButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // SchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 679);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SchoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GUI.CustomButton customButton1;
        private GUI.CustomButton customButton2;
        private GUI.CustomButton customButton3;
        private GUI.CustomButton customButton4;
    }
}
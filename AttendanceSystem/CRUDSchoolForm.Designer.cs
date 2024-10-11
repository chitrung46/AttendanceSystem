namespace GUI
{
    partial class CRUDSchoolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDSchoolForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton3 = new GUI.CustomButton();
            this.customButton4 = new GUI.CustomButton();
            this.customButton9 = new GUI.CustomButton();
            this.customButton10 = new GUI.CustomButton();
            this.ctxtGroupName = new GUI.TruniControls.CustomTextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupInformation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customButton3);
            this.panel2.Controls.Add(this.customButton4);
            this.panel2.Controls.Add(this.customButton9);
            this.panel2.Controls.Add(this.customButton10);
            this.panel2.Location = new System.Drawing.Point(5, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 47);
            this.panel2.TabIndex = 13;
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
            // ctxtGroupName
            // 
            this.ctxtGroupName.BackColor = System.Drawing.SystemColors.Window;
            this.ctxtGroupName.BorderColor = System.Drawing.Color.Black;
            this.ctxtGroupName.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.ctxtGroupName.BorderRadius = 8;
            this.ctxtGroupName.BorderSize = 1;
            this.ctxtGroupName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtGroupName.ForeColor = System.Drawing.Color.Black;
            this.ctxtGroupName.Location = new System.Drawing.Point(118, 54);
            this.ctxtGroupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctxtGroupName.Multiline = false;
            this.ctxtGroupName.Name = "ctxtGroupName";
            this.ctxtGroupName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ctxtGroupName.PasswordChar = false;
            this.ctxtGroupName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctxtGroupName.PlaceholderText = "";
            this.ctxtGroupName.Size = new System.Drawing.Size(484, 36);
            this.ctxtGroupName.TabIndex = 16;
            this.ctxtGroupName.UnderlinedStyle = false;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Location = new System.Drawing.Point(9, 62);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(99, 21);
            this.lblGroupName.TabIndex = 15;
            this.lblGroupName.Text = "Tên Trường:";
            // 
            // lblGroupInformation
            // 
            this.lblGroupInformation.AutoSize = true;
            this.lblGroupInformation.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupInformation.Location = new System.Drawing.Point(2, 9);
            this.lblGroupInformation.Name = "lblGroupInformation";
            this.lblGroupInformation.Size = new System.Drawing.Size(194, 27);
            this.lblGroupInformation.TabIndex = 14;
            this.lblGroupInformation.Text = "Thông tin Trường";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(985, 335);
            this.dataGridView1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(7, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 2);
            this.panel1.TabIndex = 18;
            // 
            // CRUDSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctxtGroupName);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.lblGroupInformation);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDSchoolForm";
            this.Text = "CRUDSchoolForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private CustomButton customButton3;
        private CustomButton customButton4;
        private CustomButton customButton9;
        private CustomButton customButton10;
        private TruniControls.CustomTextBox ctxtGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblGroupInformation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}
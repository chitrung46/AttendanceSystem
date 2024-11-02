using System.Windows.Forms;

namespace GUI
{
    partial class AttendanceListForm
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
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.btnLoaddata = new GUI.TruniControls.CustomButton();
            this.btnDelete = new GUI.TruniControls.CustomButton();
            this.customButton1 = new GUI.TruniControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AllowUserToAddRows = false;
            this.dataGridViewAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(219)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(42, 114);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.ReadOnly = true;
            this.dataGridViewAttendance.RowHeadersVisible = false;
            this.dataGridViewAttendance.RowHeadersWidth = 51;
            this.dataGridViewAttendance.RowTemplate.Height = 24;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(1002, 432);
            this.dataGridViewAttendance.TabIndex = 0;
            this.dataGridViewAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAttendance_CellContentClick);
            // 
            // btnLoaddata
            // 
            this.btnLoaddata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnLoaddata.BorderColor = System.Drawing.Color.White;
            this.btnLoaddata.BorderRadius = 20;
            this.btnLoaddata.BorderSize = 0;
            this.btnLoaddata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaddata.FlatAppearance.BorderSize = 0;
            this.btnLoaddata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaddata.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaddata.ForeColor = System.Drawing.Color.White;
            this.btnLoaddata.Location = new System.Drawing.Point(783, 55);
            this.btnLoaddata.Name = "btnLoaddata";
            this.btnLoaddata.Size = new System.Drawing.Size(149, 44);
            this.btnLoaddata.TabIndex = 3;
            this.btnLoaddata.Text = "Tải dữ liệu";
            this.btnLoaddata.UseVisualStyleBackColor = false;
            this.btnLoaddata.Click += new System.EventHandler(this.btnLoaddata_Click);
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
            this.btnDelete.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GUI.Properties.Resources.icons8_delete_20__1_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(947, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(97, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.customButton1.BorderColor = System.Drawing.Color.Black;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.Location = new System.Drawing.Point(947, 565);
            this.customButton1.Name = "customButton1";
            this.customButton1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.customButton1.Size = new System.Drawing.Size(97, 45);
            this.customButton1.TabIndex = 8;
            this.customButton1.Text = "Lưu";
            this.customButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // AttendanceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 632);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoaddata);
            this.Controls.Add(this.dataGridViewAttendance);
            this.Name = "AttendanceListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceListForm";
            this.Load += new System.EventHandler(this.AttendanceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private TruniControls.CustomButton btnLoaddata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private TruniControls.CustomButton btnDelete;
        private TruniControls.CustomButton customButton1;
    }
}
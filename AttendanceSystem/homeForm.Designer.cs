﻿namespace AttendanceSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnSchool = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSchool
            // 
            this.btnSchool.BackColor = System.Drawing.Color.Beige;
            this.btnSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchool.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchool.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSchool.Image = ((System.Drawing.Image)(resources.GetObject("btnSchool.Image")));
            this.btnSchool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchool.Location = new System.Drawing.Point(-11, 235);
            this.btnSchool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSchool.Name = "btnSchool";
            this.btnSchool.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSchool.Size = new System.Drawing.Size(232, 55);
            this.btnSchool.TabIndex = 0;
            this.btnSchool.Text = "Trường";
            this.btnSchool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchool.UseVisualStyleBackColor = false;
            this.btnSchool.Click += new System.EventHandler(this.btnSchool_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnGroup);
            this.panel1.Controls.Add(this.btnSchool);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 679);
            this.panel1.TabIndex = 1;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.Beige;
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(-11, 341);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSchedule.Size = new System.Drawing.Size(232, 55);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Thời khóa biểu";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Beige;
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnGroup.Image")));
            this.btnGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroup.Location = new System.Drawing.Point(-11, 288);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnGroup.Size = new System.Drawing.Size(232, 55);
            this.btnGroup.TabIndex = 1;
            this.btnGroup.Text = "Nhóm";
            this.btnGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(223, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1117, 679);
            this.mainPanel.TabIndex = 2;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 679);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSchool;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Panel mainPanel;
    }
}
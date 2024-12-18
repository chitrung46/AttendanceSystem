﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class StudentForm : Form
    {
        private StudentBLL studentBLL = new StudentBLL();
        private GroupInfo group;
        private string labelText;
        private int groupId;
        private GroupBLL groupBLL = new GroupBLL();
        private DynamicSessionTableBLL dstBLL = new DynamicSessionTableBLL();
        public StudentForm(GroupInfo group)
        {
            InitializeComponent();
            this.group = group;
            this.groupId = group.GroupId;
            this.labelText = group.GroupName;
            label1.Text = labelText;

            LoadStudents();
        }
        private void LoadStudents()
        {
            //List<StudentDTO> students = studentBLL.GetStudentsByGroupIdDAL(group.GroupId);
            //dataGridViewStudents.DataSource = students; // Bind the list to the DataGridView
            //dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            System.Data.DataTable dst = dstBLL.GetSessionTableByGroupId(groupId);
            dataGridViewStudents.DataSource = dst;

        }


        private void ptbQRCode_Click(object sender, EventArgs e)
        {
            QRCodeForm qrForm = new QRCodeForm(groupId);
            qrForm.Show();

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true; // Enable Add button
            btnDelete.Enabled = false;  // Disable Delete button
            btnUpdate.Enabled = false;
            tbxStudent.Enabled = false;      // Disable name textbox
            txtMSSV.Enabled = false;  // Disable ID textbox
            LoadStudents();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewStudents.Rows[e.RowIndex];
                // Load student data into text boxes
                txtMSSV.Text = row.Cells["MSSV"].Value.ToString();
                tbxStudent.Text = $"{row.Cells["Ho"].Value} {row.Cells["Ten"].Value}";
                btnDelete.Enabled = true;  // Enable Delete button
                btnUpdate.Enabled = true;  // Enable Edit button
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxStudent.Enabled = true;
            txtMSSV.Enabled = true;
            btnUpdate.Enabled = true;

            // Reset text boxes
            tbxStudent.Text = string.Empty;
            txtMSSV.Text = string.Empty;

            // Generate a new student ID
            int newStudentId = studentBLL.GetNextStudentIdDAL(); // Get next available ID
            txtMSSV.Text = newStudentId.ToString(); //
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the selected row
                var selectedRow = dataGridViewStudents.SelectedRows[0];

                if (tbxStudent.Enabled) // Check if the text box is enabled
                {
                    // When text box is enabled, we're in edit mode
                    if (int.TryParse(txtMSSV.Text, out int studentId)) // Ensure the ID is valid
                    {
                        var student = new StudentDTO
                        {
                            Id = studentId,
                            FirstName = tbxStudent.Text.Split(' ')[0], // First name from the text box
                            LastName = tbxStudent.Text.Split(' ')[1] // Last name from the text box
                        };

                        // Update the student in the database
                        studentBLL.UpdateStudentDAL(student);
                        LoadStudents(); // Reload the student list to reflect changes
                        MessageBox.Show("Student information updated successfully.");

                        // Reset controls after update
                        tbxStudent.Enabled = false; // Disable text box after saving
                        txtMSSV.Enabled = true; // Enable ID text box again
                        txtMSSV.Text = string.Empty; // Clear ID text box
                        tbxStudent.Text = string.Empty; // Clear name text box
                    }
                    else
                    {
                        MessageBox.Show("Invalid student ID."); // Handle invalid ID scenario
                    }
                }
                else
                {
                    // If not in edit mode, enable text boxes for editing
                    var studentId = (int)selectedRow.Cells["Id"].Value; // Get selected student ID

                    // Assuming the columns for first and last names are "FirstName" and "LastName"
                    var firstName = selectedRow.Cells["FirstName"].Value.ToString();
                    var lastName = selectedRow.Cells["LastName"].Value.ToString();
                    tbxStudent.Text = $"{firstName} {lastName}"; // Concatenate first and last name

                    txtMSSV.Text = studentId.ToString(); // Show student ID

                    tbxStudent.Enabled = true; // Enable editing for name
                    txtMSSV.Enabled = false; // Keep ID disabled
                }
            }
            else
            {
                MessageBox.Show("Please select a student to edit."); // Inform user if no selection
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];
                // Confirm deletion
                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    // Get the student ID from the selected row
                    var studentId = (int)selectedRow.Cells["Id"].Value;
                    studentBLL.DeleteStudentDAL(studentId); // Delete the student
                    LoadStudents(); // Reload students to refresh the DataGridView
                }
            }
            else
            {
                // No row is selected, inform the user
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxStudent.Text))
            {
                MessageBox.Show("Please enter a student's name.");
                return;
            }

            var names = tbxStudent.Text.Split(' ');
            var firstName = names.Length > 0 ? names[0] : string.Empty;
            var lastName = names.Length > 1 ? names[1] : string.Empty;

            var newStudent = new StudentDTO
            {
                Id = int.Parse(txtMSSV.Text), // Use the entered ID
                FirstName = firstName,
                LastName = lastName,
                STT = studentBLL.GetNextStudentIdDAL(), // Your logic to get STT
                GroupId = this.groupId // Include the GroupId from GroupInfo
            };

            // Add the new student
            int studentId;
            studentBLL.AddStudentDAL(newStudent, out studentId);

            MessageBox.Show("Student added successfully with ID: " + studentId);
            LoadStudents();
            tbxStudent.Text = string.Empty; // Clear the text box for the next entry
        }

public void ExportToExcel(DataGridView dgv, int numMaximumAbsent)
    {
        using (SaveFileDialog sfd = new SaveFileDialog())
        {
            sfd.Filter = "Excel Workbook|*.xlsx";
            sfd.FileName = "Dữ liệu điểm danh " + group.GroupName + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;

                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;
                worksheet.Cells.Font.Name = "Times New Roman";

                // Title
                worksheet.Cells[1, 1] = "Dữ liệu điểm danh " + group.GroupName;
                Excel.Range titleRange = worksheet.Range["A1", worksheet.Cells[1, dgv.Columns.Count]];
                titleRange.Merge();
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Header
                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    worksheet.Cells[3, i] = dgv.Columns[i - 1].HeaderText;
                }

                
                Excel.Range headerRange = worksheet.Range["A3", worksheet.Cells[3, dgv.Columns.Count]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                headerRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                headerRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                // Content
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    int numAbsent = 0; 

                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        var cellValue = dgv.Rows[i].Cells[j].Value?.ToString();
                        Excel.Range cell = (Excel.Range)worksheet.Cells[i + 4, j + 1]; 
                        cell.Value = cellValue;

                        if (cellValue == "V")
                        {
                            cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                            numAbsent++;
                        }

                        cell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        cell.Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    if (numAbsent >= numMaximumAbsent)
                    {
                        Excel.Range rowRange = worksheet.Range[worksheet.Cells[i + 4, 1], worksheet.Cells[i + 4, dgv.Columns.Count]];
                        rowRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    }
                }
                    excelApp.ActiveWorkbook.SaveCopyAs(filePath);
                    excelApp.ActiveWorkbook.Saved = true;
                }
        }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridViewStudents, groupBLL.GetGroupById(groupId).NumMaximumAbsent);
        }
    }
}

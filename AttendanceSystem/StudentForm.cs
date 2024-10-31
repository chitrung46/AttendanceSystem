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

namespace GUI
{
    public partial class StudentForm : Form
    {
        private StudentBLL studentBLL;
        private GroupInfo group;
        private string labelText;
        private int groupId;
        public StudentForm(GroupInfo group)
        {
            InitializeComponent();
            this.group = group;
            this.groupId = group.GroupId;
            this.labelText = group.GroupName;
            label1.Text = labelText;
            studentBLL = new StudentBLL();
            LoadStudents();
        }
        private void LoadStudents()
        {
            List<StudentDTO> students = studentBLL.GetStudentsByGroupIdDAL(group.GroupId);
            dataGridViewStudents.DataSource = students; // Bind the list to the DataGridView
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        
        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditQRCode editQRCode = new EditQRCode();
            editQRCode.Show();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            customButton10.Enabled = true; // Enable Add button
            customButton9.Enabled = false;  // Disable Delete button
            customButton4.Enabled = false;
            customButton3.Enabled = false;// Disable Edit button
            tbxStudent.Enabled = false;      // Disable name textbox
            customTextBox1.Enabled = false;  // Disable ID textbox
            LoadStudents();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewStudents.Rows[e.RowIndex];
                // Load student data into text boxes
                customTextBox1.Text = row.Cells["Id"].Value.ToString();
                tbxStudent.Text = $"{row.Cells["FirstName"].Value} {row.Cells["LastName"].Value}";
                customButton9.Enabled = true;  // Enable Delete button
                customButton4.Enabled = true;  // Enable Edit button
            }
        }

        private void customButton10_Click(object sender, EventArgs e)
        {
            tbxStudent.Enabled = true;
            customTextBox1.Enabled = true;
            customButton3.Enabled = true;

            // Reset text boxes
            tbxStudent.Text = string.Empty;
            customTextBox1.Text = string.Empty;

            // Generate a new student ID
            int newStudentId = studentBLL.GetNextStudentIdDAL(); // Get next available ID
            customTextBox1.Text = newStudentId.ToString(); //
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the selected row
                var selectedRow = dataGridViewStudents.SelectedRows[0];

                if (tbxStudent.Enabled) // Check if the text box is enabled
                {
                    // When text box is enabled, we're in edit mode
                    if (int.TryParse(customTextBox1.Text, out int studentId)) // Ensure the ID is valid
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
                        customTextBox1.Enabled = true; // Enable ID text box again
                        customTextBox1.Text = string.Empty; // Clear ID text box
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

                    customTextBox1.Text = studentId.ToString(); // Show student ID

                    tbxStudent.Enabled = true; // Enable editing for name
                    customTextBox1.Enabled = false; // Keep ID disabled
                }
            }
            else
            {
                MessageBox.Show("Please select a student to edit."); // Inform user if no selection
            }
        }

        private void customButton9_Click(object sender, EventArgs e)
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
                Id = int.Parse(customTextBox1.Text), // Use the entered ID
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

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            AttendanceListForm attendanceListForm = new AttendanceListForm();
            attendanceListForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using static DTO.CreateGF;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml;

namespace AttendanceSystem
{
    public partial class CreateGroupForm : Form
    {
        private int schoolId;
        private int accountId;
        private int newGroupId;

        DataTable table = new DataTable();
        DataTable importFileTable = new DataTable();
        DataTable excelData = new DataTable();
        StudentBLL studentBLL = new StudentBLL();
        CreateGFBLL schoolBLL = new CreateGFBLL();
        CreateGFBLL groupBLL = new CreateGFBLL();
        ScheduleBLL scheduleBLL = new ScheduleBLL();
        //CreateGFBLL facultyBLL = new CreateGFBLL();
        //CreateGFBLL subjectBLL = new CreateGFBLL();
        public CreateGroupForm(int accountId, int schoolId)
        {
            InitializeComponent();
            this.schoolId = schoolId;
            this.accountId = accountId;
        }
        public CreateGroupForm()
        {
            InitializeComponent();
        }
        private void CreateGroupForm_Load(object sender, EventArgs e)
        {
            LoadSchools();
            LoadFaculties();
            LoadSubjects();
            InitializeCustomDateTimePicker();
            InitializeDataGridView();
            InitializeDataGridViewImportFile();
            customButton2.Enabled = false;
            customButton3.Enabled = false;

            DisableControls();
        }
        /*** Ca học ***/
        private void InitializeCustomDateTimePicker()
        {
            // gio bat dau
            // Set the DateTimePicker properties to only show time
            dttTimeStart.Format = DateTimePickerFormat.Custom;
            dttTimeStart.CustomFormat = "HH:mm"; // or "HH:mm" for 24-hour format
            dttTimeStart.ShowUpDown = true; // Make it an up-down control

            // Optionally set the initial time to current time
            dttTimeStart.Value = DateTime.Now;
            // gio ket thuc
            dttTimeEnd.Format = DateTimePickerFormat.Custom;
            dttTimeEnd.CustomFormat = "HH:mm"; // or "HH:mm" for 24-hour format
            dttTimeEnd.ShowUpDown = true; // Make it an up-down control

            // Optionally set the initial time to current time
            dttTimeEnd.Value = DateTime.Now;
        }

        private void InitializeDataGridView()
        {
            // Set properties for the DataGridView
            sgvStudyPeriod.AllowUserToAddRows = false;
            sgvStudyPeriod.RowHeadersVisible = false;
            sgvStudyPeriod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Column 1: Checkbox
            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.HeaderText = ""; // Blank header for checkbox
            chkColumn.Width = 50;
            sgvStudyPeriod.Columns.Add(chkColumn);


            table.Columns.Add("Thứ", typeof(string)); // Day
            table.Columns.Add("Giờ bắt đầu", typeof(string)); // Start Time
            table.Columns.Add("Giờ kết thúc", typeof(string)); // End Time


            // Bind the DataTable to the DataGridView
            sgvStudyPeriod.DataSource = table;
            sgvStudyPeriod.ColumnHeaderMouseClick += sgvStudyPeriod_ColumnHeaderMouseClick;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGroupName_Click(object sender, EventArgs e)
        {

        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void lblSchool_Click(object sender, EventArgs e)
        {

        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void customComboBox3_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dttTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            string selectedTime = dttTimeEnd.Value.ToString("HH:mm");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dttTimeStart_ValueChanged(object sender, EventArgs e)
        {
            string selectedTime = dttTimeStart.Value.ToString("HH:mm");
        }

        

        private void ccbxSchool_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void DisableControls()
        {
            ccbxDay.Enabled = false;
            dttTimeStart.Enabled = false;
            dttTimeEnd.Enabled = false;
        }
        

        private void ccbxDay_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sgvStudyPeriod_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sgvStudyPeriod.Columns[e.ColumnIndex].Name == "Thứ")
            {
                // Lấy DataTable từ DataGridView
                DataTable table = (DataTable)sgvStudyPeriod.DataSource;

                // Dictionary ánh xạ thứ tự các ngày trong tuần
                Dictionary<string, int> dayOfWeekOrder = new Dictionary<string, int>()
            {
                { "Hai", 1 },
                { "Ba", 2 },
                { "Tư", 3 },
                { "Năm", 4 },
                { "Sáu", 5 },
                { "Bảy", 6 },
                { "Chủ Nhật", 7 }
            };

                // Sắp xếp DataTable dựa vào thứ tự các ngày trong tuần
                var sortedRows = table.AsEnumerable()
                                      .OrderBy(row => dayOfWeekOrder[row.Field<string>("Thứ")])
                                      .ThenBy(row => DateTime.Parse(row.Field<string>("Giờ bắt đầu")))
                                      .CopyToDataTable();

                // Gán lại DataSource cho DataGridView sau khi sắp xếp
                sgvStudyPeriod.DataSource = sortedRows;
            }
        }

        private void sgvStudyPeriod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = sgvStudyPeriod.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các control trên form
                ccbxDay.Text = selectedRow.Cells["Thứ"].Value.ToString();
                dttTimeStart.Text = selectedRow.Cells["Giờ bắt đầu"].Value.ToString();
                dttTimeEnd.Text = selectedRow.Cells["Giờ kết thúc"].Value.ToString();
                //dateTimePicker_Ngaysinh.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
                //textBox_Hocluc.Text = selectedRow.Cells["HocLuc"].Value.ToString();
            }
            // Kích hoạt các nút Sửa và Xóa
            customButton2.Enabled = true;
            customButton3.Enabled = true;
        }
        private int GetSelectedSubjectId()
        {
            if (ccbxSubject.SelectedItem is ComboBoxItem selectedSubject)
            {
                return selectedSubject.Id; // Get selected subjectId
            }

            // Handle case where no item is selected or invalid cast
            return -1; // Return -1 or any invalid value to indicate no valid selection
        }
        private void customButton6_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect group information
                DTO.Group newGroup = new Group
                {
                    GroupName = ctxbGroupName.Text,
                    NumMember = excelData.Rows.Count,
                    NumMaximumAbsent = int.Parse(customTextBox2.Text),
                    AccountId = this.accountId,
                    SubjectId = GetSelectedSubjectId()
                                       
                };

                // Step 1: Save the group
               // int groupId = groupBLL.GetNextGroupIdDAL();
                //groupBLL.CreateNewGroup(groupId, newGroup);
                newGroupId = groupBLL.CreateNewGroup(newGroup);
                //MessageBox.Show($"New Group ID: {newGroupId}", "Group Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Step 2: Save the schedules
                /***List<ScheduleDTO> schedules = new List<ScheduleDTO>();
                foreach (DataGridViewRow row in sgvStudyPeriod.Rows)
                {
                    schedules.Add(new ScheduleDTO
                    {
                        ShiftDay = row.Cells["Thứ"].Value.ToString(),
                        StartTime = TimeSpan.Parse(row.Cells["Giờ bắt đầu"].Value.ToString()),
                        EndTime = TimeSpan.Parse(row.Cells["Giờ kết thúc"].Value.ToString()),
                        SubjectId = newGroup.SubjectId
                    });
                }***/
                //groupBLL.SaveGroupSchedule(groupId, schedules);
                SaveGroupSchedule();


                // Step 3: Save students from excelData
                //groupBLL.SaveStudentsToGroup(groupId, excelData);
                AddStudentsFromExcelToDatabase(excelData);
                MessageBox.Show("Group and related data saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void SaveGroupSchedule()
        {
            //List<ScheduleDTO> schedules = new List<ScheduleDTO>();
            foreach (DataGridViewRow row in sgvStudyPeriod.Rows)
            {
                var newSchedule = new ScheduleDTO
                {
                    ShiftDay = row.Cells["Thứ"].Value.ToString(),
                    StartTime = TimeSpan.Parse(row.Cells["Giờ bắt đầu"].Value.ToString()),
                    EndTime = TimeSpan.Parse(row.Cells["Giờ kết thúc"].Value.ToString()),
                    SubjectId = GetSelectedSubjectId(),
                    GroupId = newGroupId
                };
                scheduleBLL.InsertScheduleDLA(newSchedule);
            }
        }
        private void AddStudentsFromExcelToDatabase(DataTable excelData)
        {
            foreach (DataRow row in excelData.Rows)
            {
                // Extract the MSSV (ID), first name, and last name from the DataTable.
                int studentId = int.Parse(row["MSSV"].ToString()); // Use MSSV from the imported data
                string firstName = row["FirstName"].ToString();
                string lastName = row["LastName"].ToString();
                
                // Create the new StudentDTO object
                var newStudent = new StudentDTO
                {
                    Id = studentId, // Use MSSV as the unique ID for the student
                    FirstName = firstName,
                    LastName = lastName,
                    STT = studentBLL.GetNextStudentIdDAL(), // Get the next available STT
                    GroupId = newGroupId// Include the GroupId from GroupInfo
                };

                // Add the new student
                int studentIdOutput; // This will hold the ID of the added student
                studentBLL.AddStudentDAL(newStudent, out studentIdOutput); // Assuming AddStudent is already properly defined
                studentBLL.LinkStudentToGroupDAL(newStudent.Id, newGroupId);
                // Optionally, display a message for each added student
                //MessageBox.Show("Student added successfully with ID: " + studentIdOutput);
            }

            // Reload the students after adding them
            //LoadStudents();

            // Clear the text box if needed
            //tbxStudent.Text = string.Empty;
        }


        private void ResetFormState()
        {
            // Xóa sạch các TextBox và ComboBox
            ccbxDay.SelectedIndex = -1;
            dttTimeStart.Value = DateTime.Now;
            dttTimeEnd.Value = DateTime.Now;

            // Vô hiệu hóa nút Lưu và các TextBox
            customButton1.Enabled = false;
            ccbxDay.Enabled = false;
            dttTimeStart.Enabled = false;
            dttTimeEnd.Enabled = false;
            
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            ccbxDay.Enabled = true;
            dttTimeStart.Enabled = true;
            dttTimeEnd.Enabled = true;
            customButton1.Enabled = true;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string day = ccbxDay.Text;
            string startTime = dttTimeStart.Value.ToString("HH:mm");
            string endTime = dttTimeEnd.Value.ToString("HH:mm");

            // Add the values to the DataTable as a new row
            if (string.IsNullOrEmpty(day))
            {
                MessageBox.Show("Vui lòng chọn thứ trong ComboBox.");
                return;
            }

            // Add the values to the DataTable as a new row
            table.Rows.Add(day, startTime, endTime);

            // Optional: Force DataGridView to refresh and display the new data
            //dataGridView1.DataSource = null; // Clear the old binding
            sgvStudyPeriod.DataSource = table; // Re-bind the updated DataTable

            // Optional: Show a message to confirm row added
            MessageBox.Show($"Đã thêm: {day}, {startTime} - {endTime}");
            //MessageBox.Show("This is a test message.");
            ResetFormState();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows();
        }
        private void DeleteSelectedRows()
        {
            // Hiện hộp thoại xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Xóa hàng đã chọn từ DataGridView
                for (int i = sgvStudyPeriod.Rows.Count - 1; i >= 0; i--)
                {
                    // Kiểm tra nếu ô checkbox được chọn
                    DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)sgvStudyPeriod.Rows[i].Cells[0];
                    if (checkBox.Value != null && (bool)checkBox.Value == true)
                    {
                        // Xóa hàng khỏi DataGridView
                        sgvStudyPeriod.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void ccbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool isEditing = false;
        private void customButton2_Click(object sender, EventArgs e)
        {
            if (!isEditing) // First click: enable controls and load selected row data
            {
                ccbxDay.Enabled = true;
                dttTimeStart.Enabled = true;
                dttTimeEnd.Enabled = true;

                EditSelectedRow();
                isEditing = true; // Set editing state to true
            }
            else // Second click: save changes
            {
                SaveSelectedRow();
                ResetFormState();
                isEditing = false; // Reset editing state
            }
        }

        private void EditSelectedRow()
        {
            for (int i = 0; i < sgvStudyPeriod.Rows.Count; i++)
            {
                // Kiểm tra nếu ô checkbox được chọn
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)sgvStudyPeriod.Rows[i].Cells[0];
                if (checkBox.Value != null && (bool)checkBox.Value == true)
                {
                    // Điền thông tin từ hàng đã chọn vào các điều khiển
                    ccbxDay.Text = sgvStudyPeriod.Rows[i].Cells["Thứ"].Value.ToString();
                    dttTimeStart.Value = DateTime.Parse(sgvStudyPeriod.Rows[i].Cells["Giờ bắt đầu"].Value.ToString());
                    dttTimeEnd.Value = DateTime.Parse(sgvStudyPeriod.Rows[i].Cells["Giờ kết thúc"].Value.ToString());
                    break; // Chỉ cần một hàng được chọn
                }
            }
        }
        private void SaveSelectedRow()
        {
            bool hasSelectedRow = false; // Variable to check if any row is selected

            for (int i = 0; i < sgvStudyPeriod.Rows.Count; i++)
            {
                // Check if the checkbox cell is selected
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)sgvStudyPeriod.Rows[i].Cells[0];
                if (checkBox.Value != null && (bool)checkBox.Value == true)
                {
                    // Update the selected row with the new values
                    string day = ccbxDay.Text; // Get value from comboBox
                    string startTime = dttTimeStart.Value.ToString("hh:mm tt"); // Get start time
                    string endTime = dttTimeEnd.Value.ToString("hh:mm tt"); // Get end time

                    // Update the cells in the row
                    sgvStudyPeriod.Rows[i].Cells["Thứ"].Value = day;
                    sgvStudyPeriod.Rows[i].Cells["Giờ bắt đầu"].Value = startTime;
                    sgvStudyPeriod.Rows[i].Cells["Giờ kết thúc"].Value = endTime;

                    hasSelectedRow = true; // Mark that at least one row has been updated
                    break; // Stop after updating the first selected row
                }
            }

            // Check if any row was updated
            if (!hasSelectedRow)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*** Phần comboBox trường khoa môn ***/
        private void LoadSchools()
        {
            var school = schoolBLL.GetSchoolByIdDLA(this.schoolId);
            ccbxSchool.Items.Add(new ComboBoxItem { Name = school.SchoolName, Id = school.Id }); // Use ComboBoxItem
            ccbxSchool.SelectedIndex = 0; // Automatically select the first item.
            ccbxSchool.Enabled = false; // Lock the school selection
        }
        private void LoadFaculties()
        {
            // Load faculties based on schoolId
            var faculties = schoolBLL.GetFacultiesBySchoolIdDLA(this.schoolId);
            ccbxDepartment.Items.Clear(); // Clear existing items

            foreach (var faculty in faculties)
            {
                ccbxDepartment.Items.Add(new ComboBoxItem { Name = faculty.FacultyName, Id = faculty.Id }); // Use ComboBoxItem
            }

            if (ccbxDepartment.Items.Count > 0)
            {
                ccbxDepartment.SelectedIndex = 0; // Select the first faculty if available
            }
        }

        private void LoadSubjects()
        {
            if (ccbxDepartment.SelectedItem is ComboBoxItem selectedFaculty)
            {
                int selectedFacultyId = selectedFaculty.Id; // Get selected faculty Id
                var subjects = schoolBLL.GetSubjectsByFacultyIdDLA(selectedFacultyId);
                ccbxSubject.Items.Clear(); // Clear existing items

                foreach (var subject in subjects)
                {
                    ccbxSubject.Items.Add(new ComboBoxItem { Name = subject.SubjectName, Id = subject.Id }); // Use ComboBoxItem
                }

                if (ccbxSubject.Items.Count > 0)
                {
                    ccbxSubject.SelectedIndex = 0; // Select the first subject if available
                }
            }
        }
        public class ComboBoxItem
        {
            public string Name { get; set; }  // Store the name
            public int Id { get; set; }        // Store the ID

            // Override ToString method to display the name in the ComboBox
            public override string ToString()
            {
                return Name; // This will be displayed in the ComboBox
            }
        }

        /*** IMPORT FILE EXCEL ***/

        private void InitializeDataGridViewImportFile()
        {
            
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            importFileTable.Columns.Add("Loại dữ liệu", typeof(string)); // Data type (e.g., MSSV)
            importFileTable.Columns.Add("Cột", typeof(string)); // Excel Column (A, B, etc.)
            //importFileTable.Rows.Add("MSSV", "A");
            //importFileTable.Rows.Add("FirstName", "B");
            //importFileTable.Rows.Add("LastName", "C");
            dataGridView1.DataSource = importFileTable;
            dataGridView1.ReadOnly = false;

            // Initialize DataGridView2 (for group info and student data)
            //dataGridView2.AllowUserToAddRows = false;
            //dataGridView2.RowHeadersVisible = false;
            //dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView2.Columns.Add("Group", "Tên nhóm");
            //dataGridView2.Columns.Add("Field", "Trường");
            //dataGridView2.Columns.Add("Department", "Khoa");
            //dataGridView2.Columns.Add("Subject", "Môn");

            //dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
        }
        private void cbtnImportFile_Click(object sender, EventArgs e)
        {
            try
            {
                LoadExcel(); // Try loading the Excel file
                label3.Text = $"Rows: {excelData.Rows.Count}";
            }
            catch (InvalidOperationException ex)
            {
                // Show the error message to the user
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Optionally, you can also log the error or perform other actions
            }
        }

        private void LoadExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null)
                    {
                        MessageBox.Show("Could not find a worksheet in the Excel file.");
                        return;
                    }

                    int rowCount = worksheet.Dimension.Rows;
                    int startRow = 2;
                    if (int.TryParse(customTextBox1.Text, out int parsedRow) && parsedRow > 1)
                    {
                        startRow = parsedRow;
                    }

                    excelData.Clear();
                    excelData.Columns.Clear();

                    foreach (DataRow row in importFileTable.Rows)
                    {
                        string columnName = row["Loại dữ liệu"].ToString();
                        string columnLetter = row["Cột"].ToString();
                        int colIndex = ExcelColumnLetterToNumber(columnLetter);

                        if (!excelData.Columns.Contains(columnName))
                        {
                            excelData.Columns.Add(columnName);
                        }

                        for (int i = startRow; i <= rowCount; i++)
                        {
                            if (excelData.Rows.Count < i - startRow + 1)
                            {
                                excelData.Rows.Add(excelData.NewRow());
                            }

                            excelData.Rows[i - startRow][columnName] = worksheet.Cells[i, colIndex].Value?.ToString();
                        }
                    }
                }
            }
        }
        private int ExcelColumnLetterToNumber(string columnLetter)
        {
            int sum = 0;
            foreach (char c in columnLetter)
            {
                sum *= 26;
                sum += (c - 'A' + 1);
            }
            return sum;
        }

        private void ccbxDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctxbGroupName_Load(object sender, EventArgs e)
        {

        }
    }
}

/*** Step 1: Install the EPPlus NuGet Package
Using Package Manager Console: Open the Package Manager Console in Visual Studio (found under Tools -> NuGet Package Manager -> Package Manager Console) and run the following command:

Install-Package EPPlus
Using NuGet Package Manager:

Right-click on your project in the Solution Explorer.
Choose "Manage NuGet Packages..."
Search for EPPlus and click "Install".

Step 2: Import the EPPlus Namespace
After installing the package, you can use it in your code. You need to add a using directive at the top of your C# file:


using OfficeOpenXml;***/

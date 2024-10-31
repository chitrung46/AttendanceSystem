using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class CRUDSubjectForm : Form
    {
        private SchoolBLL schoolBLL = new SchoolBLL();
        private FacultyBLL facultyBLL = new FacultyBLL();
        private subjectBLL subjectBLL = new subjectBLL();
        private int editingRowIndex = -1;
        private bool isEditing = false;



        public CRUDSubjectForm()
        {
            InitializeComponent();

            // Thiết lập trạng thái ban đầu cho các control
            dataGridView1.Enabled = true;
            textBox_subject.Enabled = false;
            textBox_subject.ReadOnly = true;
            button_luu.Enabled = false;
            button_xoa.Enabled = false;
            button_sua.Enabled = false;
            button_huy.Enabled = false;
            comboBoxSchool.Enabled = false;
            comboBoxFaculty.Enabled = false;

            // Thêm cột checkbox vào DataGridView
            AddCheckBoxColumn();

            // Nạp dữ liệu
            LoadSchoolData();    // Nạp dữ liệu trường
                                 // Không gọi LoadFacultyData() ở đây, chỉ gọi khi người dùng chọn trường
            LoadSubjectData();   // Nạp dữ liệu môn học
            // Optional: Set column header styles (if necessary)
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Gắn sự kiện CellClick cho DataGridView
            dataGridView1.CellClick += dataGridView1_CellClick;
            // Gắn sự kiện CellClick cho DataGridView
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;


            // Đặt DataGridView thành ReadOnly để không thể chỉnh sửa trực tiếp
            dataGridView1.ReadOnly = true;


            // Không cho phép thêm hoặc xóa hàng trực tiếp từ DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        // Thêm cột checkbox vào DataGridView
        private void AddCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            

            // Đặt AutoSizeMode cho cột
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Đặt độ rộng cho cột
            checkBoxColumn.Width = 30;

            dataGridView1.Columns.Insert(0, checkBoxColumn); // Thêm cột checkbox vào vị trí đầu tiên
        }


        // Xử lý khi checkbox thay đổi trạng thái
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Xử lý khi người dùng chọn checkbox
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bool isChecked = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);

                if (isChecked)
                {
                    // Khi checkbox được chọn, bạn có thể lấy dữ liệu từ hàng đó và thực hiện hành động cần thiết
                    textBox_subject.Text = row.Cells["Tên Môn"].Value?.ToString();
                    comboBoxFaculty.Text = row.Cells["Tên Khoa"].Value?.ToString();
                    comboBoxSchool.Text = row.Cells["Tên Trường"].Value?.ToString();
                    textBox_subject.ReadOnly = true; // Đảm bảo TextBox chỉ đọc ban đầu
                    // Bật TextBox và nút Lưu khi chọn một dòng
                    textBox_subject.Enabled = true;
                    button_luu.Enabled = true;
                    button_xoa.Enabled = true;
                }
            }
        }

        //Load data from school to datagridview
        private void LoadSchoolData()
        {
            List<School> schoolList = schoolBLL.GetSchoolList();
            dataGridView1.Rows.Clear();

            foreach (School school in schoolList)
            {
                dataGridView1.Rows.Add(school.SchoolName);
                dataGridView1.Columns["schoolName"].HeaderText = "Tên trường";
            }

            if (schoolList != null)
            {
                //Set data from combobox
                comboBoxSchool.DataSource = schoolList;
                comboBoxSchool.DisplayMember = "schoolName";
                comboBoxSchool.ValueMember = "id";

                // Đặt giá trị mặc định (placeholder)
                comboBoxSchool.SelectedIndex = -1;
                comboBoxSchool.Text = "-- Chọn Trường --";
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trường học.");
            }
        }


        //Load data from faculty to datagridview
        //Load data from faculty to combobox based on selected school
        private void LoadFacultyData(int schoolId)
        {
            // Lấy danh sách khoa dựa trên ID trường
            DataTable dtFaculties = facultyBLL.GetFacultiesBySchoolId(schoolId);

            if (dtFaculties != null && dtFaculties.Rows.Count > 0)
            {
                // Thiết lập dữ liệu cho ComboBox khoa
                comboBoxFaculty.DataSource = dtFaculties;
                comboBoxFaculty.DisplayMember = "facultyName";  // Hiển thị tên khoa
                comboBoxFaculty.ValueMember = "id";  // ID khoa

                comboBoxFaculty.SelectedIndex = -1;  // Đặt mặc định không chọn khoa nào
                comboBoxFaculty.Text = "-- Chọn Khoa --";  // Hiển thị văn bản placeholder
            }
            else
            {
                // Nếu không có khoa nào cho trường đã chọn, xóa dữ liệu trong ComboBox khoa
                comboBoxFaculty.DataSource = null;
                comboBoxFaculty.Text = "-- Không có khoa --";  // Hiển thị thông báo không có dữ liệu
            }
        }




        //Load data from subject
        // Load data from subject
        private void LoadSubjectData()
        {
            DataTable dtSubject = subjectBLL.GetAllSubjectsWithDetails();

            if (dtSubject != null && dtSubject.Rows.Count > 0)
            {
                dataGridView1.DataSource = dtSubject;

                // Sắp xếp thứ tự cột hiển thị
                //dataGridView1.Columns["checkBoxColumn"].DisplayIndex = 0;
                dataGridView1.Columns["Tên Trường"].DisplayIndex = 1;  // Hiển thị cột "Tên Trường" trước tiên
                dataGridView1.Columns["Tên Khoa"].DisplayIndex = 2;    // Sau đó là cột "Tên Khoa"
                dataGridView1.Columns["Tên Môn"].DisplayIndex = 3;     // Cuối cùng là cột "Tên Môn"
                                                                       // Ẩn cột SubjectID
                dataGridView1.Columns["SubjectID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu Trường, Khoa và Môn");
            }
        }




        private void ClearFields()
        {
            comboBoxSchool.SelectedIndex = -1;  // Đặt ComboBox về mặc định (không chọn)
            textBox_subject.Text = string.Empty;  // Xóa TextBox nhập khoa
            editingRowIndex = -1;  // Đặt lại chỉ số hàng đang chỉnh sửa
        }


        private void customButton10_Click(object sender, EventArgs e)
        {
            // Bật TextBox và nút Lưu để nhập liệu
            textBox_subject.Enabled = true;
            textBox_subject.ReadOnly = false;
            button_luu.Enabled = true;
            comboBoxSchool.Enabled = true;
            comboBoxFaculty.Enabled = true;

            // Xóa nội dung trong TextBox để chuẩn bị cho việc thêm mới
            textBox_subject.Text = String.Empty;

        }

        private void customButton4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSchool_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSchool.SelectedItem != null)
            {
                // Lấy ID của trường đã chọn
                int selectedSchoolId = Convert.ToInt32(((DataRowView)comboBoxSchool.SelectedItem)["id"]);

                // Tải dữ liệu khoa dựa trên ID trường đã chọn
                LoadFacultyData(selectedSchoolId);
            }
        }

        private void comboBoxFaculty_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFaculty.SelectedItem != null)
            {
                // Hiển thị thông tin khoa đã chọn hoặc thực hiện các xử lý liên quan
                string selectedFaculty = ((DataRowView)comboBoxFaculty.SelectedItem)["facultyName"].ToString();
                //MessageBox.Show($"Selected Faculty: {selectedFaculty}");
            }
        }

        private void textBox_subject_Load(object sender, EventArgs e)
        {

        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy hàng hiện tại từ DataGridView
                DataGridViewRow row = dataGridView1.CurrentRow;

                // Kiểm tra và lấy ID của môn học (SubjectID)
                if (row.Cells["SubjectID"] != null && int.TryParse(row.Cells["SubjectID"].Value.ToString(), out int id))
                {
                    // Xác nhận trước khi xóa
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Gọi phương thức BLL để xóa môn học
                        bool success = subjectBLL.DeleteSubject(id);

                        if (success)
                        {
                           
                            LoadSubjectData();  // Nạp lại dữ liệu sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Xóa môn học thất bại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy giá trị ID hợp lệ từ hàng đã chọn.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }


        private void button_luu_Click(object sender, EventArgs e)
        {
            if (comboBoxSchool.SelectedItem != null && comboBoxFaculty.SelectedItem != null)
            {
                // Lấy ID của trường từ ComboBox
                int selectedSchoolId = Convert.ToInt32(((DataRowView)comboBoxSchool.SelectedItem)["id"]);

                // Lấy ID của Khoa từ ComboBox
                int selectedFacultyId = Convert.ToInt32(((DataRowView)comboBoxFaculty.SelectedItem)["id"]);

                // Lấy tên môn từ TextBox
                string subjectName = textBox_subject.Text.Trim();

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(subjectName))
                {
                    MessageBox.Show("Tên môn học không được để trống.");
                    return;
        }

                // Kiểm tra môn học đã tồn tại trong cùng trường và khoa hay chưa
                if (subjectBLL.CheckIfSubjectExists(subjectName, selectedFacultyId))
                {
                    MessageBox.Show("Môn học này đã tồn tại trong cùng trường và khoa.");
                    return;
    }

                // Nếu đang trong chế độ chỉnh sửa
                if (isEditing && editingRowIndex >= 0)
                {
                    // Kiểm tra nếu không có SubjectID (DBNull), thì thực hiện thêm mới
                    if (dataGridView1.Rows[editingRowIndex].Cells["SubjectID"].Value == DBNull.Value)
                    {
                        // Thêm mới môn học
                        AddNewSubject(subjectName, selectedFacultyId);
}
                    else
                    {
                        // Nếu có SubjectID, thì thực hiện cập nhật
                        int subjectId = Convert.ToInt32(dataGridView1.Rows[editingRowIndex].Cells["SubjectID"].Value);
                        UpdateExistingSubject(subjectId, subjectName, selectedFacultyId);
                    }
                }
                else
                {
                    // Thêm mới môn học khi không phải đang chỉnh sửa
                    AddNewSubject(subjectName, selectedFacultyId);
                }

                // Sau khi hoàn tất, đặt lại TextBox về trạng thái chỉ đọc
                textBox_subject.ReadOnly = true;
                button_luu.Enabled = false;
                button_sua.Enabled = false;
                button_xoa.Enabled = false;
                button_huy.Enabled = false;
                textBox_subject.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Trường và Khoa.");
            }
        }


        private void AddNewSubject(string subjectName, int selectedFacultyId)
        {
            // Tạo đối tượng Subject mới
            Subject newSubject = new Subject
            {
                subjectName = subjectName,
                facultyId = selectedFacultyId
            };

            // Gọi phương thức BLL để thêm Subject mới
            bool isInserted = subjectBLL.InsertSubject(newSubject);

            if (isInserted)
            {
                MessageBox.Show("Thêm môn học thành công!");

                // Cập nhật lại DataGridView sau khi thêm môn học mới
                LoadSubjectData();

                // Xóa nội dung TextBox và đặt lại ComboBox về trạng thái mặc định
                ClearFields();
            }
            else
            {
                MessageBox.Show("Thêm môn học thất bại. Vui lòng thử lại.");
            }
        }

        private void UpdateExistingSubject(int subjectId, string subjectName, int selectedFacultyId)
        {
            // Tạo đối tượng Subject mới
            Subject updatedSubject = new Subject
            {
                id = subjectId,
                subjectName = subjectName,
                facultyId = selectedFacultyId
            };

            // Gọi phương thức BLL để cập nhật Subject
            bool isUpdated = subjectBLL.UpdateSubject(updatedSubject);

            if (isUpdated)
            {
                MessageBox.Show("Cập nhật môn học thành công!");

                // Cập nhật lại DataGridView sau khi sửa
                LoadSubjectData();

                // Reset lại trạng thái
                ClearFields();
                isEditing = false;
                editingRowIndex = -1;
            }
            else
            {
                MessageBox.Show("Cập nhật môn học thất bại. Vui lòng thử lại.");
            }
        }





        private void button_huy_Click(object sender, EventArgs e)
        {
            ClearFields();
            textBox_subject.ReadOnly = true;  // Đặt lại trạng thái chỉ đọc
            button_luu.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            textBox_subject.Enabled = false;
            comboBoxSchool.Enabled = false;
            comboBoxFaculty.Enabled = false;
            LoadSubjectData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi ấn chọn 1 dòng trong DataGridView
            if (dataGridView1.Enabled && e.RowIndex >= 0)
            {
                //đặt trạng thai đang sửa
                isEditing = true;
                editingRowIndex = e.RowIndex;

                //Hiển thị dữ liệu của dòng đó lên các control
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_subject.Text = row.Cells["Tên Môn"].Value.ToString();


                //Enable các control
                textBox_subject.Enabled = true;
                button_xoa.Enabled = true;
            }

        }

        // Xử lý sự kiện khi chọn một dòng trong DataGridView cho phần môn học
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn vào cột checkbox (cột đầu tiên)
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["checkBoxColumn"].Index)
            {
                // Lấy dòng hiện tại trong DataGridView
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Bỏ dấu tích tất cả các checkbox trước đó
                foreach (DataGridViewRow rowToClear in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = rowToClear.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                    if (checkBox != null)
                    {
                        checkBox.Value = false; // Bỏ dấu tích checkbox
                        rowToClear.DefaultCellStyle.BackColor = Color.White;
                    }
                }

                // Đánh dấu checkbox của dòng hiện tại
                DataGridViewCheckBoxCell currentCheckBox = selectedRow.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                if (currentCheckBox != null)
                {
                    currentCheckBox.Value = true; // Đánh dấu checkbox của dòng được chọn
                }
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue;
                selectedRow.DefaultCellStyle.SelectionBackColor = Color.LightBlue;  // Đảm bảo màu khi dòng được chọn


                // Gán giá trị từ cột "Tên Môn" vào TextBox môn học
                textBox_subject.Text = selectedRow.Cells["Tên Môn"].Value?.ToString();

                // Gán giá trị từ cột "Tên Khoa" vào ComboBox khoa
                string facultyName = selectedRow.Cells["Tên Khoa"].Value?.ToString();
                if (!string.IsNullOrEmpty(facultyName))
                {
                    // Tìm và gán giá trị vào ComboBoxFaculty
                    foreach (var item in comboBoxFaculty.Items)
                    {
                        DataRowView rowView = item as DataRowView;
                        if (rowView != null && rowView["facultyName"].ToString() == facultyName)
                        {
                            comboBoxFaculty.SelectedItem = rowView;
                            break;
                        }
                    }
                }

                // Gán giá trị từ cột "Tên Trường" vào ComboBox trường
                string schoolName = selectedRow.Cells["Tên Trường"].Value?.ToString();
                if (!string.IsNullOrEmpty(schoolName))
                {
                    // Tìm và gán giá trị vào ComboBoxSchool
                    foreach (var item in comboBoxSchool.Items)
                    {
                        DataRowView rowView = item as DataRowView;
                        if (rowView != null && rowView["sschoolName"].ToString() == schoolName)
                        {
                            comboBoxSchool.SelectedItem = rowView;
                            break;
                        }
                    }
                }

                // Bật các nút hành động
                button_luu.Enabled = true;
                button_sua.Enabled = true;
                button_xoa.Enabled = true;
                button_huy.Enabled = true;
            }
        }






        // Sự kiện khi thay đổi lựa chọn ComboBox
        private void comboBoxSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSchool.SelectedItem != null)
            {
                // Lấy ID của trường đã chọn
                int selectedSchoolId = Convert.ToInt32(((DataRowView)comboBoxSchool.SelectedItem)["id"]);

                // Tải dữ liệu khoa dựa trên ID trường đã chọn
                LoadFacultyData(selectedSchoolId);
            }
        }


        // Sự kiện khi thay đổi lựa chọn ComboBox
        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFaculty.SelectedItem != null)
            {
                // Hiển thị khoa đã chọn
                MessageBox.Show($"Selected Faculty: {((DataRowView)comboBoxFaculty.SelectedItem)["facultyName"].ToString()}");
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            // Bật TextBox cho phép người dùng chỉnh sửa dữ liệu môn học
            textBox_subject.Enabled = true;
            textBox_subject.ReadOnly = false; // Nếu trước đó có đặt TextBox là chỉ đọc
            comboBoxFaculty.Enabled = true;
            comboBoxSchool.Enabled = true;

            // Bật nút "Lưu" và tắt nút "Sửa"
            button_luu.Enabled = true;
            button_huy.Enabled = true;


            // Đặt trạng thái đang chỉnh sửa
            isEditing = true;
        }


    }
}


using System;
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
using System.Drawing;
using System.Collections.Generic;


namespace GUI
{
    public partial class CRUDFacultyForm : Form
    {
        private SchoolBLL schoolBLL = new SchoolBLL();  // Sử dụng đối tượng SchoolBLL đã khai báo
        private FacultyBLL facultyBLL = new FacultyBLL();
        private int editingRowIndex = -1;
        private bool isEditing = false;

        // Constructor
        public CRUDFacultyForm()
        {
            InitializeComponent();  // Đảm bảo rằng các control được khởi tạo trước khi sử dụng chúng

            // Thiết lập trạng thái ban đầu cho các control
            dataGridView1.Enabled = true;
            textBox_faculty.Enabled = false;
            textBox_faculty.ReadOnly = true;  // TextBox sẽ chỉ đọc ban đầu
            button_luu.Enabled = false;
            button_xoa.Enabled = false;
            button_sua.Enabled = false;
            button_huy.Enabled = false;
            comboBoxSchool.Enabled = false;

            // Thêm cột checkbox vào DataGridView
            AddCheckBoxColumn();

            // Tải dữ liệu vào ComboBox và DataGridView khi khởi tạo form
            LoadSchoolData();
            LoadSchoolAndFacultyData();

            // Optional: Set column header styles (if necessary)
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Gắn sự kiện CellClick cho DataGridView
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Gắn sự kiện CellClick cho DataGridView
            dataGridView1.CellClick += dataGridView1_CellClick;
            // Gắn sự kiện CellClick cho DataGridView
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;

            // Không cho phép thêm hoặc xóa hàng trực tiếp từ DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }
        // Thêm cột checkbox vào DataGridView
        private void AddCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.HeaderText = "Chọn";
            //checkBoxColumn.Name = "checkBoxColumn";

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
                    textBox_faculty.Text = row.Cells["Tên Khoa"].Value?.ToString();
                    comboBoxSchool.Text = row.Cells["Tên Trường"].Value?.ToString();

                    textBox_faculty.ReadOnly = true; // Đảm bảo TextBox chỉ đọc ban đầu
                    button_luu.Enabled = false;  // Tắt nút lưu để tránh nhầm lẫn
                }
            }
        }


        // Phương thức tải dữ liệu vào ComboBox (Danh sách trường)
        private void LoadSchoolData()
        {
            List<School> schoolList = schoolBLL.GetSchoolList();

            //if (dtSchools != null && dtSchools.Rows.Count > 0)
            //{
            //    comboBoxSchool.DataSource = dtSchools;
            //    comboBoxSchool.DisplayMember = "sschoolName";  // Tên trường để hiển thị
            //    comboBoxSchool.ValueMember = "id";             // ID trường
            //    comboBoxSchool.SelectedIndex = -1;             // Để không có trường nào được chọn mặc định
            //    comboBoxSchool.Text = "-- Chọn Trường --";     // Hiển thị văn bản mặc định
            //}
            //else
            //{
            //    MessageBox.Show("Không có dữ liệu trường học.");
            //}
        }




        // Phương thức tải dữ liệu khoa vào DataGridView
        private void LoadSchoolAndFacultyData()
        {
            // Gọi phương thức từ lớp BLL để lấy danh sách tất cả các trường và khoa
            DataTable dtSchoolFaculties = facultyBLL.GetAllSchoolFaculties();

            if (dtSchoolFaculties != null && dtSchoolFaculties.Rows.Count > 0)
            {
                // Hiển thị dữ liệu trong DataGridView
                dataGridView1.DataSource = dtSchoolFaculties;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu Trường và Khoa.");
            }

            // Ẩn cột ID trong DataGridView nếu không cần thiết
            if (dataGridView1.Columns["id"] != null)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
        }



        private void ClearFields()
        {
            comboBoxSchool.SelectedIndex = -1;  // Đặt ComboBox về mặc định (không chọn)
            textBox_faculty.Text = string.Empty;  // Xóa TextBox nhập khoa
            editingRowIndex = -1;  // Đặt lại chỉ số hàng đang chỉnh sửa
        }

        // Xử lý sự kiện khi chọn một dòng trong DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn vào cột checkbox (cột đầu tiên)
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["checkBoxColumn"].Index)
            {
                // Lấy hàng hiện tại trong DataGridView
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


                // Cập nhật thông tin của dòng vào các control
                textBox_faculty.Text = selectedRow.Cells["Tên Khoa"].Value?.ToString();
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
                

                // Bật các nút liên quan khi đã chọn một hàng
                textBox_faculty.Enabled = true;
                button_luu.Enabled = true;
                button_xoa.Enabled = true;
                button_sua.Enabled = true;
            }
        }







        // Sự kiện khi thay đổi lựa chọn ComboBox
        private void comboBoxSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSchool.SelectedItem != null)
            {
                MessageBox.Show($"Selected School: {((DataRowView)comboBoxSchool.SelectedItem)["sschoolName"].ToString()}");
            }
        }


        // Sự kiện khi nhấn nút "Thêm"
        private void button_them_Click(object sender, EventArgs e)
        {
            // Bật TextBox và nút Lưu để nhập liệu
            textBox_faculty.ReadOnly = false;
            textBox_faculty.Enabled = true;
            comboBoxSchool.Enabled = true;
            button_luu.Enabled = true;
            button_huy.Enabled = true;
            // Xóa nội dung trong TextBox để chuẩn bị cho việc thêm mới
            textBox_faculty.Text = String.Empty;
        }


        private void comboBoxSchool_OnSelectedIndexChanged(object sender, EventArgs e)
        {


            // Sự kiện lưu dữ liệu
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
                textBox_faculty.Text = row.Cells["Tên Khoa"].Value.ToString();


                //Enable các control
                textBox_faculty.Enabled = true;
                button_xoa.Enabled = true;
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row.Cells["id"] != null && int.TryParse(row.Cells["id"].Value.ToString(), out int id))
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool success = facultyBLL.DeleteFaculty(id);
                        if (success)
                        {
                        
                            LoadSchoolAndFacultyData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Khoa thất bại.");
                        }
                    }
                }
            }
        }


            private void button_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox_faculty.ReadOnly = false;  // Cho phép chỉnh sửa TextBox
                button_luu.Enabled = true;
                button_xoa.Enabled = true;
                button_huy.Enabled = true;
                comboBoxSchool.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }


        private void button_luu_Click(object sender, EventArgs e)
        {
            if (comboBoxSchool.SelectedItem != null)
            {
                int selectedSchoolId = Convert.ToInt32(((DataRowView)comboBoxSchool.SelectedItem)["id"]);
                string facultyName = textBox_faculty.Text.Trim();

                if (string.IsNullOrEmpty(facultyName))
                {
                    MessageBox.Show("Tên Khoa không được để trống.");
                    return;
                }

                // Kiểm tra nếu Khoa đã tồn tại trong cùng một Trường
                if (facultyBLL.IsFacultyExist(facultyName, selectedSchoolId))
                {
                    MessageBox.Show("Khoa này đã tồn tại trong trường đã chọn.");
                    return;
                }

                // Nếu đang trong chế độ sửa
                if (isEditing && editingRowIndex >= 0)
                {
                    // Kiểm tra nếu ID của hàng là DBNull thì xử lý thêm mới
                    if (dataGridView1.Rows[editingRowIndex].Cells["id"].Value == DBNull.Value)
                    {
                        // Nếu không có ID, đây là bản ghi mới
                        AddNewFaculty(facultyName, selectedSchoolId);
                    }
                    else
                    {
                        // Nếu có ID, thì đây là thao tác sửa bản ghi hiện có
                        int facultyId = Convert.ToInt32(dataGridView1.Rows[editingRowIndex].Cells["id"].Value);
                        UpdateExistingFaculty(facultyId, facultyName, selectedSchoolId);
                    }
                }
                else
                {
                    // Thêm mới Khoa
                    AddNewFaculty(facultyName, selectedSchoolId);
                }
                // Sau khi hoàn tất, đặt lại TextBox về trạng thái chỉ đọc
                textBox_faculty.ReadOnly = true;
                button_luu.Enabled = false;
                button_sua.Enabled = false;
                button_xoa.Enabled = false;
                button_huy.Enabled = false;
                textBox_faculty.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Trường.");
            }
        }


        private void AddNewFaculty(string facultyName, int selectedSchoolId)
        {
            Faculty newFaculty = new Faculty
            {
                facultyName = facultyName,
                schoolId = selectedSchoolId
            };

            try
            {
                bool success = facultyBLL.InsertFaculty(newFaculty);
                if (success)
                {
                    MessageBox.Show("Thêm mới Khoa thành công.");
                    LoadSchoolAndFacultyData();  // Tải lại dữ liệu sau khi thêm mới
                    ClearFields();
                    textBox_faculty.ReadOnly = true;
                    button_luu.Enabled = false;
                    button_sua.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Thêm mới Khoa thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void UpdateExistingFaculty(int facultyId, string facultyName, int selectedSchoolId)
        {
            Faculty updatedFaculty = new Faculty
            {
                id = facultyId,
                facultyName = facultyName,
                schoolId = selectedSchoolId
            };

            try
            {
                bool success = facultyBLL.UpdateFaculty(updatedFaculty);
                if (success)
                {
                    MessageBox.Show("Cập nhật Khoa thành công.");
                    LoadSchoolAndFacultyData();  // Tải lại dữ liệu sau khi cập nhật
                    ClearFields();
                    textBox_faculty.ReadOnly = true;
                    button_luu.Enabled = false;
                    button_sua.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cập nhật Khoa thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }




        private void button_huy_Click(object sender, EventArgs e)
        {
            ClearFields();
            textBox_faculty.ReadOnly = true;
            button_luu.Enabled = false;
            button_sua.Enabled = false;
            comboBoxSchool.Enabled = false;
            textBox_faculty.Enabled = false;
        }

    }
}

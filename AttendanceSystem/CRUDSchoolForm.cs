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

namespace GUI
{
    public partial class CRUDSchoolForm : Form
    {
        private SchoolBLL schoolBLL = new SchoolBLL();
        private int editingRowIndex = -1;
        private bool isEditing = false;

        public CRUDSchoolForm()
        {
            InitializeComponent();
            LoadData();

            // Vô hiệu hóa DataGridView và các control khi form khởi tạo
            dataGridView1.Enabled = true;
            textBox_name.Enabled = false;
            textBox_name.ReadOnly = true;
            button_luu.Enabled = false;
            button_xoa.Enabled = false;
            button_sua.Enabled = false;
            button_huy.Enabled = false;


            // Thêm cột checkbox vào DataGridView
            AddCheckBoxColumn();

            // Optional: Set column header styles (if necessary)
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

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
                    textBox_name.Text = row.Cells["sschoolName"].Value?.ToString();

                    // Bật TextBox và nút Lưu khi chọn một dòng
                    textBox_name.Enabled = true;
                    button_luu.Enabled = true;
                    button_xoa.Enabled = true;
                }
            }
        }

        private void LoadData()
        {
            dataGridView1.DataSource = schoolBLL.GetAllSchools();

            // Đảm bảo cột "id" được ẩn nếu không cần thiết
            if (dataGridView1.Columns["id"] != null)
            {
                dataGridView1.Columns["id"].Visible = false;
            }

            // Đổi tên cột "sschoolName" thành "Tên Trường"
            if (dataGridView1.Columns["sschoolName"] != null)
            {
                dataGridView1.Columns["sschoolName"].HeaderText = "Tên Trường";
            }
        }



        private void ClearFields()
        {
            textBox_name.Text = string.Empty;
            editingRowIndex = -1;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            // Kích hoạt các control để cho phép thêm mới
            textBox_name.Enabled = true;
            button_luu.Enabled = true;  // Bật nút lưu
            ClearFields(); // Xóa các trường nhập liệu cũ
            isEditing = false; // Đặt trạng thái không phải đang sửa
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại trong DataGridView
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ cột "Tên Trường" vào TextBox
                textBox_name.Text = row.Cells["sschoolName"].Value?.ToString();

                // Bỏ dấu tích tất cả các checkbox trước đó và đặt màu trắng lại cho tất cả các dòng
                foreach (DataGridViewRow rowToClear in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = rowToClear.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                    if (checkBox != null)
                    {
                        checkBox.Value = false; // Bỏ dấu tích checkbox
                        rowToClear.DefaultCellStyle.BackColor = Color.White; // Đặt lại màu trắng cho tất cả các dòng
                    }
                }

                // Đánh dấu checkbox của dòng hiện tại
                DataGridViewCheckBoxCell currentCheckBox = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                if (currentCheckBox != null)
                {
                    currentCheckBox.Value = true; // Đánh dấu checkbox của dòng được chọn
                }

                // Đổi màu nền của dòng được chọn để bôi xanh
                row.DefaultCellStyle.BackColor = Color.LightBlue;
                row.DefaultCellStyle.SelectionBackColor = Color.LightBlue;  // Đảm bảo màu khi dòng được chọn

                // Bật các nút Lưu, Xóa và Sửa sau khi chọn dòng
                button_luu.Enabled = true;
                button_xoa.Enabled = true;
                button_sua.Enabled = true;
            }
        }



        private void button_them_Click_1(object sender, EventArgs e)
        {
            // Kích hoạt các control để cho phép thêm mới
            textBox_name.ReadOnly = false;
            textBox_name.Enabled = true;
            button_luu.Enabled = true;  
            button_huy.Enabled = true;
            ClearFields(); // Xóa các trường nhập liệu cũ
            isEditing = false; // Đặt trạng thái không phải đang sửa

        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                // Lấy ID của trường từ hàng hiện tại
                if (int.TryParse(row.Cells["id"].Value.ToString(), out int id))
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool success = schoolBLL.DeleteSchool(id);

                        if (success)
                        {

                            LoadData(); // Nạp lại dữ liệu sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!");
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
                textBox_name.Text = row.Cells["sschoolName"].Value.ToString();

                //Enable các control
                textBox_name.Enabled = true;
                button_xoa.Enabled = true;
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Kích hoạt các control để sửa thông tin
                textBox_name.Enabled = true;
                textBox_name.ReadOnly = false;
                button_luu.Enabled = true;
                

                DataGridViewRow row = dataGridView1.CurrentRow;
                textBox_name.Text = row.Cells["sschoolName"].Value.ToString();

                isEditing = true;
                editingRowIndex = dataGridView1.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

            ClearFields();
            dataGridView1.Enabled = true;
            textBox_name.Enabled = false;
            button_luu.Enabled = false;
            button_sua.Enabled = false;
            LoadData();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Đang trong chế độ sửa, cập nhật thông tin trường học
                if (editingRowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[editingRowIndex];

                    // Lấy ID của trường hiện tại
                    int schoolId = Convert.ToInt32(row.Cells["id"].Value);

                    // Tạo đối tượng mới với thông tin sửa đổi
                    School updatedSchool = new School
                    {
                        id = schoolId,
                        sschoolName = textBox_name.Text.Trim()
                    };

                    // Kiểm tra tên trường có bị trùng hay không trước khi cập nhật
                    if (schoolBLL.IsSchoolNameExists(updatedSchool.sschoolName, schoolId))
                    {
                        MessageBox.Show("Tên trường đã tồn tại. Vui lòng chọn tên khác.");
                        return; // Ngừng xử lý nếu tên trường đã tồn tại
                    }

                    // Gọi phương thức BLL để cập nhật thông tin
                    bool success = schoolBLL.UpdateSchool(updatedSchool);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật thông tin trường thành công!");

                        // Tải lại dữ liệu sau khi sửa
                        LoadData();
                        ClearFields();

                        isEditing = false;
                        button_sua.Enabled = true;
                        button_luu.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
                    }
                }
            }
            else
            {
                // Thêm mới trường học
                if (!string.IsNullOrEmpty(textBox_name.Text))
                {
                    // Tạo đối tượng mới
                    School newSchool = new School
                    {
                        sschoolName = textBox_name.Text.Trim()
                    };

                    // Kiểm tra tên trường có bị trùng hay không trước khi thêm mới
                    if (schoolBLL.IsSchoolNameExists(newSchool.sschoolName))
                    {
                        MessageBox.Show("Tên trường đã tồn tại. Vui lòng chọn tên khác.");
                        return; // Ngừng xử lý nếu tên trường đã tồn tại
                    }

                    // Gọi phương thức BLL để thêm mới
                    bool success = schoolBLL.AddSchool(newSchool);
                    if (success)
                    {
                        MessageBox.Show("Thêm mới trường học thành công!");

                        // Tải lại dữ liệu sau khi thêm mới
                        LoadData();
                        ClearFields();

                        button_luu.Enabled = false;
                        button_sua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại. Vui lòng thử lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Tên trường không được để trống.");
                }
            }
        }




        private void button_luu_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Đang trong chế độ sửa, cập nhật thông tin trường học
                if (editingRowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[editingRowIndex];

                    // Lấy ID của trường hiện tại
                    int schoolId = Convert.ToInt32(row.Cells["id"].Value);

                    // Tạo đối tượng mới với thông tin sửa đổi
                    School updatedSchool = new School
                    {
                        id = schoolId,
                        sschoolName = textBox_name.Text.Trim()
                    };

                    // Kiểm tra tên trường có bị trùng hay không trước khi cập nhật
                    if (schoolBLL.IsSchoolNameExists(updatedSchool.sschoolName, schoolId))
                    {
                        MessageBox.Show("Tên trường đã tồn tại. Vui lòng chọn tên khác.");
                        return; // Ngừng xử lý nếu tên trường đã tồn tại
                    }

                    // Gọi phương thức BLL để cập nhật thông tin
                    bool success = schoolBLL.UpdateSchool(updatedSchool);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật thông tin trường thành công!");

                        // Tải lại dữ liệu sau khi sửa
                        LoadData();
                        ClearFields();

                        isEditing = false;
                        button_luu.Enabled = false;
                        button_sua.Enabled = false;
                        button_xoa.Enabled = false;
                        button_huy.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
                    }
                }
            }
            else
            {
                // Thêm mới trường học
                if (!string.IsNullOrEmpty(textBox_name.Text))
                {
                    // Tạo đối tượng mới
                    School newSchool = new School
                    {
                        sschoolName = textBox_name.Text.Trim()
                    };

                    // Kiểm tra tên trường có bị trùng hay không trước khi thêm mới
                    if (schoolBLL.IsSchoolNameExists(newSchool.sschoolName))
                    {
                        MessageBox.Show("Tên trường đã tồn tại. Vui lòng chọn tên khác.");
                        return; // Ngừng xử lý nếu tên trường đã tồn tại
                    }

                    // Gọi phương thức BLL để thêm mới
                    bool success = schoolBLL.AddSchool(newSchool);
                    if (success)
                    {
                        MessageBox.Show("Thêm mới trường học thành công!");

                        // Tải lại dữ liệu sau khi thêm mới
                        LoadData();
                        ClearFields();

                        button_luu.Enabled = false;
                        button_sua.Enabled = true;
                        textBox_name.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại. Vui lòng thử lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Tên trường không được để trống.");
                }
            }
        }
    }
}

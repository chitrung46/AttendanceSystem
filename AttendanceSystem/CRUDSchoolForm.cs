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
        private bool isButtonSaveEnbled = false;
        private bool isButtonUpdateEnbled = false;
        private bool isButtonDeleteEnbled = false;
        private bool isButtonCancelEnbled = false;

        public CRUDSchoolForm()
        {
            InitializeComponent();
            LoadData();

            textBox_name.ReadOnly = true;

            isButtonSaveEnbled = false;
            isButtonUpdateEnbled = false;
            isButtonDeleteEnbled = false;
            isButtonCancelEnbled = false;
        }
        
        private void LoadData()
        {
            List<School> schoolList = schoolBLL.GetSchoolList();
            dataGridView1.Rows.Clear();

            foreach (School school in schoolList)
            {
                int rowIndex = dataGridView1.Rows.Add(false, school.SchoolName);
                dataGridView1.Rows[rowIndex].Tag = school.Id;
            }
            dataGridView1.CurrentCell = null;
        }

        private void ClearFields()
        {
            textBox_name.Text = string.Empty;
            editingRowIndex = -1;
        }

        private void button_them_Click_1(object sender, EventArgs e)
        {
            // Kích hoạt các control để cho phép thêm mới
            textBox_name.ReadOnly = false;
            isButtonSaveEnbled = true;  
            isButtonCancelEnbled = true;
            ClearFields(); // Xóa các trường nhập liệu cũ
            isEditing = false; // Đặt trạng thái không phải đang sửa
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (isButtonDeleteEnbled && dataGridView1.CurrentCell != null)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow row = dataGridView1.CurrentRow;

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool success = schoolBLL.DeleteSchool((int)row.Tag);

                        if (success)
                        {

                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!");
                        }
                        ClearFields();
                    }
                    ClearFields();
                }
                isButtonDeleteEnbled= false;
                isButtonCancelEnbled = false;
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (isButtonUpdateEnbled && dataGridView1.CurrentCell != null)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Kích hoạt các control để sửa thông tin
                    textBox_name.ReadOnly = false;
                    isButtonSaveEnbled = true;
                    isButtonCancelEnbled = true;


                    DataGridViewRow row = dataGridView1.CurrentRow;
                    textBox_name.Text = row.Cells["schoolName"].Value.ToString();

                    isEditing = true;
                    editingRowIndex = dataGridView1.CurrentRow.Index;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                }
            } 
            isButtonUpdateEnbled= false;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (isButtonCancelEnbled)
            {
                ClearFields();
                dataGridView1.Enabled = true;
                textBox_name.ReadOnly = true;
                isButtonDeleteEnbled= false;
                isButtonUpdateEnbled= false;
                isButtonCancelEnbled= false;
                isButtonSaveEnbled= false;
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (isButtonSaveEnbled)
            {
                if (isEditing)
                {
                    // Đang trong chế độ sửa, cập nhật thông tin trường học
                    if (editingRowIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[editingRowIndex];

                        // Lấy ID của trường hiện tại
                        int schoolId = Convert.ToInt32(row.Tag);

                        // Tạo đối tượng mới với thông tin sửa đổi
                        School updatedSchool = new School
                        {
                            Id = schoolId,
                            SchoolName = textBox_name.Text.Trim()
                        };

                        // Kiểm tra tên trường có bị trùng hay không trước khi cập nhật
                        if (schoolBLL.IsSchoolNameExists(updatedSchool.SchoolName, schoolId))
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

                            isButtonSaveEnbled = false;
                            isButtonCancelEnbled = false;
                            isButtonUpdateEnbled = false;
                            isButtonDeleteEnbled = false;
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
                    if (!string.IsNullOrWhiteSpace(textBox_name.Text))
                    {
                        // Tạo đối tượng mới
                        School newSchool = new School
                        {
                            SchoolName = textBox_name.Text.Trim()
                        };

                        // Kiểm tra tên trường có bị trùng hay không trước khi thêm mới
                        if (schoolBLL.IsSchoolNameExists(newSchool.SchoolName))
                        {
                            MessageBox.Show("Tên trường đã tồn tại. Vui lòng chọn tên khác.");
                            return; // Ngừng xử lý nếu tên trường đã tồn tại
                        }

                        // Gọi phương thức BLL để thêm mới
                        bool success = schoolBLL.InsertSchool(newSchool);
                        if (success)
                        {
                            MessageBox.Show("Thêm mới trường học thành công!");

                            LoadData();
                            ClearFields();

                            isButtonCancelEnbled = false;
                            isButtonSaveEnbled = false;
                            isButtonUpdateEnbled = false;
                            isButtonDeleteEnbled = false;
                            textBox_name.ReadOnly = true;
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

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue;
                selectedRow.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

                DataGridViewCheckBoxCell currentCheckBox = selectedRow.Cells["checkBox"] as DataGridViewCheckBoxCell;
                if (currentCheckBox != null)
                {
                    currentCheckBox.Value = true;
                }
                isButtonUpdateEnbled = true;
                isButtonDeleteEnbled = true;
            }         
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.White;
                selectedRow.DefaultCellStyle.SelectionBackColor = Color.White;

                DataGridViewCheckBoxCell currentCheckBox = selectedRow.Cells["checkBox"] as DataGridViewCheckBoxCell;
                if (e.RowIndex >= 0 && currentCheckBox != null)
                {
                    currentCheckBox.Value = false;

                }
            }
        }

        private void CRUDSchoolForm_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell= null;
        }
    }
}

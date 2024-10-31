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
        private SchoolBLL schoolBLL = new SchoolBLL();  
        private FacultyBLL facultyBLL = new FacultyBLL();

        private int editingRowIndex = -1;
        private bool isEditing = false;
        private bool isBtnSaveEnabled;
        private bool isBtnCancelEnabled;
        private bool isBtnDeleteEnabled;
        private bool isBtnUpdateEnabled;

        public CRUDFacultyForm()
        {
            InitializeComponent();
            txtFaculty.ReadOnly = true;
            isBtnSaveEnabled = false;
            isBtnCancelEnabled = false;
            isBtnUpdateEnabled = false;
            isBtnDeleteEnabled = false;

            LoadTableData();
            LoadSchoolData();
        }

        private void LoadSchoolData()
        {
            List<School> schoolList = schoolBLL.GetSchoolList();
            cmbSchoolName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSchoolName.DataSource = schoolList;
            cmbSchoolName.DisplayMember = "schoolName";
            cmbSchoolName.ValueMember = "id";
            cmbSchoolName.SelectedIndex = -1;
            cmbSchoolName.Text = "-- Chọn Trường --";
        }

        private void LoadTableData()
        {
            List<Dictionary<string, object>> dataList = facultyBLL.GetFacultyNameListWithSchoolName();
            dgvFaculty.Rows.Clear();

            foreach (Dictionary<string, object> data in dataList)
            {
                dgvFaculty.Rows.Add(false, (int)data["id"], (int)data["schoolId"], (string)data["facultyName"], (string)data["schoolName"]);
            }
            dgvFaculty.CurrentCell = null;
        }

        private void ClearFields()
        {
            cmbSchoolName.SelectedIndex = -1;  
            txtFaculty.Text = string.Empty;  
            editingRowIndex = -1; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFaculty.ReadOnly = false;
            cmbSchoolName.DropDownStyle = ComboBoxStyle.DropDownList;
            isBtnSaveEnabled = true;
            isBtnCancelEnabled= true;
            isEditing = false;
            ClearFields();
            LoadSchoolData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isBtnDeleteEnabled && dgvFaculty.CurrentCell != null)
            {
                if (dgvFaculty.CurrentRow != null)
                {
                    DataGridViewRow row = dgvFaculty.CurrentRow;

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool success = facultyBLL.DeleteFaculty((int)row.Cells["facultyId"].Value);
                        if (success)
                        {
                            LoadTableData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!");
                        } 
                        ClearFields();
                        LoadSchoolData();
                    }
                        
                }   ClearFields();
                LoadSchoolData();
            }
            isBtnDeleteEnabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isBtnUpdateEnabled && dgvFaculty.CurrentCell != null)
            {
                if (dgvFaculty.CurrentRow != null)
                {
                    DataGridViewRow row = dgvFaculty.CurrentRow;

                    cmbSchoolName.Text = (string)row.Cells["schoolName"].Value;
                    txtFaculty.Text = (string)row.Cells["facultyName"].Value;
                    isBtnSaveEnabled = true;
                    isBtnCancelEnabled = true;
                    txtFaculty.ReadOnly = false;
                    isEditing = true;
                    editingRowIndex = row.Index;
                }    
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isBtnCancelEnabled)
            {
                ClearFields();
                txtFaculty.ReadOnly = true;
                isBtnDeleteEnabled= false;
                isBtnUpdateEnabled = false;
                isBtnSaveEnabled = false;
                isBtnCancelEnabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isBtnSaveEnabled)
            {
                if (isEditing)
                {
                    if (editingRowIndex >= 0) 
                    {
                        DataGridViewRow row = dgvFaculty.Rows[editingRowIndex];
                        string schoolName = (string)cmbSchoolName.Text.Trim();
                        string facultyName = (string)txtFaculty.Text.Trim();
                        int facultyId = (int)row.Cells["facultyId"].Value;
                        int schoolId = schoolBLL.GetSchoolByName(schoolName).Id;

                        if (facultyBLL.IsFacultyExist(facultyName, schoolId))
                        {
                            MessageBox.Show("Thông tin khoa đã tồn tại. Vui lòng thử lại");
                            return;
                        }

                        Faculty updateFaculty = new Faculty
                        {
                            Id = facultyId,
                            FacultyName = facultyName,
                            SchoolId = schoolId
                        };

                        bool success = facultyBLL.UpdateFaculty(updateFaculty);
                        if (success)
                        {
                            MessageBox.Show("Cập nhật thông tin khoa thành công!");

                            ClearFields();
                            LoadTableData();
                            LoadSchoolData();

                            isBtnSaveEnabled = false;
                            isBtnCancelEnabled = false;
                            isBtnUpdateEnabled = false;
                            isBtnDeleteEnabled = false;
                            txtFaculty.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
                        }

                    }
                }
                else //Add Faculty
                {
                    if (!string.IsNullOrWhiteSpace(txtFaculty.Text))
                    {
                        string schoolName = (string)cmbSchoolName.Text.Trim();
                        string facultyName = (string)txtFaculty.Text.Trim();
                        int schoolId = schoolBLL.GetSchoolByName(schoolName).Id;

                        if (facultyBLL.IsFacultyExist(facultyName, schoolId))
                        {
                            MessageBox.Show("Thông tin đã tồn tại. Vui lòng chọn nhập lại.");
                            return; 
                        }

                        bool success = facultyBLL.InsertFaculty(facultyName, schoolId);
                        if (success)
                        {
                            MessageBox.Show("Thêm mới khoa thành công!");

                            LoadTableData();
                            LoadSchoolData();
                            ClearFields();

                            isBtnSaveEnabled = false;
                            isBtnCancelEnabled = false;
                            isBtnUpdateEnabled = false;
                            isBtnDeleteEnabled = false;
                            txtFaculty.ReadOnly = true;
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

        private void dgvFaculty_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFaculty.Rows[e.RowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue;
                selectedRow.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

                DataGridViewCheckBoxCell currentCheckBox = selectedRow.Cells["checkBox"] as DataGridViewCheckBoxCell;
                if (currentCheckBox != null)
                {
                    currentCheckBox.Value = true;
                }
                editingRowIndex= e.RowIndex;
                isBtnUpdateEnabled = true;
                isBtnDeleteEnabled = true;
                cmbSchoolName.Text = (string)selectedRow.Cells["schoolName"].Value;
                txtFaculty.Text = (string)selectedRow.Cells["facultyName"].Value;
            }
        }

        private void dgvFaculty_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFaculty.Rows[e.RowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.White;
                selectedRow.DefaultCellStyle.SelectionBackColor = Color.White;

                DataGridViewCheckBoxCell currentCheckBox = selectedRow.Cells["checkBox"] as DataGridViewCheckBoxCell;
                if (e.RowIndex >= 0 && currentCheckBox != null)
                {
                    currentCheckBox.Value = false;

                }
            }
        }

        private void CRUDFacultyForm_Click(object sender, EventArgs e)
        {
            dgvFaculty.ClearSelection();
            dgvFaculty.CurrentCell = null;
            cmbSchoolName.SelectedIndex = -1;
            cmbSchoolName.Text = "-- Chọn Trường --";
            txtFaculty.Text = string.Empty;
        }

        private void dgvFaculty_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvFaculty.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvFaculty.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}

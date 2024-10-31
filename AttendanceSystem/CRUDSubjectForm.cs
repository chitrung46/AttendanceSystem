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
        private bool isBtnSaveEnabled;
        private bool isBtnCancelEnabled;
        private bool isBtnDeleteEnabled;
        private bool isBtnUpdateEnabled;

        public CRUDSubjectForm()
        {
            InitializeComponent();

            txtSubjectName.ReadOnly = true;
            isBtnSaveEnabled = false;
            isBtnCancelEnabled = false;
            isBtnUpdateEnabled = false;
            isBtnDeleteEnabled = false;

            LoadTableData();
            LoadSchoolData();
            LoadFacultyData();
        }

        //Load data from school to datagridview
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

        private void LoadFacultyData()
        {
            List<Faculty> facultyList = new List<Faculty>();
            string schoolName;

            if (cmbSchoolName.SelectedIndex != -1)
            {
                schoolName = (string)cmbSchoolName.Text.Trim();
                facultyList = facultyBLL.GetFacultyBySchoolName(schoolName);

                cmbFacultyName.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbFacultyName.DataSource = facultyList;
                cmbFacultyName.DisplayMember = "facultytName";
                cmbFacultyName.ValueMember = "facultyName";
                cmbFacultyName.SelectedIndex = -1;
                cmbFacultyName.Text = "-- Chọn Khoa --";
            }
        }

        private void LoadTableData()
        {
            List<Dictionary<string, object>> dataList = subjectBLL.GetSubjectNameListWithSchoolNameAndFacultyName();
            dgvSubject.Rows.Clear();

            foreach (Dictionary<string, object> data in dataList)
            {
                dgvSubject.Rows.Add(false, (int)data["subjectId"], (int)data["facultyId"], (int)data["schoolId"], (string)data["subjectName"], (string)data["facultyName"], (string)data["schoolName"]);
            }
            dgvSubject.CurrentCell = null;
        }

        private void ClearFields()
        {
            cmbSchoolName.SelectedIndex = -1;
            cmbFacultyName.SelectedIndex = -1;
            txtSubjectName.Text = string.Empty;
            editingRowIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSubjectName.ReadOnly = false;
            cmbSchoolName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFacultyName.DropDownStyle = ComboBoxStyle.DropDownList;
            isBtnSaveEnabled = true;
            isBtnCancelEnabled = true;
            isEditing = false;
            ClearFields();
            LoadSchoolData();
            LoadFacultyData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isBtnDeleteEnabled && dgvSubject.CurrentCell != null)
            {
                if (dgvSubject.CurrentRow != null)
                {
                    DataGridViewRow row = dgvSubject.CurrentRow;

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool success = subjectBLL.DeleteSubject((int)row.Cells["subjectId"].Value);
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
                        LoadFacultyData();
                    }

                }
                ClearFields();
                LoadSchoolData();
                LoadFacultyData();
            }
            isBtnDeleteEnabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isBtnUpdateEnabled && dgvSubject.CurrentCell != null)
            {
                if (dgvSubject.CurrentRow != null)
                {
                    DataGridViewRow row = dgvSubject.CurrentRow;

                    cmbSchoolName.Text = (string)row.Cells["schoolName"].Value;
                    cmbFacultyName.Text = (string)row.Cells["facultyName"].Value;
                    txtSubjectName.Text = (string)row.Cells["subjectName"].Value;
                    isBtnSaveEnabled = true;
                    isBtnCancelEnabled = true;
                    txtSubjectName.ReadOnly = false;
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
                txtSubjectName.ReadOnly = true;
                isBtnDeleteEnabled = false;
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
                        DataGridViewRow row = dgvSubject.Rows[editingRowIndex];
                        string schoolName = (string)cmbSchoolName.Text.Trim();
                        string facultyName = (string)cmbFacultyName.Text.Trim();
                        string subjectName = (string)txtSubjectName.Text.Trim();
                        int subjectId = (int)row.Cells["subjectId"].Value;
                        int schoolId = schoolBLL.GetSchoolByName(schoolName).Id;
                        int facultyId = facultyBLL.GetFacultyByName(facultyName).Id;


                        if (subjectBLL.IsSubjectExist(subjectName, facultyId, schoolId))
                        {
                            MessageBox.Show("Thông tin môn học đã tồn tại. Vui lòng thử lại");
                            return;
                        }

                        Subject updateSubject = new Subject
                        {
                            Id = subjectId,
                            SubjectName = subjectName,
                            FacultyId = facultyId
                        };

                        bool success = subjectBLL.UpdateSubject(updateSubject);
                        if (success)
                        {
                            MessageBox.Show("Cập nhật thông tin ,môn học thành công!");

                            ClearFields();
                            LoadTableData();
                            LoadSchoolData();
                            LoadFacultyData();

                            isBtnSaveEnabled = false;
                            isBtnCancelEnabled = false;
                            isBtnUpdateEnabled = false;
                            isBtnDeleteEnabled = false;
                            txtSubjectName.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
                        }

                    }
                }
                else 
                {
                    if (!string.IsNullOrWhiteSpace(txtSubjectName.Text))
                    {
                        string schoolName = (string)cmbSchoolName.Text.Trim();
                        string facultyName = (string)txtSubjectName.Text.Trim();
                        string subjectName = (string)txtSubjectName.Text.Trim();
                        int facultyId = facultyBLL.GetFacultyByName(facultyName).Id;
                        int schoolId = schoolBLL.GetSchoolByName(schoolName).Id;

                        if (subjectBLL.IsSubjectExist(subjectName, facultyId, schoolId))
                        {
                            MessageBox.Show("Thông tin đã tồn tại. Vui lòng nhập lại.");
                            return;
                        }

                        bool success = subjectBLL.InsertSubject(subjectName, facultyId);
                        if (success)
                        {
                            MessageBox.Show("Thêm mới môn học thành công!");

                            LoadTableData();
                            LoadSchoolData();
                            LoadFacultyData();
                            ClearFields();

                            isBtnSaveEnabled = false;
                            isBtnCancelEnabled = false;
                            isBtnUpdateEnabled = false;
                            isBtnDeleteEnabled = false;
                            txtSubjectName.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới thất bại. Vui lòng thử lại.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên môn học không được để trống.");
                    }
                }
            }
        }

        private void dgvSubject_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSubject.Rows[e.RowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue;
                selectedRow.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

                DataGridViewCheckBoxCell currentCheckBox = selectedRow.Cells["checkBox"] as DataGridViewCheckBoxCell;
                if (currentCheckBox != null)
                {
                    currentCheckBox.Value = true;
                }
                editingRowIndex = e.RowIndex;
                isBtnUpdateEnabled = true;
                isBtnDeleteEnabled = true;
                cmbSchoolName.Text = (string)selectedRow.Cells["schoolName"].Value;
                cmbFacultyName.Text = (string)selectedRow.Cells["facultyName"].Value;
                txtSubjectName.Text = (string)selectedRow.Cells["subjectName"].Value;
            }
        }

        private void dgvSubject_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSubject.Rows[e.RowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.White;
                selectedRow.DefaultCellStyle.SelectionBackColor = Color.White;

                DataGridViewCheckBoxCell currentCheckBox = selectedRow.Cells["checkBox"] as DataGridViewCheckBoxCell;
                if (e.RowIndex >= 0 && currentCheckBox != null)
                {
                    currentCheckBox.Value = false;

                }
            }
        }

        private void CRUDSubjectForm_Click(object sender, EventArgs e)
        {
            dgvSubject.ClearSelection();
            dgvSubject.CurrentCell = null;
            cmbSchoolName.SelectedIndex = -1;
            cmbSchoolName.Text = "-- Chọn Trường --";
            cmbFacultyName.SelectedIndex = -1;
            cmbFacultyName.Text = "-- Chọn Khoa --";
            txtSubjectName.Text = string.Empty;
        }

        private void dgvSubject_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSubject.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvSubject.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}


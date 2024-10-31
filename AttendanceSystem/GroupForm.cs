using AttendanceSystem;
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
    public partial class GroupForm : Form
    {
        GroupBLL groupBLL = new GroupBLL();
        private int accountId;
        private int schoolId = 1;
        public GroupForm(int accountId)
        {
            InitializeComponent();
            this.accountId = accountId;
            this.Load += new EventHandler(GroupForm_Load); // Đăng ký sự kiện Load
        }
        private void GroupForm_Load(object sender, EventArgs e)
        {
            LoadGroupInformation();
            dgvGroupInformation.ReadOnly = true;
            dgvGroupInformation.Columns.Clear();
            dgvGroupInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        private void LoadGroupInformation()
        {
            
            List<GroupInfo> groupList = groupBLL.GetGroupInfoByAccountIdAndSchoolIdDLA(accountId, schoolId);
            dgvGroupInformation.DataSource = groupList;
            dgvGroupInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void customTextBox3_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateGroupForm createGroupForm = new CreateGroupForm(this.accountId, this.schoolId);
            createGroupForm.Show();
        }

        private void dgvGroupInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGroupInformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /***
            if (e.RowIndex >= 0) // Đảm bảo rằng chỉ có hàng hợp lệ được chọn
            {
                
                // Lấy thông tin nhóm
                string groupName = dgvGroupInformation.Rows[e.RowIndex].Cells["GroupName"].Value.ToString();
                LoadStudentForm(groupName);
            }***/
            if (e.RowIndex >= 0) // Ensure that only valid rows are selected
            {
                // Create a new GroupDTO from the selected row
                int groupId = (int)dgvGroupInformation.Rows[e.RowIndex].Cells["GroupId"].Value;
                string groupName = dgvGroupInformation.Rows[e.RowIndex].Cells["GroupName"].Value.ToString();
                string schoolName = dgvGroupInformation.Rows[e.RowIndex].Cells["SchoolName"].Value.ToString();
                string facultyName = dgvGroupInformation.Rows[e.RowIndex].Cells["FacultyName"].Value.ToString();
                string subjectName = dgvGroupInformation.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();

                GroupInfo selectedGroup = new GroupInfo(groupId, groupName, schoolName, facultyName, subjectName);

                // Load the student form with the selected group
                LoadStudentForm(selectedGroup);
            }

        }
        private void LoadStudentForm(GroupInfo group)
        {
            StudentForm studentForm = new StudentForm(group);
            // Kiểm tra nếu homeForm đã được thiết lập
            if(this.Tag is HomeForm home)
    {
                home.loadForm(studentForm); // Gọi loadForm từ Home
            }
        }
    }
}

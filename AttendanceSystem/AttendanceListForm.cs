using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Tackle get data from API Google Sheets
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System.Threading;
using System.Collections;
using System.Net;
using System.Windows.Controls;
using DTO;
using BLL;

namespace GUI
{
    public partial class AttendanceListForm : Form
    {
        private string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly }; // Specify the required scopes
        private string serviceAccountCredentialFilePath = "credentials/credential.json"; // Path to your service account file
        private Session session;
        ImageBLL imageBLL = new ImageBLL();
        AttendanceBLL attendanceBLL = new AttendanceBLL();
        private PictureBox picture;
        private string limitTime;

        public AttendanceListForm(Session session, string limitTime)
        {
            InitializeComponent();
            this.session = session;
            this.limitTime = limitTime;
        }

        private void AttendanceListForm_Load(object sender, EventArgs e)
        {

        }

        private Stream DownloadImage(string imageUrl)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageBytes = client.DownloadData(imageUrl);
                    return new MemoryStream(imageBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}");
                return null; // Return null in case of an error
            }
        }

        private string relativePath(string subPath)
        {
            string fullPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..", "..", subPath);
            return fullPath;
        }

        private async void handleImportDataGridView()
        {
            IList<IList<Object>> values = await handleDataSheet();
            MessageBox.Show("Tải hoàn tất");
            //check lenght of values
            if (!dataGridViewAttendance.Columns.Contains("image_url")
                && !dataGridViewAttendance.Columns.Contains("location")
                && !dataGridViewAttendance.Columns.Contains("attendance_code")
                && !dataGridViewAttendance.Columns.Contains("student_code")
                && !dataGridViewAttendance.Columns.Contains("name")
                && !dataGridViewAttendance.Columns.Contains("time")
                && !dataGridViewAttendance.Columns.Contains("checkbox"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = "checkBox";
                dataGridViewAttendance.Columns.Add(checkBoxColumn);

                dataGridViewAttendance.Columns.Add("number", "Số thứ tự");
                dataGridViewAttendance.Columns.Add("name", "Họ và tên");
                dataGridViewAttendance.Columns.Add("student_code", "Mã số sinh viên");
                dataGridViewAttendance.Columns.Add("attendance_code", "Mã điểm danh");
                dataGridViewAttendance.Columns.Add("location", "Vị trí");
                dataGridViewAttendance.Columns.Add("time", "Thời gian");

                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Hình ảnh";
                imgColumn.Name = "image_url";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridViewAttendance.Columns.Add(imgColumn);

                //Change size of column 
                dataGridViewAttendance.Columns[0].Width = 30;
                //dataGridViewAttendance.Columns[1].Width = 75;
                //dataGridViewAttendance.Columns[6].Width = 65;
            }

            foreach (var row in values)
            {
                bool isExist = false;
                if (dataGridViewAttendance.Rows.Count > 0)
                {
                    foreach (DataGridViewRow checkRow in dataGridViewAttendance.Rows)
                    {
                        if (checkRow.Cells[3].Value != null && checkRow.Cells[3].Value.ToString() == row[2].ToString())
                        {
                            isExist = true;
                            break;
                        }
                    }
                }
                if (isExist == false)
                {          
                    Stream stream = DownloadImage(row[4].ToString());
                    PictureBox pictureBox = new PictureBox();
                    System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                    int rowIndex = dataGridViewAttendance.Rows.Count + 1;
                    dataGridViewAttendance.Rows.Add(false, rowIndex, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[5], image);        
                    dataGridViewAttendance.Rows[rowIndex-1].Tag = row[4].ToString();
                }
            }
            

        }

        private async Task<IList<IList<Object>>> handleDataSheet()
        {
            // Load the service account credential file
            GoogleCredential credential;
            using (var stream = new FileStream(relativePath(serviceAccountCredentialFilePath), FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                                             .CreateScoped(Scopes);  // Specify scopes here
            }

            // Create the Google Sheets API service
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "YourAppName",
            });

            // Define request parameters
            string spreadsheetId = "1MzRoL9K0djJ0F_qgsiz60obSAPxvMyA5L-F5_ZSESGc";  // Add your spreadsheet ID
            string range = "'Form Responses'!A2:F";  // Specify the range

            // Fetch the data from the Google Sheet
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            var response = await request.ExecuteAsync();
            Console.WriteLine("response is loading", response);

            // Parse and display data
            IList<IList<object>> values = response.Values;
            if (values != null && values.Count > 0)
            {

                return values;
            }
            else
            {
                return values;
            }
        }

        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                PictureBox pictureBox = showImageByPictureBox();
                pictureBox.Image = (System.Drawing.Image)dataGridViewAttendance.CurrentRow.Cells[7].Value;
                this.Controls.Add(pictureBox);
                pictureBox.BringToFront();
                this.picture = pictureBox;
                this.picture.Visible = true;
            }
        }

        private PictureBox showImageByPictureBox()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 300;
            pictureBox.Height = 300;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int newX = (formWidth - pictureBox.Width) / 2;
            int newY = (formHeight - pictureBox.Height) / 2;

            pictureBox.Location = new Point(newX, newY);

            return pictureBox;
        }


        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            handleImportDataGridView();

        }

        private void AttendanceListForm_Click(object sender, EventArgs e)
        {
            if (this.picture != null)
            {
                this.picture.Visible = false;
                dataGridViewAttendance.CurrentCell = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAttendance.CurrentCell != null)
            {
                int index = dataGridViewAttendance.CurrentCell.RowIndex; 

                if (index >= 0 && index < dataGridViewAttendance.Rows.Count)
                {
                    dataGridViewAttendance.Rows.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ô trong bảng trước khi xóa.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAttendance.Rows)
            {
                if (row.Cells[0].Value != null) 
                {
                    try
                    {
                        string codeQR = (string)row.Cells[4].Value;
                        int mssv = int.Parse(row.Cells[3].Value.ToString());
                        imageBLL.InsertImage(row.Tag.ToString());
                        int imageId = imageBLL.GetImageByURL(row.Tag.ToString()).Id;
                        attendanceBLL.InsertAttendance(row.Cells[6].Value.ToString().Trim(), "QR Code", "", codeQR, mssv, imageId, session.Id, limitTime);
                        MessageBox.Show("after");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tạo đối tượng Attendance từ hàng: " + ex.Message);
                    }
                }
            }
        }
    }
}

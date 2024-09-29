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


namespace GUI
{
    public partial class AttendanceListForm : Form
    {
        private string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly }; // Specify the required scopes
        private string serviceAccountCredentialFilePath = "E://Downloads/credentials.json"; // Path to your service account file

        public AttendanceListForm()
        {
            InitializeComponent();
        }

        private void AttendanceListForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private async void handleImportDataGridView()
        {
            IList<IList<Object>> values = await handleDataSheet();
            if( !dataGridViewAttendance.Columns.Contains("image_url")
                && !dataGridViewAttendance.Columns.Contains("submit_datetime")
                && !dataGridViewAttendance.Columns.Contains("location")
                && !dataGridViewAttendance.Columns.Contains("attendance_code")
                && !dataGridViewAttendance.Columns.Contains("student_code")
                && !dataGridViewAttendance.Columns.Contains("name"))
            {
                dataGridViewAttendance.Columns.Add("number", "Số thứ tự");
                dataGridViewAttendance.Columns.Add("name", "Họ và tên");
                dataGridViewAttendance.Columns.Add("student_code", "Mã số sinh viên");
                dataGridViewAttendance.Columns.Add("attendance_code", "Mã điểm danh");
                dataGridViewAttendance.Columns.Add("location", "Vị trí");
                dataGridViewAttendance.Columns.Add("submit_datetime", "Thời gian");

                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Hình ảnh";
                imgColumn.Name = "image_url";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridViewAttendance.Columns.Add(imgColumn);

                //Change size of column 
                dataGridViewAttendance.Columns[0].Width = 75;
                dataGridViewAttendance.Columns[6].Width = 65;


            }
            
            foreach (var row in values)
            {
                bool isExist = false;
                if(dataGridViewAttendance.Rows.Count > 0)
                {
                    foreach (DataGridViewRow checkRow in dataGridViewAttendance.Rows)
                    {
                        if(checkRow.Cells[2].Value.ToString() == row[2].ToString())
                        {
                            isExist = true;
                            break;
                        }
                    }
                }
                if(isExist == false)
                {
                    Stream stream = DownloadImage(row[5].ToString());
                    PictureBox pictureBox = new PictureBox();
                    System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                    int row_index = dataGridViewAttendance.Rows.Count + 1;
                    dataGridViewAttendance.Rows.Add(row_index, row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[0].ToString(), image);
                }
            }

        }

        private async Task<IList<IList<Object>>> handleDataSheet()
        {
            // Load the service account credential file
            GoogleCredential credential;
            using (var stream = new FileStream(serviceAccountCredentialFilePath, FileMode.Open, FileAccess.Read))
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
            string spreadsheetId = "1BOxPY_t0e1jTJgUyTx-nPxEe2BlxONhfnUE7EcpfQww";  // Add your spreadsheet ID
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
            if(e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                PictureBox pictureBox = showImageByPictureBox();
                pictureBox.Image = (System.Drawing.Image)dataGridViewAttendance.CurrentRow.Cells[6].Value;
                this.Controls.Add(pictureBox);
                pictureBox.BringToFront();
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

        private void customButton5_Click(object sender, EventArgs e)
        {
            handleImportDataGridView();

        }
    }
}

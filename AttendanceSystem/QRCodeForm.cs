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
using QRCoder;
using static System.Net.WebRequestMethods;

namespace GUI
{
    public partial class QRCodeForm : Form
    {
        private TimeSpan countdownTime; // TimeSpan to hold countdown duration
        private Timer countdownTimer; // Timer for countdown
        private bool isCountdownRunning = false;
        private string timeQRCode;
        private int groupId;
        private SessionBLL sessionBLL = new SessionBLL();

        public QRCodeForm(int groupId)
        {
            InitializeComponent();
            this.groupId = groupId;
        }

        private void createQRCode(string url)
        {
            try
            {
                QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
                var data = qr.CreateQrCode(url, QRCoder.QRCodeGenerator.ECCLevel.M);
                var code = new QRCoder.QRCode(data);
                pictureQRCode.Image = code.GetGraphic(20);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkIsEmptyTime(MaskedTextBox mtxtBox)
        {
            Console.WriteLine(mtxtBox.MaskedTextProvider.ToDisplayString());
            if (mtxtBox.MaskedTextProvider.ToDisplayString().Contains('_'))
            {
                return true;
            }
            return false;
        }

        private string[] splitTimeFromMaskTextBox(string time)
        {
            string[] timeArray = time.Split(':');
            return timeArray;
        }
        public string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void StartCountdown()
        {
            countdownTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdownTime.TotalSeconds > 0)
            {
                countdownTime = countdownTime.Subtract(TimeSpan.FromSeconds(1));
                lblTiming.Text = countdownTime.ToString(@"hh\:mm\:ss").Replace(":", " : ");
            }
            else
            {
                countdownTimer.Stop();
                countdownTime.ToString(@"hh\:mm\:ss").Replace(":", " : ");
                btnOpenData.Visible = true;
                createQRCode("Hết Thời gian điểm danh");
            }
        }

        private void btnOpenData_Click(object sender, EventArgs e)
        {
            Session session = new Session
            {
                SessionName = sessionBLL.GetNewSessionName(groupId),
                SessionTime = DateTime.Now,
                Code = txtCode.Text,
                GroupId = groupId
            };
            AttendanceListForm attendanceListForm = new AttendanceListForm(session);
            attendanceListForm.Show();
            this.Close();
        }

        private void QRCodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isCountdownRunning)
            {
                DialogResult notify = MessageBox.Show("Quá trình điểm danh" +
                    " đang diễn ra, bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (notify == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }    
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!checkIsEmptyTime(mtxtTime))
            {
                timeQRCode = mtxtTime.Text;
                string randomCode = GenerateRandomCode(6);
                txtCode.Text = randomCode;

                string time = timeQRCode;
                string url = "https://attendance-app-opal-chi.vercel.app/";
                createQRCode(url);

                //Handle time from maskTextBox
                string[] time_arr = splitTimeFromMaskTextBox(time);

                int hour = Int32.Parse(time_arr[0]);
                int minute = Int32.Parse(time_arr[1]);
                int second = Int32.Parse(time_arr[2]);
                countdownTime = new TimeSpan(hour, minute, second);
                lblTiming.Text = countdownTime.ToString(@"hh\:mm\:ss").Replace(":", " : ");
                countdownTimer = new Timer();
                countdownTimer.Interval = 1000; // 1 second
                countdownTimer.Tick += timer1_Tick;
                StartCountdown();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }
        }
    }
}

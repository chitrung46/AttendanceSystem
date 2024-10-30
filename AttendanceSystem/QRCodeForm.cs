using QRCoder;
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
    public partial class QRCodeForm : Form
    {
        private TimeSpan countdownTime; // TimeSpan to hold countdown duration
        private Timer countdownTimer; // Timer for countdown

        public QRCodeForm()
        {
            InitializeComponent();
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

        private void QRCodeForm_Load(object sender, EventArgs e)
        {
            string url = EditQRCode.instance.urlQRCode;
            string time = EditQRCode.instance.timeQRCode;

            txtUrlToCopy.Text = url;
            createQRCode(url);

            //Handle time from maskTextBox
            string[] time_arr = splitTimeFromMaskTextBox(time);
            int hour = Int32.Parse(time_arr[0]);
            int minute = Int32.Parse(time_arr[1]);
            int second = Int32.Parse(time_arr[2]);
            countdownTime = new TimeSpan(hour, minute, second);
            lblTiming.Text =countdownTime.ToString(@"hh\:mm\:ss").Replace(":", " : ");
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += timer1_Tick;
            StartCountdown();
        }

        private string[] splitTimeFromMaskTextBox(string time)
        {
            string[] timeArray = time.Split(':');
            return timeArray;
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTiming_Click(object sender, EventArgs e)
        {

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
                string url = "https://form.jotform.com/";
                txtUrlToCopy.Text = url;
                createQRCode("Hết Thời gian điểm danh");
            }
        }

        private void btnOpenData_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void pictureQRCode_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}

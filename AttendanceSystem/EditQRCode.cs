using GUI.TruniControls;
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
    public partial class EditQRCode : Form
    {
        public static EditQRCode instance;
        public string urlQRCode;
        public string timeQRCode;
        public EditQRCode()
        {
            InitializeComponent();
            instance = this;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            QRCodeForm qrCode = new QRCodeForm();
            if (!checkIsEmptyCustomTxtBox(txtUrl) && !checkIsEmptyTime(mtxtTime))
            {
                urlQRCode = txtUrl.Texts; //get url from textBox
                timeQRCode = mtxtTime.Text;
                qrCode.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }
        }

        private bool checkIsEmptyCustomTxtBox(CustomTextBox txtBox)
        {
            if(txtBox.Texts == "")
            {
                return true;
            }
            return false;
        }

        private bool checkIsEmptyTime(MaskedTextBox mtxtBox)
        {
            Console.WriteLine(mtxtBox.MaskedTextProvider.ToDisplayString());
            if(mtxtBox.MaskedTextProvider.ToDisplayString().Contains('_'))
            { 
                return true;
            }
            return false;
        }

        private void EditQRCode_Load(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

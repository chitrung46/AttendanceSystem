using DTO;
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
        private int groupId;
        private Session session;
        public EditQRCode(int groupId)
        {
            InitializeComponent();
            instance = this;
            this.groupId = groupId;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            QRCodeForm qrCode = new QRCodeForm();
            if (!checkIsEmptyCustomTxtBox(txtUrl) && !checkIsEmptyTime(mtxtTime))
            {
                urlQRCode = txtUrl.Text; //get url from textBox
                timeQRCode = mtxtTime.Text;
                qrCode.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }

        }


        private bool checkIsEmptyCustomTxtBox(CustomTextBox txtBox)
        {
            if (txtBox.Text == "")
            {
                return true;
            }
            return false;
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
    }
}

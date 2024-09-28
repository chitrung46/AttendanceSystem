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
        public EditQRCode()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            QRCodeForm qrCode = new QRCodeForm();
            qrCode.Show();
            EditQRCode editQRCode = new EditQRCode();
            editQRCode.Hide();
        }

        private void EditQRCode_Load(object sender, EventArgs e)
        {

        }
    }
}

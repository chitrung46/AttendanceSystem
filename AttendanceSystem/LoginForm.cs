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

namespace AttendanceSystem
{
    public partial class LoginForm : Form
    {
        Account acc = new Account();
        AccountBLL accBLL = new AccountBLL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            acc.email = txtUsername.Text;
            acc.sPassword = txtPassword.Text;

            string getUser = accBLL.checkLogin(acc);

            switch (getUser)
            {
                case "required_email":
                    MessageBox.Show("Email không được để trống");
                    return;
                case "required_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Email hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Email hoặc mật khẩu không chính xác!");
                    return;
            }
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}

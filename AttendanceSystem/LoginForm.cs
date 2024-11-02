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
            txtPassword.PasswordChar = true;
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
            acc = accBLL.getAccountByEmailDLA(txtUsername.Text);
            HomeForm home = new HomeForm(acc);
            home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar)
                txtPassword.PasswordChar = false;
            else
                txtPassword.PasswordChar = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace AttendanceSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            loadForm(new SchoolForm());
            btnSchool.BackColor = Color.DarkRed;
            btnSchool.ForeColor = Color.White;
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }    

        private void btnSchool_Click(object sender, EventArgs e)
        {
            loadForm(new SchoolForm());
            btnSchool.BackColor = Color.DarkRed;
            btnSchool.ForeColor = Color.White;
            btnGroup.BackColor = Color.Beige;
            btnGroup.ForeColor = Color.DarkRed;
            btnSchedule.BackColor = Color.Beige;
            btnSchedule.ForeColor = Color.DarkRed;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            loadForm(new GroupForm());
            btnGroup.BackColor = Color.DarkRed;
            btnGroup.ForeColor = Color.White;
            btnSchool.BackColor = Color.Beige;
            btnSchool.ForeColor = Color.DarkRed;
            btnSchedule.BackColor = Color.Beige;
            btnSchedule.ForeColor = Color.DarkRed;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            loadForm(new StudentForm());
            btnSchedule.BackColor = Color.DarkRed;
            btnSchedule.ForeColor = Color.White;
            btnGroup.BackColor = Color.Beige;
            btnGroup.ForeColor = Color.DarkRed;
            btnSchool.BackColor = Color.Beige;
            btnSchool.ForeColor = Color.DarkRed;
        }
    }
}

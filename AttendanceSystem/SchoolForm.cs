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
    public partial class SchoolForm : Form
    {
        public SchoolForm()
        {
            InitializeComponent();
            //loadForm(new CRUDSchoolForm());
            pnlSchool.BackColor = Color.DodgerBlue;
            pnlFaculty.BackColor = Color.White;
            pnlSubject.BackColor = Color.White;
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
            //loadForm(new CRUDSchoolForm());
            pnlSchool.BackColor = Color.DodgerBlue;
            pnlFaculty.BackColor = Color.White;
            pnlSubject.BackColor = Color.White;
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            //loadForm(new CRUDFacultyForm());
            pnlFaculty.BackColor = Color.DodgerBlue;
            pnlSchool.BackColor = Color.White;
            pnlSubject.BackColor = Color.White;
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            //loadForm(new CRUDSubjectForm());
            pnlSubject.BackColor = Color.DodgerBlue;
            pnlSchool.BackColor = Color.White;
            pnlFaculty.BackColor = Color.White;
        }
    }
}

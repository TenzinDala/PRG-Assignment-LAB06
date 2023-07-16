using PRG_Assignment_LAB06.Student;
using PRG_Assignment_LAB06.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Assignment_LAB06
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherLogin teacherLogin = new TeacherLogin();
            teacherLogin.Show();
        }
    }
}

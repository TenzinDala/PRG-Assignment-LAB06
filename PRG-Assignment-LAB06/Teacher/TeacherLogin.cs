using PRG_Assignment_LAB06.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Assignment_LAB06.Teacher
{
    public partial class TeacherLogin : Form
    {
        int counter = 3;
        string PASSWORD = "4prg455";
        public TeacherLogin()
        {
            InitializeComponent();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            if (textBoxTeacherUserName.Text == "")
            {
                counter -= 1;
                MessageBox.Show($"Empty Student UserName. {counter} tries left");
                if (counter == 0)
                {
                    MessageBox.Show("No more tries left!!! \n Closing the Program!");
                    this.Close();
                }
            }
            else if (textBoxTeacherPassword.Text == "")
            {
                counter -= 1;
                MessageBox.Show($"Empty Password. {counter} tries left");
                if (counter == 0)
                {
                    MessageBox.Show("No more tries left!!! \n Closing the Program!");
                    this.Close();
                }
            }
            else if (textBoxTeacherPassword.Text != PASSWORD)
            {
                counter -= 1;
                MessageBox.Show($"Incorrect password. {counter} tries left ");
                if (counter == 0)
                {
                    MessageBox.Show("No more tries left!!! \n Closing the Program!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Successfully Logged in!!!\n Beginning the test!!!");
                StudentAverage studentAverage = new StudentAverage();
                this.Hide();
                studentAverage.Show();
            }
        }
    }
}

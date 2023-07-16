using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Assignment_LAB06.Student
{
    public partial class StudentLogin : Form
    {
        int counter = 3;
        string PASSWORD = "4prg455";
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            if (textBoxStudentID.Text == "")
            {
                counter -= 1;
                MessageBox.Show($"Empty Student ID. {counter} tries left");
                if (counter == 0)
                {
                    MessageBox.Show("No more tries left!!! \n Closing the Program!");
                    this.Close();
                }
            }
            else if (textBoxStudentUserName.Text == "")
            {
                counter -= 1;
                MessageBox.Show($"Empty Student ID. {counter} tries left");
                if (counter == 0)
                {
                    MessageBox.Show("No more tries left!!! \n Closing the Program!");
                    this.Close();
                }
            }
            else if (textBoxStudentPassword.Text != PASSWORD)
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
                string userName = textBoxStudentUserName.Text;
                string studentID = textBoxStudentID.Text;
                Student student = new Student(userName, studentID);
                Student.userInfo.Add("User", student);
                Question1 question1 = new Question1();
                this.Hide();
                question1.Show();
            }
        }
    }
}

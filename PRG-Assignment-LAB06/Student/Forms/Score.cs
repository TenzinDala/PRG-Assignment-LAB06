using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Assignment_LAB06.Student.Forms
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
            lblScore.Text = $"Total Score - {Student.Score}";
            if(Student.correctAnswers.Contains("Q1"))
            {
                lblQ1.Text = "Correct Answer!!!";
                lblQ1.ForeColor = Color.Green;
            }
            else
            {
                lblQ1.Text = "Incorrect Answer!!! The correct answer is -> 15";
                lblQ1.ForeColor = Color.Red;

            }
            if (Student.correctAnswers.Contains("Q2"))
            {
                lblQ2.Text = "Correct Answer!!!";
                lblQ2.ForeColor = Color.Green;
            }
            else
            {
                lblQ2.Text = "Incorrect Answer!!! The correct answer is -> A storage location in memory";
                lblQ2.ForeColor = Color.Red;
            }
            if (Student.correctAnswers.Contains("Q3"))
            {
                lblQ3.Text = "Correct Answer!!!";
                lblQ3.ForeColor = Color.Green;
            }
            else
            {
                lblQ3.Text = "Incorrect Answer!!! The correct answer is -> 1";
                lblQ3.ForeColor = Color.Red;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (!File.Exists("userInfo.txt"))
            {
                File.Create("userInfo.txt").Dispose();
                foreach (Student student in Student.userInfo.Values)
                {
                    File.AppendAllText("userInfo.txt", student.studentID);
                    File.AppendAllText("userInfo.txt", ", " + student.userName);
                    File.AppendAllText("userInfo.txt", ", " + Student.Score + "\n");
                }
            }
            else
            {
                foreach (Student student in Student.userInfo.Values)
                {
                    File.AppendAllText("userInfo.txt", student.studentID);
                    File.AppendAllText("userInfo.txt", ", " + student.userName);
                    File.AppendAllText("userInfo.txt", ", " + Student.Score + "\n");
                }
            }
            MessageBox.Show("Data saved in txt file");
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                lblQ1.Text = "Incorrect Answer!!!";
                lblQ1.ForeColor = Color.Red;

            }
            if (Student.correctAnswers.Contains("Q2"))
            {
                lblQ2.Text = "Correct Answer!!!";
                lblQ2.ForeColor = Color.Green;
            }
            else
            {
                lblQ2.Text = "Incorrect Answer!!!";
                lblQ2.ForeColor = Color.Red;
            }
            if (Student.correctAnswers.Contains("Q3"))
            {
                lblQ3.Text = "Correct Answer!!!";
                lblQ3.ForeColor = Color.Green;
            }
            else
            {
                lblQ3.Text = "Incorrect Answer!!!";
                lblQ3.ForeColor = Color.Red;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

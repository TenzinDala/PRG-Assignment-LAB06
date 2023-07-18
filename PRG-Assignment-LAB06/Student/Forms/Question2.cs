using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRG_Assignment_LAB06.Student
{
    public partial class Question2 : Form
    {
        public bool submitCheck = false;
        public int timer = 10;
        public Question2()
        {
            InitializeComponent();
            timerQ2.Enabled = true;
        }

        private void btnQ2Submit_Click(object sender, EventArgs e)
        {
            if (radio3Question2.Checked == true)
            {
                Student.Score += 1;
                Student.correctAnswers.Add("Q2");
            }
            groupBoxQ2.Enabled = false;
            groupBoxQ2.BackColor = Color.Gray;
            timerQ2.Enabled = false;
            BarQ2.Enabled = false;
            submitCheck = true;
        }

        private void timerQ2_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            BarQ2.Value += 1;
            if (timer == 0)
            {
                timerQ2.Enabled = false;
                btnQ2Submit.Enabled = false;
                groupBoxQ2.Enabled = false;
                groupBoxQ2.BackColor = Color.Gray;
                BarQ2.Enabled = false;
                submitCheck = true;
                if (radio3Question2.Checked == true)
                {
                    Student.Score += 1;
                    Student.correctAnswers.Add("Q2");
                }
            }
            lblTimeQ2.Text = "Timer Left => " + timer.ToString();
        }

        private void btnQ2Next_Click(object sender, EventArgs e)
        {
            if (submitCheck == true)
            {
                this.Hide();
                Question3 question3 = new Question3();
                question3.Show();
            }
            else
            {
                MessageBox.Show("Submit an Answer first!!!");
            }
        }
    }
}

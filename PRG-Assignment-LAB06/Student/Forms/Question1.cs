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

namespace PRG_Assignment_LAB06.Student
{
    public partial class Question1 : Form
    {
        public bool submitCheck = false;
        public int timer= 10;
        public Question1()
        {
            InitializeComponent();
            TimerQ1.Enabled = true;
        }

        private void btnQ1Submit_Click(object sender, EventArgs e)
        {
            if(radio1Question1.Checked == true)
            {
                Student.Score += 1;
                Student.correctAnswers.Add("Q1");
            }
            groupBoxQ1.Enabled = false;
            groupBoxQ1.BackColor = Color.Gray;
            TimerQ1.Enabled = false;
            BarQ1.Enabled = false;
            submitCheck = true;
        }

        private void TimerQ1_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            BarQ1.Value += 1;
            if (timer == 0)
            { 
                TimerQ1.Enabled = false;
            }
            lblTimeQ1.Text = "Timer Left => " + timer.ToString();
        }

        private void btnQ1Next_Click(object sender, EventArgs e)
        {
            if(submitCheck == true)
            {
                this.Hide();
                Question2 question2 = new Question2();
                question2.Show();
            }
            else
            {
                MessageBox.Show("Submit an Answer first!!!");
            }
        }
    }
}

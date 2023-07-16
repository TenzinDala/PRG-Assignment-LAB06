using PRG_Assignment_LAB06.Student.Forms;
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
    public partial class Question3 : Form
    {
        public bool submitCheck = false;
        public int timer = 10;
        public Question3()
        {
            InitializeComponent();
            timerQ3.Enabled = true;
        }

        private void btnQ1Submit_Click(object sender, EventArgs e)
        {
            if (radio2Question3.Checked == true)
            {
                Student.Score += 1;
                Student.correctAnswers.Add("Q3");
            }
            groupBoxQ3.Enabled = false;
            groupBoxQ3.BackColor = Color.Gray;
            timerQ3.Enabled = false;
            BarQ3.Enabled = false;
            submitCheck = true;
        }

        private void timerQ3_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            BarQ3.Value += 1;
            if (timer == 0)
            {
                timerQ3.Enabled = false;
            }
            lblTimeQ3.Text = "Timer Left => " + timer.ToString();
        }

        private void btnQ3Finish_Click(object sender, EventArgs e)
        {
            if (submitCheck == true)
            {
                this.Hide();
                Score score = new Score();
                score.Show();
            }
            else
            {
                MessageBox.Show("Submit an Answer first!!!");
            }
        }
    }
}

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

namespace PRG_Assignment_LAB06.Teacher
{
    public partial class StudentAverage : Form
    {
        public string[] column { get; set; }
        public static List<string[]> columnsList = new List<string[]>();

        public StudentAverage()
        {
            InitializeComponent();
            if (File.Exists("userInfo.txt"))
            {
                //List<string> lines = new List<string>();
                
                using (StreamReader reader = new StreamReader("userInfo.txt"))
                {
                    string Line;

                    while ((Line = reader.ReadLine()) != null)
                    {
                        column = Line.Split(',');
                        columnsList.Add(column);
                    }
                }
            }
            int sum = 0;
            int count = 0;
            int score;
            string studentScore;

            foreach (string[] columns in columnsList)
            {
                for (var student = 2; student < columns.Length; student += 3)
                {
                    studentScore = columns[student];
                    score = int.Parse(studentScore);
                    sum += score;
                    count++;
                }
            }

            //for (var student = 2; student <= columns.Length;student +=3)
            //{
            //    studentScore = columns[student];
            //    int score = int.Parse(studentScore);
            //    sum += score;
            //    count++;
            //}
            double average = (double)sum / count;

            lblAverage.Text = "Total Average of Student's scores: " + average.ToString();
        }
    }
}

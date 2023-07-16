using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Assignment_LAB06.Student
{
    public class Student
    {
        public string userName { get; set; }
        public string studentID { get; set; }
        public static Dictionary<string, Student> userInfo;

        public Student(string USERNAME, string STUDENTID) 
        {
            this.userName = USERNAME;
            this.studentID = STUDENTID;
            userInfo = new Dictionary<string, Student>();
        }
        

    }
}

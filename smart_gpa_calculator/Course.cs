using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_gpa_calculator
{
    class Course
    {
        private string department;
        private int courseNumber;
        private string courseName;
        private double actualCredit;

        public Course(string department, int courseNumber, string courseName,  double actualCredit)
        {
            this.department = department;
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.actualCredit = actualCredit;
        }
    }
}

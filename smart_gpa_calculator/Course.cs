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
        private double creditHours;

        public Course(string department, int courseNumber, string courseName, double actualCredit, double creditHours)
        {
            this.department = department;
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.actualCredit = actualCredit;
            this.creditHours = creditHours;
        }
        public override string ToString()
        {
            string output = "";
            output += department + " " + courseNumber + " " + courseName + " Grade: " + actualCredit + " Hours: " + creditHours + "\r\n";
            return output;
        }
    }
}

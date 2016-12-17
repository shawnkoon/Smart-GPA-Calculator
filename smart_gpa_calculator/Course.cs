using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_gpa_calculator
{
    class Course : IComparable<Course>
    {
        private string department;
        private int courseNumber;
        private string courseName;
        private double actualGPA;
        private double creditHours;

        public Course(string department, int courseNumber, string courseName,  double actualGPA, double creditHours)
        {
            this.department = department;
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.actualGPA = actualGPA;
            this.creditHours = creditHours;
        }
        public double GetGPA()
        {
            return this.actualGPA;
        }
        public double GetHours()
        {
            return this.creditHours;
        }
        public double GetPoints()
        {
            return actualGPA * creditHours;
        }
        public override string ToString()
        {
            string output = "";
            output += department + " " + courseNumber + "   " + courseName + "   Grade: " + actualGPA.ToString("0.0") + "   Hours: " + creditHours.ToString("0.0") + "\r\n";
            return output;
        }
        // Sort first by department identifier, then course number
        public int CompareTo(Course that)
        {
            int result = this.department.CompareTo(that.department);
            if (result == 0)
                result = this.courseNumber - that.courseNumber;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_gpa_calculator
{
    class Term
    {
        private string major;
        private string minor;
        private string termSeason;
        private int year;
        private string termLength;
        private float outOf;
        private Course[] courses;

        public Term()
        {
            major = "";
            minor = "";
            courses = new Course[0];
        }
        public Term(string maj, string min, string tS, int y, string tL, float o, Course c)
        {
            major = maj;
            minor = min;
            termSeason = tS;
            year = y;
            termLength = tL;
            outOf = o;
            courses = new Course[] { c };
        }
        public void Insert(Course c)
        {
            Array.Resize<Course>(ref courses, courses.Length + 1);
            courses[courses.Length - 1] = c;
        }
    }
}

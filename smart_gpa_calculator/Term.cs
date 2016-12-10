using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_gpa_calculator
{
    class Term
    {
        private string termSeason;
        private int year;
        private string termLength;
        private Course[] courses;

        public Term()
        {
            courses = new Course[0];
        }
        public Term(string tS, int y, string tL, Course c)
        {
            termSeason = tS;
            year = y;
            termLength = tL;
            courses = new Course[] { c };
        }

        public void Insert(Course c)
        {
            Array.Resize<Course>(ref courses, courses.Length + 1);
            courses[courses.Length - 1] = c;
        }
        public string getSeason()
        {
            return termSeason;
        }
        public int getYear()
        {
            return year;
        }
    }
}

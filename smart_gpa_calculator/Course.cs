using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_gpa_calculator
{
    class Course
    {
        private string termSeason;
        private int year;
        private string termLength;
        private string dept;
        private int courseNum;
        private string courseName;
        private int numCredits;
        private float actual;
        private string category;

        public Course(string tSeason,
                        int y,
                        string tLength,
                        string d,
                        int cNum,
                        string cName,
                        int nCredits,
                        float a,
                        float o,
                        string c)
        {
            termSeason = tSeason;
            year = y;
            termLength = tLength;
            dept = d;
            courseNum = cNum;
            courseName = cName;
            numCredits = nCredits;
            actual = a;
            category = c;
        }
    }
}

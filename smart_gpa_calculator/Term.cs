using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_gpa_calculator
{
    class Term : IComparable<Term>
    {
        private string termSeason;
        private int year;
        private Course[] courses;
        private double termGPA;
        private double termHours;
        private double termPoints;

        public Term()
        {
            this.courses = new Course[0];
            this.termGPA = 0.0;
            this.termHours = 0.0;
            this.termPoints = 0.0;
        }
        public Term(string termSeason, int year, Course course)
        {
            this.termSeason = termSeason;
            this.year = year;
            this.courses = new Course[] { course };
            this.termGPA = course.GetGPA();
            this.termHours = course.GetHours();
            this.termPoints = course.GetPoints();
        }

        public void Insert(Course c)
        {
            Array.Resize<Course>(ref courses, courses.Length + 1);
            courses[courses.Length - 1] = c;
            Array.Sort(courses);
            Calculate();
        }
        public void Calculate()
        {
            double result;
            double totalPoints = 0.0;
            double totalHours = 0.0;
            foreach(Course course in courses)
            {
                totalPoints += (course.GetGPA() * course.GetHours());
                totalHours += course.GetHours();
            }
            result = totalPoints / totalHours;
            result = Math.Round(result, 2);

            this.termGPA = result;
            this.termHours = totalHours;
            this.termPoints = totalPoints; //Math.Round?
        }
        public string GetSeason()
        {
            return this.termSeason;
        }
        public int GetYear()
        {
            return this.year;
        }
        public double GetGPA()
        {
            return this.termGPA;
        }
        public double GetHours()
        {
            return this.termHours;
        }
        public double GetPoints()
        {
            return this.termPoints;
        }
        public override string ToString()
        {
            string output = "";
            output += termSeason + " " + year + " - " + termGPA.ToString("0.00") + "\r\n";
            foreach(Course course in courses)
            {
                output += course.ToString();
            }
            output += "\r\n";
            return output;
        }
        // Sort first by Year, then by Term Season (in order of Winter, Spring, Summer, then last Fall)
        public int CompareTo(Term that)
        {
            int result = this.year - that.year;
            if(result == 0)
            {
                //implement logic to sort by Season in a sequential, not alphabetic fashion
                int thisSeason = ValueForSeason(this.termSeason);
                int thatSeason = ValueForSeason(that.termSeason);
                result = thisSeason - thatSeason;
            }
            return result;
        }
        // A helper function for CompareTo to give a numeric order to Winter, Spring, Summer, then last Fall
        private int ValueForSeason(string season)
        {
            int value;
            if (season.CompareTo("Winter") == 0)
                value = 1;
            else if (season.CompareTo("Spring") == 0)
                value = 2;
            else if (season.CompareTo("Summer") == 0)
                value = 3;
            else // "Fall"
                value = 4;
            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_gpa_calculator
{
    class Cumulative
    {
        /* Cumulative will store the "One Time" values that we're worrying about later
         * private string major;
         * private string minor;
         * private string termLength;
         * private double scale; // "outOf"
         */
        private Term[] terms;
        private double cumulativeGPA;
        private double cumulativeHours;
        private double cumulativePoints;

        public Cumulative()
        {
            this.terms = new Term[0];
            this.cumulativeGPA = 0.0;
            this.cumulativeHours = 0.0;
            this.cumulativePoints = 0.0;
        }
        public Cumulative(Term term)
        {
            this.terms = new Term[] { term };
            this.cumulativeGPA = term.GetGPA();
            this.cumulativeHours = term.GetHours();
            this.cumulativePoints = term.GetPoints();
        }
        public void Insert(Term t)
        {
            Array.Resize<Term>(ref terms, terms.Length + 1);
            terms[terms.Length - 1] = t;
            Array.Sort(terms);
            Calculate(); // Note: This will need called every time a Course is inserted, not just a new Term inserted
        }
        public void Calculate()
        {
            double result;
            double totalPoints = 0.0;
            double totalHours = 0.0;
            foreach (Term term in terms)
            {
                totalPoints += (term.GetGPA() * term.GetHours());
                totalHours += term.GetHours();
            }
            result = totalPoints / totalHours;
            result = Math.Round(result, 2);

            this.cumulativeGPA = result;
            this.cumulativeHours = totalHours;
            this.cumulativePoints = totalPoints; //Math.Round?
        }
        public double GetGPA()
        {
            return this.cumulativeGPA;
        }
        public double GetHours()
        {
            return this.cumulativeHours;
        }
        public double GetPoints()
        {
            return this.cumulativePoints;
        }
        public Term[] Search(int year)
        {
            Term[] matchingYear = Array.FindAll(terms, element => element.GetYear() == year);
            return matchingYear;
        }
        public bool IsEmpty()
        {
            if (terms.Length == 0)
                return true;
            return false;
        }
        public override string ToString()
        {
            string output = "";
            output += "Cumulative:\r\n";
            foreach (Term term in terms)
            {
                output += term.ToString();
            }
            return output;
        }
    }
}

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

        public Cumulative()
        {
            this.terms = new Term[0];
        }
        public Cumulative(Term term)
        {
            this.terms = new Term[] { term };
        }
        public void Insert(Term t)
        {
            Array.Resize<Term>(ref terms, terms.Length + 1);
            terms[terms.Length - 1] = t;
            Array.Sort(terms);
        }
        public Term[] Search(int year)
        {
            Term[] matchingYear = Array.FindAll(terms, element => element.getYear() == year);
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

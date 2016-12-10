using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_gpa_calculator
{
    class Cumulative
    {
        private string major;
        private string minor;
        private float scale; // "outOf"
        private Term[] terms;

        public Cumulative(string maj, string min, float s, Term t)
        {
            major = maj;
            minor = min;
            scale = s;
            terms = new Term[] { t };
        }
        public void Insert(Term t)
        {
            Array.Resize<Term>(ref terms, terms.Length + 1);
            terms[terms.Length - 1] = t;
        }
    }
}

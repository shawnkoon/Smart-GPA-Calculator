using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smart_gpa_calculator
{
    public partial class mainForm : Form
    {
        // Variables we want accessible in all the panels
        // (these are temporaries used for transferring data and pre-populating fields)
        private string major;
        private string minor;
        private string termSeason;
        private int year;
        private string termLength;
        private string dept;
        private int courseNum;
        private string courseName;
        private int numCredits;
        private float actual;
        private float outOf;
        private string category;

        // This holds all the terms, and each Term holds some courses
        private Cumulative all;
        private Term[] terms;

        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            // Take aaall the stuff from the submission form and put them in the temp variables

            // Then place them in a course

            // Then place that course in the appropriate Term (if exists)

            // Then place the Term in Cumulative if it doesn't exist

        }
        
    }
}

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
        string major;
        string minor;
        string termSeason;
        int year;
        string termLength;
        string dept;
        int courseNum;
        string courseName;
        int numCredits;
        float actual;
        float outOf;
        string category;

        // This holds all the terms, and each Term holds some courses
        Cumulative all;

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

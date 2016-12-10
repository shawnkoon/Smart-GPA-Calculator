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
        private string termSeason;
        private int year;
        private string dept;
        private int courseNum;
        private string courseName;
        private int numCredits;
        private float grade;

        /* These are all "One Time" values, and we will worry about how we want to gather these later
         * private string major; -- May want to change this so User can have more than one
         * private string minor; -- Same as above
         * private string termLength; -- Quarter vs. Semester
         * private float scale; -- 4.0, 5.0, etc. Hard-coding in 4.0 for now
         * private string category; -- Whether the class belongs to your Major, Minor, or Neither
         * */

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

        /// <summary>
        ///     Take all the stuff from the submission form and put them in the temp variables.
        ///     https://msdn.microsoft.com/en-us/library/bb397679.aspx Reviewing how to Parse Ints
        /// </summary>
        private void addClassButton_Click(object sender, EventArgs e)
        {
            // 
            termSeason = termSeasonComboBox.SelectedText;
            year = Convert.ToInt32(yearUpDown.Value); //Doesn't need a catch since input is forced to be proper
            dept = deptTextBox.Text;
            courseNum = Convert.ToInt32(courseNumUpDown.Value);
            courseName = courseNameTextBox.Text;
            numCredits = Convert.ToInt32(numCreditsUpDown.Value);
            grade = Convert.ToInt32(gradeUpDown.Value);

            // Then place them in a course

            // Then place that course in the appropriate Term (if exists)

            // Then place the Term in Cumulative if it doesn't exist

        }

        /// <summary>
        ///     Opens .csv file then create appropriate objects. to display.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///     Saves what is currently typed/loaded out to the file.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
    }
}

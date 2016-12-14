using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        /* These are all "One Time" values, and we will worry about how we want to gather these later (What class is it a member of)
         * private string major; -- May want to change this so User can have more than one (Cumulative)
         * private string minor; -- Same as above
         * private string termLength; -- Quarter vs. Semester (Cumulative)
         * private double scale; -- 4.0, 5.0, etc. Hard-coding in 4.0 for now (Cumulative)
         * private string category; -- Whether the class belongs to your Major, Minor, or Neither (Course)
         * */

        // This holds all the terms, and each Term holds some courses
        private Cumulative all = new Cumulative();

        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///     Take input and process it into a Term and into the Total.
        ///     https://msdn.microsoft.com/en-us/library/bb397679.aspx Reviewing how to Parse Ints
        ///     https://www.dotnetperls.com/array-find A method for searching Cumulative for an existing Term
        /// </summary>
        private void addClassButton_Click(object sender, EventArgs e)
        {
            // Take all the input from the submission form and put them in the temp variables.
            termSeason = termSeasonComboBox.Text;
            year = Convert.ToInt32(yearUpDown.Value); //Doesn't need a catch since input is forced to be proper
            dept = deptTextBox.Text;
            courseNum = Convert.ToInt32(courseNumUpDown.Value);
            courseName = courseNameTextBox.Text;
            numCredits = Convert.ToInt32(numCreditsUpDown.Value);
            grade = Convert.ToInt32(gradeUpDown.Value);

            if ( validatedTerms() )
            {
                // Then place them in a course
                Course curCourse = new Course(dept, courseNum, courseName, grade, numCredits);

                // Place the course in a Term, and the Term in Cumulative (if it isn't already existing)
                Term[] matchingYear = all.Search(year);
                if (matchingYear == null) // Create a new term and insert this course in it
                {
                    Term newTerm = new Term(termSeason, year, curCourse);
                    if (all.IsEmpty()) // I think Insert logic might work for both cases
                        all = new Cumulative(newTerm);
                    else
                        all.Insert(newTerm);
                }
                else // Classes already exist in this year; check for the specific term further using season
                {
                    Term matchingSeason = Array.Find(matchingYear, element => String.Equals(element.getSeason(), termSeason));
                    if (matchingSeason == null) //Logic same as above -- create a new term, insert into Cumulative (create if nots exists)
                    {
                        Term newTerm = new Term(termSeason, year, curCourse); // Same logic as above
                        if (all.IsEmpty()) // I think Insert logic might work for both cases
                            all = new Cumulative(newTerm);
                        else
                            all.Insert(newTerm);
                    }
                    else
                    {
                        matchingSeason.Insert(curCourse); // The Term existed and just needs a class inserted
                    }
                }

                //Update the Right two panels with the new info
                // -- This part is not done yet (we probably need a doCalculation function) --
                MessageBox.Show(all.ToString());
                //I want to sort first by year then by termSeason (Term), first by dept then by courseNum (Courses)

                //Clear the form and reset the Focus
                termSeasonComboBox.Text = "Term";
                yearUpDown.Value = 2017;
                deptTextBox.Text = "";
                courseNumUpDown.Value = 100;
                courseNameTextBox.Text = "";
                numCreditsUpDown.Value = 5;
                gradeUpDown.Value = 0;
                termSeasonComboBox.Focus();
            } //end if( validatedTerms() )
        }

        /// <summary>
        ///     Opens .csv file then create appropriate objects. to display.
        ///     Used : https://msdn.microsoft.com/en-us/library/system.windows.forms.openfiledialog(v=vs.110).aspx
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader myStream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if((myStream = new StreamReader( openFileDialog.OpenFile() ) ) != null)
                    {
                        // Used : https://msdn.microsoft.com/en-us/library/system.io.stream(v=vs.110).aspx
                        using (myStream)
                        {
                            // Should be in : Year, Term, Course Name, Course Abb, Course Number, GPA
                            string[] columnTitles = myStream.ReadLine().Split(',');

                            if(columnTitles.Length != 6)
                            {
                                string line;

                                while((line = myStream.ReadLine()) != null)
                                {
                                    
                                    string[] courseInfo = line.Split(',');

                                    //Course course = new Course(courseInfo[3], Int32.Parse(courseInfo[4]) , courseInfo[2], Double.Parse(courseInfo[5]) );
                                    // Needs a fifth parameter according to last change
                                }
                            }
                            else
                            {
                                throw new Exception("csv in wrong format.");
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: could not read file from disk. Detail :" + ex.Message);
                }
            }
        }

        /// <summary>
        ///     Saves what is currently typed/loaded out to the file.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private bool validatedTerms()
        {
            bool validated = true;
            string message = "";
            if (termSeason != "Fall" && termSeason != "Winter" && termSeason != "Spring" && termSeason != "Summer")
            {
                message += "-Term must be a Season from the DropDown list.\r\n";
                validated = false;
                termSeasonComboBox.Focus();
            }
            if (dept == "")
            {
                message += "-Department Identifier must be given. E.g. 'MATH&'\r\n";
                validated = false;
                if(message[1] == 'D')
                    deptTextBox.Focus();
            }
            if (courseName == "")
            {
                message += "-Course Name must be given.";
                validated = false;
                if (message[1] == 'C')
                    courseNameTextBox.Focus();
            }

            if (!validated)
                MessageBox.Show(message);
            return validated;
        }
    }
}

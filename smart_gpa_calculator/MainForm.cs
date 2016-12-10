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

                                    Course course = new Course(courseInfo[3], Int32.Parse(courseInfo[4]) , courseInfo[2], Double.Parse(courseInfo[5]) );
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
        
    }
}

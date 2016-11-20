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
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void singleClassButton_Click(object sender, EventArgs e)
        {
            Form singleClassForm = new SingleClassForm();

            this.Visible = false;
            singleClassForm.ShowDialog();
            this.Visible = true;
        }
    }
}

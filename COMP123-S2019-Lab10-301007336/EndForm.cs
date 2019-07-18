using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301007336
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //MainForm MainForm = new MainForm();
            //MainForm.Show();
            //this.Hide();

            Program.endForm.Hide(); //Refactoring
            Program.mainForm.Show(); //Refactoring
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

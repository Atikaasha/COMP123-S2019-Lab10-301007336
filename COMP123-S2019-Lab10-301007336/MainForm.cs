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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NexButton_Click(object sender, EventArgs e)
        {
            //EndForm EndForm = new EndForm();
            //EndForm.Show();
            //this.Hide();

            Program.mainForm.Hide();//Refactoring
            Program.endForm.Show();//Refactoring
        }
    }
}

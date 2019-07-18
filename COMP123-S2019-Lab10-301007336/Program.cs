using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name: Chowdhury Atika Parvin
/// ID# 301007336
/// Version: 0.1 Lab-10 Created
/// </summary>
namespace COMP123_S2019_Lab10_301007336
{
    public static class Program
    {
        public static StartForm startForm;
        public static MainForm mainForm;
        public static EndForm endForm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            mainForm = new MainForm();
            endForm = new EndForm();
            Application.Run(startForm);
        }
        //vbvb
    }
}

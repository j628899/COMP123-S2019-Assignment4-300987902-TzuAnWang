using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Author's name : Tzu-An Wang
/// Author’s student number: 300987902
/// Date last Modified: 7/26/2019
/// Program description: BMI Calculator App 
/// Revision History: 988d8ef, 1a30c939 , a30c939, cdf7212, 93fef3a, 9c73614, 6e1c72e
/// </summary>
namespace COMP123_S2019_Assignment4_300987902
{
    static class Program
    {
        public static StartForm startForm;
        public static MainForm mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            mainForm = new MainForm();


            Application.Run(startForm);
        }
    }
}

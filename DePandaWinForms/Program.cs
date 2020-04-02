using DePandaLib.DAL;
using DePandaWinForms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataStorageHandler.Init(Properties.Resources.DataStorage);
            Application.Run(new Login());
            // change Form to Login 
        }
    }
}
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
            DataStorageHandler.StorageFileLocation = "DataStorage.json";
            DataStorageHandler.Init();
            Application.Run(new Form1(false));
            // change Form to Login Application.Run(new Login(false));
            DataStorageHandler.SaveChanges();
        }
    }
}
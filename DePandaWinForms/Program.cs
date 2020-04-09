using DePandaLib.DAL;
using DePandaLib.Entities;
using DePandaWinForms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DePandaWinForms.Pages;

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
            
            //DataStorageHandler.Storage.StockDishes.Add();
            
            Application.Run(new Form1(FormWindowState.Normal));
            // change Form to Login Application.Run(new Login(false));
            
            DataStorageHandler.SaveChanges();
        }
    }
}
using DePandaLib.DAL;
using DePandaLib.Entities;
using DePandaWinForms.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

            // Set the unhandled exception mode to force all Windows Forms errors
            // to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event.
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += Application_ThreadException;
            DataStorageHandler.StorageFileLocation = "DataStorage.json";
            DataStorageHandler.Init();

            //DataStorageHandler.Storage.StockDishes.Add();

            Application.Run(new Form1(FormWindowState.Normal));
            // change Form to Login Application.Run(new Login(false));

            DataStorageHandler.SaveChanges();
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowExceptionMessage(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowExceptionMessage((e.ExceptionObject as Exception));
        }

        private static void ShowExceptionMessage(Exception e)
        {
            bool savedData = false;
            try
            {
                DataStorageHandler.SaveChanges();
                savedData = true;
            }
            catch (Exception ex)
            {
                savedData = false;
            }
            MessageBox.Show("Fout:\n" + e.Message + "\n" + (savedData ? "\nGecachete data is opgeslagen." : "\nGecachete data kon niet worden opgeslagen, dit betekent dat er kans is op verlies van data."), "Er is een uitzondering opgetreden", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
using DePandaConsole.Entities;
using DePandaConsole.Pages;
using DePandaLib.DAL;
using DePandaLib.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace DePandaConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Panda World!");
            //Dish dish = new Dish();
            //dish.Name = "Babi Pangang";

            //Console.WriteLine("We only sell: " + dish.Name);
            //var something = "";

            var storageLoc = Path.Combine(Environment.CurrentDirectory, @"DataStorage.json");
            Storage.StorageHandler = new DataStorageHandler(storageLoc);
            MainPage mainPage = new MainPage();
            mainPage.Initialize();
            //Run when program closes
            Storage.StorageHandler.SaveChanges();
        }
    }
}
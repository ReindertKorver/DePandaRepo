using DePandaLib.DAL;
using DePandaLib.Entities;
using System;

namespace DePandaConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Panda World!");
            Dish dish = new Dish();
            dish.Name = "Babi Pangang";

            DataStorageHandler dth = new DataStorageHandler();
            dth.Create<Dish>(dish);
            Console.WriteLine("We only sell: " + dish.Name);
        }
    }
}
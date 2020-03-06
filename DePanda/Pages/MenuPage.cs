using DePandaConsole.Entities;
using DePandaLib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaConsole.Pages
{
    public class MenuPage : BasePage
    {
        public MenuPage()
        {
        }

        public override void OnPageLoad()
        {
            base.OnPageLoad();

            do
            {
                Console.WriteLine("Creating a new reservation");
                

                string onTheNameOf;
                do
                {
                    Console.WriteLine("Name of reserver:");
                    onTheNameOf = Console.ReadLine();
                } while (string.IsNullOrEmpty(onTheNameOf));

                string amountPeople;
                int amountPeopleInt;
                do
                {
                    Console.WriteLine("Amount of people (number):");
                    amountPeople = Console.ReadLine();
                } while (!int.TryParse(amountPeople, out amountPeopleInt));

                Reservation reservation = new Reservation() { ID = Guid.NewGuid().ToString(), AmountOfPeople = amountPeopleInt, OnTheNameOf = onTheNameOf };

                Storage.StorageHandler.storage.Reservations.Add(reservation);
                Console.WriteLine("Saved the reservation");
                Console.WriteLine("Press b to go back, press enter to add a new reservation");
            } while (Console.ReadKey().Key != ConsoleKey.B);
            Navigator.PopPage();
        }
    }
}
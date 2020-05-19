using DePandaClassLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DePandaLib.Entities
{
    /// <summary>
    /// A reservation within DePanda's restaurant management system
    /// </summary>

    public class Reservation : Identifier
    {
        public string OnTheNameOf { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int AmountOfPeople { get; set; }
        public string Table { get; set; }

        //public List<RestaurantTable> Tables { get; set; }
        public string Specifications { get; set; }

        public bool Payed { get; set; }
        public List<Order> Orders { get; set; }

        public decimal GetReservationTotal()
        {
            return Orders.Sum(order => order.GetTotal());
        }
    }
}
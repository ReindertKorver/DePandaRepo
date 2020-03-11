using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DePandaLib.Entities
{
    /// <summary>
    /// A reservation within DePanda's restaurant management system
    /// </summary>
    public class Reservation
    {
        public string ID { get; set; }
        public string OnTheNameOf { get; set; }
        public int AmountOfPeople { get; set; }
        public List<RestaurantTable> Tables { get; set; }
        public List<Order> Orders { get; set; }

        public decimal GetReservationTotal()
        {
            return Orders.Sum(order => order.GetTotal());
        }
    }
}
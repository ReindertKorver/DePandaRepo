using DePandaClassLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DePandaLib.Entities
{
    public class DataStorage
    {
        public Settings Settings { get; set; } = new Settings();
        public List<Dish> StockDishes { get; set; } = new List<Dish>();
        public List<RestaurantTable> AvailableTables { get; set; } = new List<RestaurantTable>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public List<Order> GetAllOrders()
        {
            //Gets all orders and fills them with their reservation for certainty
            //because the reservation->order->reservation isnt saved in json
            //because it would be the same reservation as the first in the hierarchy
            return Reservations.Where(r => r.Orders != null).SelectMany(r => r.Orders.Select(o => { o.Reservation = r; return o; })).ToList();
        }
    }
}
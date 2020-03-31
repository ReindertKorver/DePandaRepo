using DePandaClassLib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaLib.Entities
{
    public class DataStorage
    {
        public Settings Settings { get; set; }
        public List<Dish> StockDishes { get; set; } = new List<Dish>();
        public List<RestaurantTable> AvailableTables { get; set; } = new List<RestaurantTable>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
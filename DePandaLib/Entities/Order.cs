using DePandaClassLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DePandaLib.Entities
{
    public class Order : Identifier
    {
        public DateTime OrderDate { get; set; }
        public Reservation Reservation { get; set; }
        public List<Dish> Dishes { get; set; }
        public bool Paid { get; set; }

        public decimal GetTotal()
        {
            return Dishes.Sum(d => d.Price * d.Amount);
        }
    }
}
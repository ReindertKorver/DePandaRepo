using DePandaClassLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DePandaLib.Entities
{
    public class Order : Identifier
    {
        public Reservation Reservation { get; set; }
        public List<Dish> Dishes { get; set; }

        public decimal GetTotal()
        {
            return Dishes.Sum(d => d.Price);
        }
    }
}
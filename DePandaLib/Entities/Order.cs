using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DePandaLib.Entities
{
    public class Order
    {
        public string ID { get; set; }
        public List<Dish> Dishes { get; set; }

        public decimal GetTotal()
        {
            return Dishes.Sum(d => d.Price);
        }
    }
}
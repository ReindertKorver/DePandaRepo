using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaLib.Entities
{
    /// <summary>
    /// A dish within DePanda's restaurant management system
    /// </summary>
    public class Dish
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
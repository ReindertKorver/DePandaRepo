using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DePandaLib.Entities
{
    public class RestaurantTable
    {
        public string ID { get; set; }
        public Vector2 Location { get; set; }
        public int Places { get; set; }
    }
}
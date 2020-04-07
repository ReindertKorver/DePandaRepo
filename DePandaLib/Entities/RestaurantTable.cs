using DePandaClassLib.Entities;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DePandaLib.Entities
{
    public class RestaurantTable : Identifier
    {
        public Vector2 Location { get; set; }
        public int Places { get; set; }
    }
}
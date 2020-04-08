using DePandaLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DePandaClassLib.Entities
{
    public class MenuItem : Identifier
    {
        public Dish Dish { get; set; }
        public int Amount { get; set; }
    }
}
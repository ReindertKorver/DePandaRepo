﻿using DePandaClassLib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaLib.Entities
{
    /// <summary>
    /// A dish within DePanda's restaurant management system
    /// </summary>
    public class Dish : Identifier
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point(int x,int y ,int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public string ReturnCoordsAsString()
        {
            return $"{ X},{ Y},{ Z}";
        }
    }
}

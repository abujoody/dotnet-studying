﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloningTest
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) { X = x; Y = y; }
        public Point() {}

        //overriden
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}", X, Y);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

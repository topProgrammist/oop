﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication6
{
    class Square : Rectangle
    {
        public Square(Point point, int side) : base(point, side, side)
        {
        }
    }
}

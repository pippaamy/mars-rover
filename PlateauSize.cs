﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   public class PlateauSize
    {


       
        //lower left always 0,0
        //below represents right
        public int X {  get; set; }
        public int Y { get; set; }

        public PlateauSize(int x, int y) { 
        X = x;
            Y = y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
  public class Position
    {
       
            
            public int X {  get; set; }
          public  int Y { get; set; }
           public Compass Facing { get; set; }
        
        public Position (int x, int y, Compass n)
        {
          X = x;
            Y = y;
            Facing = n;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Coordinates
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordinates(int xPosition, int yPosition)
        {
            this.x = xPosition;
            this.y = yPosition;
        }
    }
}

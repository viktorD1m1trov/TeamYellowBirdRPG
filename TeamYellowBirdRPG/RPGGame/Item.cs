using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public abstract class Item
    {
        protected Coordinates position;

        public abstract int bonusTo { get; protected set; } //the bonus that the item will give

        public abstract Coordinates Position { get; set; }
       
       
    }
}

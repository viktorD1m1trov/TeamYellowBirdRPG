using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public abstract class Alive: IAlive
    {
        protected string name;
        protected Coordinates position;
        protected int health;
        public abstract string Name { get; protected set; }
        public abstract Coordinates Position { get; set; }
        public abstract int Health { get; protected set; }

        //ADD ABSTRACT MOVEMENT METHODS AND ALSO ADD THEM IN THE INTERFACE IALIVE

    }
}

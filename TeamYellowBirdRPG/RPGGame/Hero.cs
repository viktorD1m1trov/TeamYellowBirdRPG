using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Hero : Alive, IAlive
    {

        public override string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public override Coordinates Position { get; set; }

        public override int Health { get; protected set; }

        public Hero(string name, Coordinates position, int health)
        {
            this.Name = name;
            this.Position = position;
            this.Health = health;
        }


        public void PrintHero()
        {
            Console.SetCursorPosition(this.Position.y, this.Position.x);
            Console.Write('@');
            Console.SetCursorPosition(this.Position.y, this.Position.x);
        }
        
        //OVERRIDE MOVEMENT METHODS HERE
    }
}

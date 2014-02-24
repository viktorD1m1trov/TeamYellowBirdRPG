using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Orc : Creeper, ICreeper, IAlive
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

        public override int Damage { get; protected set; }


        public Orc(string name,Coordinates position)
        {
            this.Name = name;
            this.Position = position;
            this.Health = 70;
            this.Damage = 7;
        }
    }
}

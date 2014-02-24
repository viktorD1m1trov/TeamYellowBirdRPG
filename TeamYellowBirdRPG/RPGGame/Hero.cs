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

        public override int Damage{ get; protected set; }

        public Hero(string name)
        {
            this.Name = name;
            this.Position = new Coordinates(18, 34);
            this.Health = 100;
            this.Damage = 10;
        }


        public void PrintHero()
        {
            Console.SetCursorPosition(this.Position.Y, this.Position.X);
            Console.Write('@');
            Console.SetCursorPosition(this.Position.Y, this.Position.X);
        }

        public static string EnterName()
        {
            Console.SetCursorPosition((Console.BufferWidth - 65), Console.BufferHeight / 2);
            Console.Write("Please, input your name: ");
            string name = Console.ReadLine();
            Console.Clear();
            return name;
        }
        
        //OVERRIDE MOVEMENT METHODS HERE


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public abstract class Creeper:Alive,ICreeper,IAlive
    {

        //private static void PrintCreature(Creeper creeper)
        //{
        //    Console.SetCursorPosition(creeper.Position.Y, creeper.Position.X);
        //    var type = creeper.GetType().Name;

        //    if(type=="Orc")
        //    {
        //        Console.Write("O");
        //    }
        //    else if(type=="Goblin")
        //    {
        //        Console.Write("g");
        //    }

        //    Console.SetCursorPosition(creeper.Position.Y, creeper.Position.X);
        //}


    }
}

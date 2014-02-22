using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public static class Intro
    {
        public static string Name()
        {
            string name;
            Console.SetCursorPosition((Console.BufferWidth - 25)/2, Console.BufferHeight / 2);
            Console.WriteLine("Please, input your name: ");
            name = Console.ReadLine();
            return name;
        }

        public static void PrintYellowBird()
        {
            //TODO: write code that paints big yellow bird ont the whole console
        }
    }
}

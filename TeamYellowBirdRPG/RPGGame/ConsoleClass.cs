using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    static class ConsoleClass
    {
        public static void Justify()
        {
            Console.WindowHeight = 41;
            Console.WindowWidth = 81;
            Console.SetBufferSize(81, 41);
            Console.CursorVisible = false;
        }

        public static void PrintBorders()
        {
            for (int i = 0; i <41; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(60, i);
                Console.Write("#");
                Console.SetCursorPosition(60, i);
                Console.ResetColor();
            }

            for (int i = 60; i < 81; i++)
            {
                Console.SetCursorPosition(i, 21);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("#");
                Console.SetCursorPosition(i, 21);
                Console.ResetColor();
            }

            for (int i = 0; i < 61; i++)
            {
                Console.SetCursorPosition(i, 35);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("#");
                Console.SetCursorPosition(i, 35);
                Console.ResetColor();
            }
        }
    }
}

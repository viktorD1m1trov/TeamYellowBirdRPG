using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public static class ConsoleClass
    {
        private const int ConsoleHeight = 41;
        private const int ConsoleWidth = 81;
        private const byte MidleInterfaceLinePosition = 21;
        private const byte VerticalLinePosition = 60;
        private const byte HorizontalLinePosition = 35;

        public static void SetConsoleSize()
        {
            Console.WindowHeight = ConsoleHeight;
            Console.WindowWidth = ConsoleWidth;
            Console.SetBufferSize(ConsoleWidth, ConsoleHeight);
            Console.CursorVisible = false;
        }

        public static void PrintBorders()
        {
            for (int i = 0; i < ConsoleHeight; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(VerticalLinePosition, i);
                Console.Write("#");
                Console.SetCursorPosition(VerticalLinePosition, i);
                Console.ResetColor();
            }

            for (int i = VerticalLinePosition; i < ConsoleWidth; i++)
            {
                Console.SetCursorPosition(i, MidleInterfaceLinePosition);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("#");
                Console.SetCursorPosition(i, MidleInterfaceLinePosition);
                Console.ResetColor();
            }

            for (int i = 0; i <= VerticalLinePosition; i++)
            {
                Console.SetCursorPosition(i, HorizontalLinePosition);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("#");
                Console.SetCursorPosition(i, HorizontalLinePosition);
                Console.ResetColor();
            }
        }
    }
}

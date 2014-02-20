using System;
using System.Collections.Generic;
using System.IO;

namespace RPGGame
{
    class Map
    {
        private string[] map = new string[36];
        private string[,] mapMatrix = new string[36, 60];

        public string[,] MapMatrix
        {
            get
            {
                return this.mapMatrix;
            }
        }

        public Map(string path)
        {
            StreamReader reader = new StreamReader(path);


            for (int i = 0; i < 36; i++)
            {
                map[i] = reader.ReadLine();
                for (int j = 0; j < 60; j++)
                {
                    mapMatrix[i, j] = map[i][j].ToString();
                }
            }
        }

        public void PrintWholeMap()
        {
            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    PrintColor(i, j);
                }
                
            }
        }

        public void PrintAroundPoint(int x,int y)
        {
            for (int i = x-2; i <=x+2; i++)
            {
                for (int j = y-2; j <=y+2; j++)
                {
                    if (i > 1 && i < 36 && j > 1 && j < 60)
                    {
                        PrintColor(i, j);
                    }
                }
            }
        }
        public void PrintColor(int x, int y)
        {
            Console.SetCursorPosition(y, x);
            if (mapMatrix[x, y] == "0")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            else if (mapMatrix[x, y] == "1")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(" ");
            }
            else if (mapMatrix[x, y] == "2" || mapMatrix[x, y] == "3")
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(" ");
            }
            else if (mapMatrix[x, y] == "4")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(" ");
            }
            Console.ResetColor();
        }
    }
}

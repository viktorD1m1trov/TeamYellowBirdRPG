using System;
using System.Collections.Generic;
using System.IO;

namespace RPGGame
{
    class Map
    {
        private string[] map = new string[35];
        private string[,] mapMatrix = new string[35, 60];

        //TODO: ADD A BOOL MATRIX TO CHECK IF HAS BEEN THERE 

        //ADD A BOOL RETURNING METHOD, THAT YOU GIVE X and Y, AND RETURNS IF THE HERO HAS BEEN THERE                    public bool WasVisited(int x, int y)
        //ADD A BOOL RETURNING METHOD, THAT YOU GIVE X and Y, AND RETURNS IF THE POSITION AT X and Y CAN BE STEPPED ON  public bool CanBeStepped(int x, int y)
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


            for (int i = 0; i < 35; i++)
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
            for (int i = 0; i < 35; i++)
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
                    if (i >=0 && i < 35 && j >=0 && j < 60)
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

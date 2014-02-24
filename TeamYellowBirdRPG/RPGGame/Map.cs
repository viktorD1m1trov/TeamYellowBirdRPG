namespace RPGGame
{
using System;
using System.IO;
    using System.Collections.Generic;

    public class Map
    {
    //class Map
    //{
        //private string[] map = new string[35];
        //private string[,] mapMatrix = new string[35, 60];
        //private bool[,] visited = new bool[35, 60];

        private string[] currentLine;  // old name map
        private string[,] mapMatrix;
        private bool[,] wasVisited;
        private List<Coordinates> givenRandomNumbers= new List<Coordinates>();
        
        //ADD A BOOL MATRIX TO CHECK IF HAS BEEN THERE 
        // TO DO: integrate the above

        //ADD A BOOL RETURNING METHOD, THAT YOU GIVE X and Y, AND RETURNS IF THE HERO HAS BEEN THERE                    public bool WasVisited(int x, int y)
        //ADD A BOOL RETURNING METHOD, THAT YOU GIVE X and Y, AND RETURNS IF THE POSITION AT X and Y CAN BE STEPPED ON  public bool CanBeStepped(int x, int y)

        public string[,] MapMatrix
        {
            get
            {
                return (string[,])this.mapMatrix.Clone(); //Returning new matrix to protect the original
            }
            set
            {
                this.mapMatrix = value;
            }
        }

        public bool[,] WasVisited
        {
            get
            {
                return (bool[,])this.wasVisited.Clone(); //Returning new matrix to protect the original
            }
        }

        public Map(string path)
        {
            currentLine = new string[ConsoleClass.HorizontalLinePosition];
            mapMatrix = new string[ConsoleClass.HorizontalLinePosition, ConsoleClass.VerticalLinePosition];
            wasVisited = new bool[ConsoleClass.HorizontalLinePosition, ConsoleClass.VerticalLinePosition];

            StreamReader reader = new StreamReader(path);

            using (reader)
            {
                for (int i = 0; i < ConsoleClass.HorizontalLinePosition; i++)
            {
                    currentLine[i] = reader.ReadLine();
                    for (int j = 0; j < ConsoleClass.VerticalLinePosition; j++)
                {
                        mapMatrix[i, j] = currentLine[i][j].ToString();
                    }
                }
            }
        }


        // TO DO: Extract all print methods to separate class
        public void PrintWholeMap()
        {
            for (int i = 0; i < ConsoleClass.HorizontalLinePosition; i++)
            {
                for (int j = 0; j < ConsoleClass.VerticalLinePosition; j++)
                {
                    PrintColor(i, j);
                }
                
            }
        }

        public bool CanBeStepped(int x, int y)
        {
            if (x >= 0 && x < ConsoleClass.HorizontalLinePosition & y >= 0 && y < ConsoleClass.VerticalLinePosition)
            {
                if (this.MapMatrix[x, y] == "0")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;

            }

        }

        public void PrintMatrix()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < ConsoleClass.HorizontalLinePosition; i++)
            {
                for (int j = 0; j < ConsoleClass.VerticalLinePosition; j++)
                {
                    Console.Write(this.MapMatrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        public Coordinates RandomFreePosition()
        {
            int seed = int.Parse((DateTime.Now.Ticks%100000).ToString());
            System.Threading.Thread.Sleep(5);
            Random randomGenerator = new Random(seed);
            int x, y;
            x = randomGenerator.Next(ConsoleClass.HorizontalLinePosition);
            y = randomGenerator.Next(ConsoleClass.VerticalLinePosition);
            while(!this.CanBeStepped(x,y))
            {
                x = randomGenerator.Next(ConsoleClass.HorizontalLinePosition);
                y = randomGenerator.Next(ConsoleClass.VerticalLinePosition);

            }
            return new Coordinates(x, y);
        }

        public void InputCreaturesInMap(List<Creeper> creepers)
        {
            foreach (var creep in creepers)
            {
                int creeperNumber = 0;
                if (creep.GetType().Name == "Goblin")
                {
                    creeperNumber = 5;
                }
                else if (creep.GetType().Name == "Orc")
                {
                    creeperNumber = 6;
                }
                this.mapMatrix[creep.Position.X, creep.Position.Y] = creeperNumber.ToString();
            }
        }
        public void PrintAroundPoint(int x,int y)
        {
            for (int i = x-3; i <=x+3; i++)
            {
                for (int j = y-3; j <=y+3; j++)
                {
                    if (i >= 0 && i < ConsoleClass.HorizontalLinePosition && j >= 0 && j < ConsoleClass.VerticalLinePosition)
                    {
                        PrintColor(i, j);
                    }
                }
            }
            for (int i = x - 4; i <= x + 4; i++)
            {
                for (int j = y - 2; j <= y + 2; j++)
                {
                    if (i >= 0 && i < ConsoleClass.HorizontalLinePosition && j >= 0 && j < ConsoleClass.VerticalLinePosition)
                    {
                        PrintColor(i, j);
                    }
                }
            }
            for (int i = x - 2; i <= x + 2; i++)
            {
                for (int j = y - 4; j <= y + 4; j++)
                {
                    if (i >= 0 && i < ConsoleClass.HorizontalLinePosition && j >= 0 && j < ConsoleClass.VerticalLinePosition)
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
            else if (mapMatrix[x, y] == "5")
            {
                Console.Write("g");
            }
            else if (mapMatrix[x, y] == "6")
            {
                Console.Write("O");
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

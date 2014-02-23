namespace RPGGame
{
    using System;
    using System.IO;

    public class Map
    {
        private const byte PrintAreaAroundHero = 3;

        private string[] currentLine;  // old name map
        private string[,] mapMatrix;
        private bool[,] wasVisited;

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
        }

        public string[,] WasVisited
        {
            get
            {
                return (string[,])this.wasVisited.Clone(); //Returning new matrix to protect the original
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

        public void PrintAroundPoint(int x, int y)
        {
            for (int i = x - PrintAreaAroundHero; i <= x + PrintAreaAroundHero; i++)
            {
                for (int j = y - PrintAreaAroundHero; j <= y + PrintAreaAroundHero; j++)
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
            else if (mapMatrix[x, y] == "4")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(" ");
            }

            Console.ResetColor();
        }
    }
}

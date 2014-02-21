using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RPGGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleClass.Justify();
            ConsoleClass.PrintBorders();
            Map mymap = new Map("60map.txt");

            mymap.PrintWholeMap();
            MessageBox.Print("Telerik Team Yellow Bird");
            MessageBox.Print("Press Enter to Continue");
            MessageBox.Print("Testing commiting!");
            Console.ReadLine();
            MessageBox.Clear();
            Console.ReadLine();
        }
    }
}

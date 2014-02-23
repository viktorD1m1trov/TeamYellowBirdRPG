using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RPGGame
{
    public class Program
    {
        public const string MapPath = "60map.txt";

        public static void Main()
        {
            ConsoleClass.SetConsoleSize(); // old name Justify

            // printing intro page
            Intro.PrintYellowBird();

            string heroName = Hero.EnterName();  // moved from class Intro to Hero + renamed
            Hero myHero = new Hero(heroName, new Coordinates(18, 34), 100);

            Map mymap = new Map(MapPath);
            ConsoleClass.PrintBorders();
            
            mymap.PrintAroundPoint(myHero.Position.X, myHero.Position.Y);
            myHero.PrintHero();

            while (true)
            {

                //TODO:Make methods MoveUp,MoveDown,MoveLeft,MoveRight in the Alive class !!!!!!!

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        myHero.Position.X--; //here needs to be the method StepUp(), that uses the method map.CanBeStepped()!!! 
                    }
                    else if (key.Key == ConsoleKey.DownArrow)           //TODO: MOVE ALL THIS METHODS IN THE HERO CLASS and check if the position is avaliable to step by using
                    {                                                   //map.CanBeStepped()    
                        myHero.Position.X++;
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        myHero.Position.Y--;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        myHero.Position.Y++;
                    }

                    mymap.PrintAroundPoint(myHero.Position.X, myHero.Position.Y);
                    myHero.PrintHero();
                }
            }



            //TOVA E TESTOV KOMENTAR S CEL PROVERKA NA RABOTATA S GITHUB.......==
            // test OK ... - lenchev            

            //mymap.PrintWholeMap();
            MessageBox.Print("Hello, " + myHero.Name);
            MessageBox.Print("This is  Team Yellow Bird's RPG Game");

            Console.ReadLine();
            MessageBox.Clear();
            Console.ReadLine();
        }
    }
}

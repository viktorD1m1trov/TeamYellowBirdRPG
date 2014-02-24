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
            Hero myHero = new Hero(heroName);

            Map mymap = new Map(MapPath);
            ConsoleClass.PrintBorders();


            mymap.PrintAroundPoint(myHero.Position.X, myHero.Position.Y);
            myHero.PrintHero();
            MessageBox.Print("Hello, " + myHero.Name);
            MessageBox.Print("This is  Team Yellow Bird's RPG Game");
            MessageBox.Print("Enjoy !");

            while (true)
            {

                //TODO:Make methods MoveUp,MoveDown,MoveLeft,MoveRight in the Alive class (abstract in the Alive class, also in the IAlive and in Hero class)!!!!!!!
                //Methods should use mymap.CanBeStepped() method !!!!

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        if (mymap.CanBeStepped(myHero.Position.X - 1, myHero.Position.Y))
                        {
                            myHero.MoveUp();
                        }
                    }
                    else if (key.Key == ConsoleKey.DownArrow)           //TODO: MOVE ALL THIS METHODS IN THE HERO CLASS and check if the position is avaliable to step by using
                    {                                                   //mymap.CanBeStepped();
                        if (mymap.CanBeStepped(myHero.Position.X + 1, myHero.Position.Y))
                        {
                            myHero.MoveDown();
                        }
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        if (mymap.CanBeStepped(myHero.Position.X, myHero.Position.Y - 1))
                        {
                            myHero.MoveLeft();
                        }
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        if (mymap.CanBeStepped(myHero.Position.X, myHero.Position.Y + 1))
                        {
                            myHero.MoveRight();
                        }
                    }

                    if (mymap.WasVisited[myHero.Position.X, myHero.Position.Y] == false)
                    {
                        mymap.PrintAroundPoint(myHero.Position.X, myHero.Position.Y);
                        mymap.WasVisited[myHero.Position.X, myHero.Position.Y] = true;
                    }
                    myHero.PrintHero();

                }
            }



            //TOVA E TESTOV KOMENTAR S CEL PROVERKA NA RABOTATA S GITHUB.......==
            // test OK ... - lenchev            

            //mymap.PrintWholeMap();

            
            Console.ReadLine();
            MessageBox.Clear();
            Console.ReadLine();
        }
    }
}

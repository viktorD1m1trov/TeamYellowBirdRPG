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

            
            Map mymap = new Map("60map.txt");

            string heroName=Intro.Name();
            Console.Clear();
            Hero myHero = new Hero(heroName, new Coordinates(18, 34), 100);
            ConsoleClass.PrintBorders();
            mymap.PrintAroundPoint(myHero.Position.x, myHero.Position.y);
            myHero.PrintHero();
            
            while(true)
            {
                
                //TODO:Make methods MoveUp,MoveDown,MoveLeft,MoveRight in the Alive class !!!!!!!

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if(key.Key==ConsoleKey.UpArrow) 
                    {
                        myHero.Position.x--; //here needs to be the method StepUp(), that uses the method map.CanBeStepped()!!! 
                    }
                    else if (key.Key == ConsoleKey.DownArrow)           //TODO: MOVE ALL THIS METHODS IN THE HERO CLASS and check if the position is avaliable to step by using
                    {                                                   //map.CanBeStepped()    
                        myHero.Position.x++;
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        myHero.Position.y--;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        myHero.Position.y++;
                    }

                    mymap.PrintAroundPoint(myHero.Position.x, myHero.Position.y);
                    myHero.PrintHero();
                }
            }



            //TOVA E TESTOV KOMENTAR S CEL PROVERKA NA RABOTATA S GITHUB.......==
            // test OK ... - lenchev            

            //mymap.PrintWholeMap();
            MessageBox.Print("Hello, "+myHero.Name);
            MessageBox.Print("This is  Team Yellow Bird's RPG Game");
            
            Console.ReadLine();
            MessageBox.Clear();
            Console.ReadLine();
        }
    }
}

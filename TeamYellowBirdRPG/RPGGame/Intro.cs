using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public static class Intro
    {
        public static string Name()
        {
            string name;
            Console.SetCursorPosition((Console.BufferWidth - 25)/2, Console.BufferHeight / 2);
            Console.Write("Please, input your name: ");
            name = Console.ReadLine();
            return name;
        }

        public static void PrintYellowBird()
        {
            Console.SetCursorPosition(0, Console.WindowHeight / 2-9);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(                                     
                    "                                 $$$$                     \n"+                    
                    "                               $$$$$$$                    \n"+                   
                    "                              $$ $$$$$$                   \n"+                   
                    "                         $$$$$$$$$$$$$$                   \n"+                   
                    "                         $$$$$$$$$$$$$$                   \n"+                    
                    "                              $$$$$$$$                    \n"+                    
                    "                               $$$$$$    $$$$$            \n"+                    
                    "                                 $$$$  $$$$$$$$$          \n"+                     
                    "                                $$$$$$$$$$$$$$$$$$        \n"+                     
                    "                                $$$$$$$$$$$$$$$$$$$$      \n"+                     
                    "                                $$$$$$$$$$$$$$$$$$$$$$$$  \n"+                     
                    "                                $$$$$$$$$$$$$$$$$$$$$$$   \n"+                    
                    "                                  $$$$$$$$$$$$$$$$$$      \n"+                    
                    "                                    $$$$$$$$$$$$$$        \n"+                    
                    "                                         $$               \n"+                    
                    "                                         $$               \n"+                    
                    "                                         $$               \n"+                    
                    "                                      $$$$$$              \n" );
            Console.ResetColor();
        }
    }
}

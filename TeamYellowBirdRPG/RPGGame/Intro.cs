namespace RPGGame
{
    using System;

    public static class Intro
    {
        public static void PrintYellowBird()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(bird1);
            Console.ResetColor();
            Console.WriteLine("Variant One... Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(bird2);
            Console.ResetColor();
            Console.WriteLine("Variant Two... Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        // TODO - should be putted in to external txt file
        const string bird1 = @"
                


                                             _______
                                         _.-'       ''...._
                                       .'        .--.    '.`
                                      : .--.    :    :     '-.
                                     : :    :   :    :       :`
                                     : :  @ :___:  @ : __     '`.
                                 __..:---''''   `----''  `.   .''
                         __..--''                   ___j  :   :
                 __..--''    .--'             __..''      :    `.
           ..--''                     __..--''        __..'   /``
         .'                   __..--''        __..--''       /
        :             __..--''        __..--''               \
       :        _.--''        __..--''    :                :`.:
      :     _.-'      __..--''             :              /
      :   .'  __..--''                      \            /
      \  :--''                               \          .'
       \ :                                    :         :
        \:                                     :        \
         '                                     :         \
                                                               
              __   __   _ _                 ____  _         _ 
              \ \ / /__| | | _____      __ | __ )(_)_ __ __| |
               \ V / _ \ | |/ _ \ \ /\ / / |  _ \| | '__/ _` |
                | |  __/ | | (_) \ V  V /  | |_) | | | | (_| |
                |_|\___|_|_|\___/ \_/\_/   |____/|_|_|  \__,_|
                                                                                          
                                                                 
               
                ";
        const string bird2 = @"
                



                                  \/
                                __.---;_
                              .'  './'0)',\
                              |o)  |     | ';
                              :'--; \.__/'   ;
                               ;.' (         |
                          __.-'   _.)        |
                    ---=='=----'''           |
                             ;^;         .  ^+^^;
                           ;^  :         :       ^;
                            \  {          :_     /
                             ^'-;          :'--'^
                                ',,____,,-'
             
                             __   _______   ______
                   ============(((=======(((============
                                                               
              __   __   _ _                 ____  _         _ 
              \ \ / /__| | | _____      __ | __ )(_)_ __ __| |
               \ V / _ \ | |/ _ \ \ /\ / / |  _ \| | '__/ _` |
                | |  __/ | | (_) \ V  V /  | |_) | | | | (_| |
                |_|\___|_|_|\___/ \_/\_/   |____/|_|_|  \__,_|




               
";
        //public static void PrintYellowBird()
        //{
        //    Console.SetCursorPosition(0, Console.WindowHeight / 2-9);
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine(                                     
        //            "                                 $$$$                     \n"+                    
        //            "                               $$$$$$$                    \n"+                   
        //            "                              $$ $$$$$$                   \n"+                   
        //            "                         $$$$$$$$$$$$$$                   \n"+                   
        //            "                         $$$$$$$$$$$$$$                   \n"+                    
        //            "                              $$$$$$$$                    \n"+                    
        //            "                               $$$$$$    $$$$$            \n"+                    
        //            "                                 $$$$  $$$$$$$$$          \n"+                     
        //            "                                $$$$$$$$$$$$$$$$$$        \n"+                     
        //            "                                $$$$$$$$$$$$$$$$$$$$      \n"+                     
        //            "                                $$$$$$$$$$$$$$$$$$$$$$$$  \n"+                     
        //            "                                $$$$$$$$$$$$$$$$$$$$$$$   \n"+                    
        //            "                                  $$$$$$$$$$$$$$$$$$      \n"+                    
        //            "                                    $$$$$$$$$$$$$$        \n"+                    
        //            "                                         $$               \n"+                    
        //            "                                         $$               \n"+                    
        //            "                                         $$               \n"+                    
        //            "                                      $$$$$$              \n" );
        //    Console.ResetColor();
        //}
    }
}

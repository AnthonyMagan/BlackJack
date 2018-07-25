using System;

namespace BlackJack
{
    public class SettingsConsoleStartup
    {
        // sets the display of the console at startup.
        public static void TitleBox()
        {
            // makes the window as long(almost) as possible up to a certain
            // window height of 65, which is as long as it ever needs to be
            Console.WindowHeight = Console.LargestWindowHeight - 5;
            Console.BufferHeight = Console.LargestWindowHeight - 5;
            if (Console.WindowHeight > 65)
            {
                Console.WindowHeight = 45;
                Console.BufferHeight = 45;
            }
            Console.WindowWidth = 60;
            Console.BufferWidth = 60;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Title = "BlackJack";
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("\n\t      ******************************");
            Console.WriteLine("\t      *                            *");
            Console.WriteLine("\t      *     BLACKJACK EMPORIUM     *");
            Console.WriteLine("\t      *                            *");
            Console.WriteLine("\t      ******************************");
            Console.WriteLine();
        }
    }
}

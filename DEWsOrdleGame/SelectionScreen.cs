
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEWsOrdleGame
{
    internal class SelectionScreen
    {
        public static void Selection()

        {
            Program program = new Program();
       
            Console.WriteLine(
                "1.Play " +
                "2.Leaderboard " +
                "3.Credits " +
                "4.Rules");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            char key = keyInfo.KeyChar;


            if (key == '1')
            {
                Words.StringSelection();
                Utilities.game.StartGame();
            }
            if (key == '2')
            {
                Leaderboard();
            }
            if (key == '3')
            {
                Credits();
            }
            if (key == '4')
            {
                Console.Clear();
                Console.WriteLine("The Object Of This Game Is to Guess The Characters of a random 5 Letter Word To Win.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nWhen You Successfully Guess A Letter In The Right Place You Will Hear A Beep And The Console Will Turn Green.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nWhen You Successfully Guess A Letter In The Wrong Place The Console Will Turn Grey.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWhen You Incorrectly Guess A Letter The Console Will Turn Red And You Will Take Damage" +
                    "\nIf You Incur Too Much Damage You Will Die And Lose The Game.");
                Console.ResetColor();

                Console.ReadKey();
                Console.Clear();
                Selection();
            }
            else
            { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("INCORRECT INPUT Please select an Option"); Console.ResetColor(); Selection(); }
            

        }
        public static void Leaderboard()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Hello {Player.PlayerName}, You Have {Player.Wins} Wins and Have Earned {Player.Points} Points. \n\n Keep Playing and EARN MORE");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            Selection();
        }
        public static void Credits()
        {
            Console.Clear();
            Utilities.Print(Utilities.credits);
            Console.ReadKey();
            Console.Clear();
            Selection();

        }


    }
}

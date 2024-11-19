using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DEWsOggle
{
    public class Engine
    {
        private Stopwatch gameTimer = new Stopwatch();
        private Player player = new Player();
        private Gameboard board = new Gameboard();
        int WinPoints = 4;
        string S = "s ";
        int Rounds = 1;
        
       public void SetUp()
        {
            //TODO add ability 
            //print the letters of the board 
       
           
            
            Console.Title = "DEWsOggle";
            Console.WriteLine("Welcome To DEWsOggle Game.");
            Console.WriteLine("Please Enter Your Name Then Press Anything To Continue");
            player.Playername = Console.ReadLine();
           
            Console.Clear();
            gameTimer.Start();
            Runtime();

        }
        private void Runtime()
        {
            S = "s ";
            if (WinPoints == 1)
            {
                S = " ";
            }
           //add Game timer
            if (WinPoints == 0)
            {
                Rounds++;
              
                Ending();
            }
                Console.WriteLine($"\n\n{player.Playername}\nCurrent Score:{player.Score}    Round:{Rounds}");
            Console.WriteLine($"\n\nYou Need To Guess {WinPoints} Word{S}To Win.");
            Console.WriteLine("\n\nUsing The Letters Below. Please Guess A Word.");
            
            PrintBoard();
            Console.WriteLine("Word: ");
            string input = Console.ReadLine();
            if (input != "x")
            {
                if (isValid(input))
                {
                    if (!hasGuessed(input))
                    {
                        WinPoints--;
                        player.Score += input.Length;
                        Console.Beep();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You Found A Word!\nIt Was Worth {input.Length} Points");
                    }
                    if (hasGuessed(input))
                    {
                        
                        
                      
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You Have Already Guessed This Word!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect Guess");
                    
                }

                // is it a valid word
                // has the player already guessed that word
                //valid and it hasnt been guessed - increase score
                player.guessedWords.Add(input);
                Console.ResetColor();
                Console.WriteLine("Your Current Score Is: " + player.Score + ", press any key to continue...");
               
                Console.ReadKey();
                Console.Clear();
                Runtime();
            }
        }
        private bool hasGuessed(string word)
        {
            foreach (string s in player.guessedWords)
            {
                if (s == word)
                {
                    return true;
                }

            }
            return false;
        }
        private bool isValid(string word)
        {
            foreach (string s in board.potentialWords)
            {
                if (s == word)
                {
                    return true;
                }

            }
            return false;
        }
        private void PrintBoard()
        {
            int index = 0;
            foreach (String s in board.boardLetters)
            {
                Console.Write(s + ",");
            }
            Console.WriteLine("\n\n");
            //4 x 4
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    index = 4 * i + j;
                    Console.Write($"{board.boardLetters[index]} ");
                }
                Console.WriteLine();
            }
        }
        private void Ending()
        {
            
            if (Rounds == 5)
            {
                S = "'s";
                gameTimer.Stop();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("CONGRATULATION YOU GUESSED ALL OF THE WORDS AND BEAT THE GAME. There Is Nothing Else Left To Do But Bask In Your Victory");
                Console.WriteLine($"----LEADERBOARD----\n{player.Playername}{S} Final Score:{player.Score}\n\nRounds Played:{Rounds}     Time Played:{gameTimer.Elapsed.Minutes}m {gameTimer.Elapsed.Seconds}s");
                Console.ReadKey();
                Console.ReadKey();
                Environment.Exit(0);
            }

            gameTimer.Stop();
            Console.WriteLine($"You Did It!\nYou Won Round {Rounds - 1}.\nWould You Like To Go To Round {Rounds} or Completely Restart?\n");
            Console.WriteLine("1.Continue\n2.Quit\nor\n3.Restart");
            ConsoleKeyInfo EndkeyInfo = Console.ReadKey(true);
            char End = EndkeyInfo.KeyChar;
            if (End == '1')
            {
               
                if (Rounds == 2)
                {
                    WinPoints = 6;
                }
                if (Rounds == 3)
                {
                    WinPoints = 8;
                }
                if (Rounds == 4)
                {
                    WinPoints = 10;
                }
                gameTimer.Start();
                Console.Clear();
                Runtime();
            }
            if (End == '2')
            {
                S = "'s";
                Console.Clear();
                Console.WriteLine($"----LEADERBOARD----\n{player.Playername}{S} Final Score:{player.Score}\n\nRounds Played:{Rounds}     Time Played:{gameTimer.Elapsed.Minutes}m{gameTimer.Elapsed.Seconds}s");

                Console.WriteLine("\n\nGoodbye");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (End == '3')
            {
                S = "'s";
                Console.Clear();
                Console.WriteLine($"----LEADERBOARD----\n{player.Playername}{S}  Final Score:{player.Score}\n\nRounds Played:{Rounds}     Time Played:{gameTimer.Elapsed.Minutes}m {gameTimer.Elapsed.Seconds}s");
                Console.WriteLine("Trying To Go For More Points I See, Press Anything To Continue");
                Console.ReadKey();      
                //Reset Game Timer
                //Reset Scores
                Rounds = 1;
                player.Score = 0;
                WinPoints = 4;
                player.guessedWords.Clear();
                gameTimer.Reset();
                Console.Clear();
     
        
                SetUp();
               
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect Input");
                Console.ResetColor();
                gameTimer.Start();
               
            Ending();
            }
        }
    }
}

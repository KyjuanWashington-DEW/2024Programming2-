using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DEWsOrdleGame
{
    public class Game
    {
        public static Player Player = new Player();
        public static bool Freeletter = false;
        public static int RoundPoints = 0;
        public static int Round = 1;
        public static int PositionNum = 0;
        public static string Hint;

        public void StartGame()
        {
            Player.HP = 10;
            Words.SelectedWord = "";
            Words.StringSelection();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($@"
{Player.PlayerName} 
Round:{Round}
{Words.SelectedWordPlaceholder}
1. Guess
2. Quit
");
           // 2.Free Letter

                        ConsoleKeyInfo keyInfo2 = Console.ReadKey(true);
            char key2 = keyInfo2.KeyChar;

            if (key2 == '1')
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Guess();
            }
            //else if (key2 == '2')
            //{
            //    FreeLetter();
            //}
            else if (key2 == '2')
            {
                Quit();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect Input, Press Anything To Try Again");
                Console.ReadKey();
                StartGame();
            }
        }

        public static void Guess()
        {


            if (Player.HP == 0)
            {
               
                Console.Clear();
                Utilities.LossesPhrase();
                Utilities.Print(Utilities.SelectedLossPhrase);
                Quit();
            }


           if (Words.SelectedWord == "depth")
            {
                Hint = "Definition: The Colloquial Term For The Vertical Measurement Of Deep Waters";
            }
            else if (Words.SelectedWord == "plane")
            {
                Hint = "Definition: An Infinitely Flat Surface";
            }
            else if (Words.SelectedWord == "maker")
            {
                Hint = "A Synonym For Creator";
            }
            else if (Words.SelectedWord == "array")
            {
                Hint = "A Synonym For Collection";
            }
            else if (Words.SelectedWord == "death")
            {
                Hint = "A Synonym For Quietus";
            }
            else if (Words.SelectedWord == "blame")
            {
                Hint = "Definition: An Appointment Of Fault";
            }
            else if (Words.SelectedWord == "final")
            {
                Hint = "Definition: After The Penultimate";
            }
            else if (Words.SelectedWord == "third")
            {
                Hint = "A Synonym For Antepenultimate";
            }
            Console.Clear();
           

            Console.WriteLine($@"
{Player.PlayerName} Health:{Player.HP}
{Words.SelectedWordPlaceholder}
.....
12345
    
Please Select A Letter Place To Guess

-HINT-
{Hint}

");
//        Definition: The Lateral Position of The 3RD Dimension
//Definition: An Infinitely Flat Surface in Any Dimension
//A Synonym For Creator
//A Synonym For Collection
//A Synonym For Quietus
//Definition: An Appointment Of Fault
            ConsoleKeyInfo keyGuessing = Console.ReadKey(true);
            PositionNum = keyGuessing.KeyChar - '0'; 

            if (PositionNum >= 1 && PositionNum <= 5)
            {
                Guessing();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect Input, Press Anything To Try Again");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Guess();
            }
        }

        public static void Guessing()
        {


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($@"
{Player.PlayerName} Health: {Player.HP}
{Words.SelectedWordPlaceholder}
Please Enter A LOWERCASE Letter");

            ConsoleKeyInfo WordGuessInput = Console.ReadKey(true);
            char WordGuess = WordGuessInput.KeyChar;

            if (!char.IsLower(WordGuess))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a LOWERCASE letter.");
                Console.ReadKey();
                Guessing(); 
                return;
            }

            
            if (WordGuess == Words.SelectedWord[PositionNum - 1])
            {
                CorrectGuess(PositionNum - 1);
            }
            else if (Words.SelectedWord.Contains(WordGuess))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Almost but Not Quite... The Letter Was Correct But It Was Not In The Correct Place.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your Letter Was {WordGuess}");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Guess();
            }
            else
            {
                Player.HP--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect, Press Anything To Guess Again.");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Guess();
            }
        }

        private static void CorrectGuess(int position)
        {
            
            Words.SelectedWordPlaceholder = Words.SelectedWordPlaceholder.Substring(0, position) + Words.SelectedWord[position] + Words.SelectedWordPlaceholder.Substring(position + 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep();
           

            Player.Points++;
            RoundPoints++;

            
            Console.Clear();
            if (Words.SelectedWordPlaceholder == Words.SelectedWord)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Congratulations, You've Guessed the Word!");
                if (RoundPoints == 5)
                {
                    Round++;
                    Player.Wins++;
                    
                    Console.WriteLine($"Welcome To Round {Round} " +
                        $"\nPress 1. Continue Playing" +
                        $"\nPress 2. Quit");
                    ConsoleKeyInfo QuitOrPlayInput = Console.ReadKey(true);
                    char QoP = QuitOrPlayInput.KeyChar;
                    if (QoP == '1')
                    {
                        Words.SelectedWordPlaceholder = Words.SelectedWordPlaceholderDefault;
                            RoundPoints = 0;
                        
                        Utilities.game.StartGame();
                    }
                    else if (QoP == '2')
                    {
                        Words.SelectedWordPlaceholder = Words.SelectedWordPlaceholderDefault;
                        RoundPoints = 0;
                        Console.Clear();
                        
                        Quit();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Input, Press Anything To Try Again");
                        Console.ReadKey();
                        Round--;
                    }
                }

                    
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Guess(); 
            }
        }
        //Works 1x then kinda breaks the game If you are reading this Janell then you can reimplement it to test it out if you wish.
        private static void FreeLetter()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($@"
{Player.PlayerName}

{Words.SelectedWordPlaceholder}
Please Select A Free Letter Place
1. 2. 3.4.5.
6. Go Back
");

            ConsoleKeyInfo FreekeyInfo = Console.ReadKey(true);
            char freeLetter = FreekeyInfo.KeyChar;

           
            if (freeLetter == '1' && !Freeletter)
            {
                if (Words.SelectedWordPlaceholder[0] == '_')
                {
                    Words.SelectedWordPlaceholder = Words.SelectedWord[0] + Words.SelectedWordPlaceholder.Substring(1);
                    Freeletter = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Looks Like You Already Have A Correct Answer There.");
                    Console.ReadKey();
                    FreeLetter();
                }
            }

            if (freeLetter == '6')
            {
                Guessing();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect Input, Press Anything To Try Again");
                Console.ReadKey();
                FreeLetter();
            }
        }

        public static void Quit()
        {
            Utilities.Print(Utilities.gameOver);
            Utilities.Print(Utilities.credits);
            Console.WriteLine("\n\nPress Anything To See Your Score");
            Console.ReadKey();
            SelectionScreen.Leaderboard();
            SelectionScreen.Selection();
        }
    }
}

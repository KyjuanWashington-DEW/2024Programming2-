using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEWsOrdleGame
{
    internal class Utilities
    {
        public static Game game = new Game();
      public static string credits = "~Game Produced By DEW~ \n ~Code Credits To DEW~";
      public  static string gameWon = "Congrats! You Actually Managed To Beat The Game!";
       public static string gameOver = "Game Over. I Wish You Farewell...";
        public static string SelectedLossPhrase;
            public static List<string> LossPhrases = new List<string> { "Well... Atleast You Tried", "Better Luck Next Time", "Welp..." };
      public static void LossesPhrase()
        {
            Random RandomPhrase = new Random();

            int RandomLoss = RandomPhrase.Next(LossPhrases.Count);
            SelectedLossPhrase = LossPhrases[RandomLoss];
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEWsOrdleGame
{
    public static class Words
    {
        public static string SelectedWordPlaceholderDefault = "_____";
        public static string SelectedWordPlaceholder = "_____";
        public static List<string> SelectableWords = new List<string> { "depth", "plane", "maker", "array", "death", "blame", "final", "third" };
        public static string SelectedWord = "";
        public static void StringSelection()
        {
            if (SelectedWord == "")
            {
                Random Random = new Random();
                int RandomWord = Random.Next(SelectableWords.Count);
                SelectedWord = SelectableWords[RandomWord];
            }

            
        }

    }
}


namespace DEWsOrdleGame
{

   public class Program
    {
      
        public static void Main()
        {
            

            Console.Title = "DEW'S Ordle Game";
            Console.WriteLine("Please Input Your Name Then Press Enter To Continue");
            Player.PlayerName = Console.ReadLine();
            Console.Clear();
            SelectionScreen.Selection();

        }



    }
}
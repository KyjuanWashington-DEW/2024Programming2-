namespace CardGames
{

    public class ApplesNOranges : Cardgame
    {


      
        public ApplesNOranges(string[] suits, int deckSize, int Cardpoints)

        {
            d = new Deck(suits, deckSize, Cardpoints);
            GameEnvironment();

        }


        void GameEnvironment()
        {
            Console.Clear();
            Console.WriteLine($@"
 _______________
|  Apples and Oranges|
|---------------|
| {Selection.game.player.name,-10} |
| Points: {Points,5} |
|_______________|

Get 4 Points To Win or DIE

Press 1 to Draw A Card
");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;


            if (key == '1')
            {
                Console.Clear();
                d.ShuffleDeck(d.Cards);
                Card card1 = Drawcard();
                ShowPlayerHand(); // Show the player's hand after drawing
            }
            else
            {

                Console.Clear();
                Console.WriteLine("INCORRECT INPUT \n\n PRESS ENTER AND TRY AGAIN");
                Console.ReadKey();
                GameEnvironment();
            }

            Console.WriteLine("\nPress ENTER To Guess The Next Card's Suit Buckarooo.");
            Console.Read();
            Console.Clear();
            string guess = Guess();


            d.ShuffleDeck(d.Cards);
            Card card2 = Drawcard();

            if (guess == "1" && card2.Suit == "Souls")
            {
                Console.Clear();
                Points++;
                Console.WriteLine("\nYOU GOT IT RIGHT... for once in your life.");
            }
            if (guess == "2" && card2.Suit == "Minds")
            {
                Console.Clear();
                Points++;
                Console.WriteLine("\nYOU GOT IT RIGHT... for once in your life.");
            }
            if (guess == "1" && card2.Suit == "Minds")
            {
                Console.Clear();
                Console.WriteLine("\nYOU GOT IT wrong... as usual...");
            }
            if (guess == "2" && card2.Suit == "Souls")
            {
                Console.Clear();
                Console.WriteLine("\nYOU GOT IT wrong... as usual...");
            }
            if (Points == 4)
            {
                Console.Clear();
                Console.WriteLine("CONGRATULATIONS You Actually Won For Once!");
                Console.ReadKey();
                Quit2();
            }
            {

                Console.WriteLine("\nDo You Want To Continue? \n\n 1.Yes  2.No");
                player.RemoveCard();

                keyInfo = Console.ReadKey();
                key = keyInfo.KeyChar;



                if (key == '1')

                {
                    Console.Clear();
                    Console.WriteLine("Great!");
                    GameEnvironment();

                }

                if (key == '2')
                {
                    Quit();
                }
              

            }


            //if ()
            //    {
            //        Quit();

            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid expression. Press any key to try again...");
            //        Console.ReadKey();
            //    }
        }


    }
}







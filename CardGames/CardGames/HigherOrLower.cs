namespace CardGames
{


    public class HigherOrLower : Cardgame
    {



        //constructor passing referental arguments from base class
        public HigherOrLower(string[] suits, int deckSize, int Cardpoints)

        {
            d = new Deck(suits, deckSize, Cardpoints);
            GameEnvironment();

        }
        void GameEnvironment()
        {
            Console.Clear();
            Console.WriteLine($@"
             _______________
            |  Higher Or Lower|
            |---------------|
            | {Selection.game.player.name,-10} |
            | Points: {Points,5} |
            |_______________|

           Get 3 Points To Win OR DIE

Press 1 to Draw A Card

");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;


            if (key == '1')
            {
                Console.Clear();
                d.ShuffleDeck(d.Cards);
                Card card1 = Drawcard();
                Console.WriteLine("THIS IS YOUR 1ST CARD");
                ShowPlayerHand(); // Show the player's hand after drawing



               // Sally, Juettner,  She gave me The idea to write the guess system as a string. super convenient for this
                string guess = Guess();

                //removed bracket
                d.ShuffleDeck(d.Cards);
                Card card2 = Drawcard();



                if (guess == "1" && card1.Value > card2.Value)
                {
                    Console.Clear();

                    ShowPlayerHand();
                    Console.WriteLine("THESE ARE YOUR 1ST and 2ND CARDS");
                    Points++;
                    Console.WriteLine("\nYOU GOT IT RIGHT... for once in your life.");

                }
                if (guess == "1" && card1.Value < card2.Value)
                {
                    Console.Clear();
                    ShowPlayerHand();
                    Console.WriteLine("THESE ARE YOUR 1ST and 2ND CARDS");

                    Console.WriteLine("\nYOU GOT IT wrong... as usual...");
                }
                if (guess == "1" && card1.Value == card2.Value)
                {
                    Console.Clear();
                    ShowPlayerHand();
                    Console.WriteLine("THESE ARE YOUR 1ST and 2ND CARDS");
                    Points++;
                    Console.WriteLine("\nEqual Cards... You Have Challenger's Authority.I'll Allow It. 1 Point");
                }
                if (guess == "2" && card2.Value < card1.Value)
                {
                    Console.Clear();
                    ShowPlayerHand();
                    Console.WriteLine("THESE ARE YOUR 1ST and 2ND CARDS");
                    Console.WriteLine("\nYOU GOT IT wrong... as usual...");
                }
                if (guess == "2" && card2.Value > card1.Value)
                {
                    Console.Clear();
                    ShowPlayerHand();
                    Console.WriteLine("THESE ARE YOUR 1ST and 2ND CARDS");
                    Points++;
                    Console.WriteLine("\nYOU GOT IT RIGHT... for once in your life.");
                }
                if (guess == "2" && card2.Value == card1.Value)
                {
                    Console.Clear();
                    ShowPlayerHand();
                    Console.WriteLine("THESE ARE YOUR 1ST and 2ND CARDS");
                    Points++;
                    Console.WriteLine("\nEqual Cards... You Have Challenger's Authority. I'll Allow It. 1 Point");
                }
                if (Points == 3)
                {
                    Console.Clear();
                    Console.WriteLine("CONGRATULATIONS You Actually Won! You Wont Next Time!");
                }

                {
                    Console.WriteLine("\nDo You Want To Continue? \n\n 1.Yes  2.No");
                    player.RemoveCard();

                    keyInfo = Console.ReadKey();
                    key = keyInfo.KeyChar;



                    if (key == '1')

                    {

                        Console.WriteLine("Great!");

                        GameEnvironment();

                    }

                    if (key == '2')
                    {


                        Quit();
                    }



                    else
                    {
                        Console.WriteLine("Invalid expression. Press any key to try again...");
                        Console.ReadKey();
                        GameEnvironment();
                    }
                }
            }

            string Guess()
            {
                Console.WriteLine("\n\nGuess Which Card Is Going To Be Higher Or Lower Buckarooo.\n");
                Console.WriteLine("Press 1 If You Believe Your 1ST Card Was Higher. \n Press 2 If You Believe Your 2ND Card Will Be Higher.\n Press ENTER When Done.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char key = keyInfo.KeyChar;


                Console.Read();
                return key.ToString();
                Console.Clear();
            }
        }
    }
}


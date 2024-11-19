namespace CardGames
{
    public class Rummy : Cardgame
    {

        //Never Got To Implement May Revisit and Implement For Practice
        //constructor passing referental arguments from base class
        public Rummy(string[] suits, int deckSize, int Cardpoints)

        {
            d = new Deck(suits, deckSize, Cardpoints);
            GameEnvironment();

        }


        void GameEnvironment()
        {
            Console.WriteLine($@"
             _______________
            | Rummy|
            |---------------|
            | {Selection.game.player.name,-10} |
            | Points: {Points,5} |
            |_______________|
           
Press 1 to Draw A Card
Press 2 to Guess
Press 3 to View Your Hand
Press 4 to Quit
");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;


            if (key == '1')
            {
                d.ShuffleDeck(d.Cards);
                //PlayTurn();
            }
            if (key == '2')
            {
                Guess();

            }
            if (key == '3')
            {
                ShowPlayerHand();

            }
            if (key == '4')
            {
                Quit();

            }
            else
            {
                Console.WriteLine("Invalid expression. Press any key to try again...");
                Console.ReadKey();
            }
        }


    }
}


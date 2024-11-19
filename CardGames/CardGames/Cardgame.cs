
namespace CardGames
{


    public class Cardgame
    {

    





     
        public int Cards { get; set; }

        //cards with Ace, King, Queen, and Jack on them
        //add a joker card that does hp damage\\
        public int ImageCards { get; set; }
      

        //pointcount
        public int Points { get; set; } = 0;

        //quitgame or death art
        string DeathasciiArt { get; set; } = @"
         _____
        /     \
       | () () |
        \  ^  /
         |||||
         |||||
        ";























        public Cardgame()
        {

        }





        public Player player { get; private set; } = new Player(); // Player instance
        public Deck d { get; set; } // Deck instance

        public Cardgame(string[] suits, int deckSize, int Cardpoints)
        {
            d = new Deck(suits, deckSize, Cardpoints); // Initialize the deck
        }





        //START OF THE GAME
        public void Intro()
        {

            Console.WriteLine("Welcome To My Game, What is Your Name?");
            player.name = Console.ReadLine();


            Selection select = new Selection();
            select.gameselect();
        }

        List<string> CardImages = new List<string>();

        // Add the Jack card to the list
        //CardImages.Add(JackCard);

        //// Display the Jack card
        //Console.WriteLine("Jack Card:");
        //Console.WriteLine(CardImages[0]);

        ////Visual Method for each card in card deck and suit in card deck show the card art that represents the card and suit
        //string[] Cardimages = { JackCard};

        string JackCard = @"
,----------------.
|  _ _  wwwwwww  |
| ( "" )( ' ' )  |
|  `.'   ( - )   |
|  |   -------.  |
|\ |  |     .-') |
| --   |  .-'   )|
|     .-'      ) |
|  .-'      .-'  |
| (      .-'     |
| (   .-'  | --  |
| (.-'     | | \ |
| '--------  |   |
|  ( - )    .^.  |
| ( ' ' )( . )   |
| WWWWWWW  ""    |
`----------------'
        ";

        string QueenCard = @"
,----------------.
|  _ _  wwwwwww  |
| ( "" )( o o )  |
|  `.'   \ - /   |
| (')    -----.  |
|   \  (    .-') |
|     |  .-'   ) |
|     .-'      ) |
|  .-'      .-'  |
| (      .-'     |
| (   .-'  |     |
| (.-'   )    /  |
| '-----     (') |
|  / - \    .^.  |
| ( o o )( . )   |
| WWWWWWW  ""    |
`----------------'
        ";

        string KingCard = @"
,----------------.
|  _ _   MMMMM   |
| ( "" ) |o o|   |
|  `.'   \ - /   |
|  |/  ---`W'--. |
|  |\ |     .-') |
|     |  .-'   ) |
|     .-'      ) |
|  .-'      .-'  |
| (      .-'     |
| (   .-'  |     |
| (.-'     | \|  |
| '--.M.---  /|  |
|   / - \   .^.  |
|   |o o| ( . )  |
|   WWWWW  ""    |
`----------------'
        ";




        public Card Drawcard()
        {

            Card drawnCard = d.DrawCard2(); // Draw a card from the deck
            if (drawnCard != null) // Ensure a card was drawn
            {
                player.AddCard(drawnCard); // Add the drawn card to the player's hand


            }
            return drawnCard;
        }

        public virtual void ShowPlayerHand()
        {
            Console.WriteLine(".\n\nPlayer's Hand:");
            foreach (Card card in player.Hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}"); // Show player's hand
                //override in highest match
            }
        }






        public virtual void GameEnvironment()
        {


        }
        public void Quit2()
        {
            Console.Clear();
            Console.WriteLine("You Thought Id Just Let You Leave. MUHAHAHAHAHAHAHAHAHAHAH" + "\n" + "DIE..." + DeathasciiArt);
            Console.ReadKey();
            Console.Clear();
          
        }
        public void Quit()
        {
            Console.Clear();
            Console.WriteLine("So You're Giving Up Eh... Figures" + "\n" + "DIE..." + DeathasciiArt);
            Console.ReadKey();
            Console.Clear();
        }

        //got this from the demo code and changed it up.


        public string Guess()
        {
            Console.WriteLine("Press 1 To Guess For Souls. \n Press 2 To Guess Minds. ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;


            Console.Read();
            return key.ToString();
        }



    }





}





















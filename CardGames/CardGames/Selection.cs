namespace CardGames
{
    internal class Selection
    {



        public static Cardgame game = new Cardgame();

        public Selection()
        {

        }



        public void gameselect()
        {
            Console.Clear();
            Console.WriteLine("So Your Name's " + game.player.name + " Wanna Try Your Luck Huh? Well Let's See What You've Got.\n\n Pick An Option \n\n 1. Apples'n Oranges \n 2. Higher or Lower \n 3. Highest Match \n 4. Rules");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;
            if (key == '1')
            {

                game = new ApplesNOranges(new string[] { "Minds", "Souls" }, 26, 0);

            }
            else if (key == '2')
            {
                game = new HigherOrLower(new string[] { "Minds", "Souls", "Space", "Times" }, 52, 0);
            }
            else if (key == '3')
            {
             
                NPC npc = new NPC(); 
                List<Card> cards = new List<Card>(); 

                game = new HighestMatch( npc, cards, new string[] { "Minds", "Souls", "Space", "Times" }, 52, 0);
            }
            else if (key == '4')
            {
                Console.Clear();
                Console.WriteLine("RULES\n\n" +
                    "ApplesnOranges - Guess Which Card Will Appear Next Between 2 Suits.\n\n" +
                    "HigherOrLower - Guess Which Card Will Have A Higher Value Between Your 1ST and 2ND Drawn Card.\n\n" +
                    "HighestMatch - Determine Which Card To Keep From 4 Randomly Dealt Cards. See If You Can Have The Winning Hand By Ending The Round With The Highest Matching Cards.\n\n" +
                    "Press Any Key To Go Back To The Main Menu");

                Console.ReadKey();
                gameselect();
            }
            else
            {
                Console.WriteLine("Invalid Entry. Press Enter To Try Again Please." +
                    "");
                Console.ReadKey();
                gameselect();

            }

        }

    }
}

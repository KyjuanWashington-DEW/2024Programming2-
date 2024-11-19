namespace CardGames
{
   
    public class HighestMatch : Cardgame
    {
        int Rounds;
        string DeathasciiArt { get; set; } = @"
         _____
        /     \
       | () () |
        \  ^  /
         |||||
         |||||
        ";


        public HighestMatch( NPC npc, List<Card> cards, string[] suits, int deckSize, int Cardpoints)
        {
            d = new Deck(suits, deckSize, Cardpoints);
            GameEnvironment2( npc, cards);
        }

        void GameEnvironment2( NPC npc, List<Card> cards)
        {
            Console.Clear();
            Rounds++;
            Console.WriteLine($"Welcome To Round {Rounds} \n");
            Console.WriteLine($@"
             _______________
            |  Highest Match|
            |---------------|
            | {Selection.game.player.name,-10} |
            | Points: {Points,5} |
            |_______________|

            Win OR DIE
");

            RoundStart( npc, cards);

        }

        void RoundStart(NPC npc, List<Card> cards)
        {

            d.ShuffleDeck(d.Cards);

            List<Card> DealtCards = new List<Card>
            {
                d.DrawCard2(),
                d.DrawCard2(),
                d.DrawCard2(),
                d.DrawCard2()
            };
            List<Card> NPCDealtCards = new List<Card>
            {
                d.DrawCard2(),
                d.DrawCard2(),
                d.DrawCard2(),
                d.DrawCard2()
            };

            NPC npcs = new NPC();
            npcs.Hand = NPCDealtCards;
            Console.WriteLine("These Are Your Cards This Round");
            DisplayCards(DealtCards);
            Console.WriteLine("Taker's Cards This Round:");
            DisplayCards(npcs.Hand);


            Console.WriteLine("\n\nYou Can Choose To \n\n1. Replace A Card\nOr\n2. End The Round");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;

            if (key == '1')
            {
                ReplaceCard(DealtCards, npc, cards);
            }

            if (key == '2')
            {
                ValueCheck(DealtCards, npcs, cards);
            }
            else { Console.WriteLine("Invalid Expression. Try Again."); }

        }

        void ReplaceCard(List<Card> DealtCards, NPC npc, List<Card> cards)
        {
            Console.WriteLine("\n\nReplace Card\n1. Card 1\n2. Card 2\n3. Card 3\n4. Card 4");
            ConsoleKeyInfo keyInfo2 = Console.ReadKey();
            char key2 = keyInfo2.KeyChar;

            int cardIndex = key2 - '1'; // Convert char to index (1 -> 0, 2 -> 1, etc.)

            if (cardIndex >= 0 && cardIndex < DealtCards.Count)
            {

                DealtCards[cardIndex] = d.DrawCard2();
                Console.WriteLine("\nYour New Cards Are:");
                DisplayCards(DealtCards);
                Console.WriteLine("Press Anything To Go To See If You Won This Round.\n\n");
                Console.ReadKey();
                ValueCheck(DealtCards, npc, cards);
            }
            else
            {
                Console.WriteLine("\nInvalid Expression. Press Anything To Try Again.");
                Console.ReadKey();
               
                ReplaceCard(DealtCards,  npc, cards);
               
            }
        }

        void ValueCheck(List<Card> DealtCards, NPC npc, List<Card> cards)
        {

            var playerSuitValues = GetSuitValues(DealtCards);


            Console.WriteLine("Your Total Suit Values:");
            foreach (var suit in playerSuitValues)
            {
                Console.WriteLine($"{suit.Key}: {suit.Value}");
            }

            //Get Suit Total
            var npcSuitValues = GetSuitValues(npc.Hand);

            //Show Suit Total
            Console.WriteLine($"Taker's Total Suit Values:");
            foreach (var suit in npcSuitValues)
            {
                Console.WriteLine($"{suit.Key}: {suit.Value}");
            }

            //Comparison Of Points
            //foreach (Card item in cards)
            //{

            //    ////specify differwence here

            //}
            int playerTotal = playerSuitValues.Values.Max();
            int npcTotal = npcSuitValues.Values.Max();





            Console.WriteLine($"\nYour Total Points: {playerTotal}");
            Console.WriteLine($"\nTaker's Total Points: {npcTotal}");

            //Winner
            if (playerTotal > npcTotal)
            {
                Console.WriteLine("Congratulations! You won this round!");
                Console.WriteLine("Press Anything To Enter The Next Round");
                Console.ReadKey();
                ++Points;
                GameEnvironment2( npc, cards);
            }
            else if (playerTotal < npcTotal)
            {
                Console.WriteLine("The Taker wins this round!");
                Console.WriteLine("Press Anything To Enter The Next Round");
                Console.ReadKey();
                --Points;
                GameEnvironment2( npc, cards);
            }
            else
            {
                Console.WriteLine("Press Anything To Enter The Next Round");
                Console.ReadKey();
                Console.WriteLine("It's a tie!");
                GameEnvironment2( npc, cards);
            }

            //Endgame
            if (Rounds == 9)
            {
                if (Points == 4)
                {
                    Console.Clear();
                    Console.WriteLine("CONGRATULATIONS You Actually Won For Once!");
                    Console.ReadKey();
                }
                if (Points == -2)
                {
                    Console.Clear();
                    Console.WriteLine("Your Soul Belongs To The Taker" + DeathasciiArt + "");
                    Console.ReadKey();
                }
            }
        }

        Dictionary<string, int> GetSuitValues(List<Card> cards)
        {
            var suitValues = new Dictionary<string, int>();
            foreach (Card card in cards)
            {
                if(card != null)
                {

                }
                if (card != null)
                {
                    if (suitValues.ContainsKey(card.Suit))
                    {
                        suitValues[card.Suit] += card.Value;
                    }
                    else
                    {
                        suitValues[card.Suit] = card.Value;
                    }
                }
            }
            return suitValues;
        }

        void DisplayCards(List<Card> cards)
        {
            int Cardplace = 1;
            foreach (Card item in cards)
            {
                Console.WriteLine($"{Cardplace}. {item.Value} of {item.Suit} Is Worth {item.Value}");
                Cardplace++;
            }
        }
    }
}


















































































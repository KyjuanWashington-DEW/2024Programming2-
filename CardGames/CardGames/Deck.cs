namespace CardGames
{
    public class Deck
    {
        int deckSize { get; set; } = 52;
        int suitNumber { get; set; } = 4;

        public Deck()

        {


        }
        //List For Cards
        public List<Card> Cards { get; private set; } = new List<Card>();


        //I snatched some FisherYates Method and modified it
        
        public void ShuffleDeck(List<Card> unshuffledcards)
        {


            for (int i = unshuffledcards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                var temp = unshuffledcards[i];
                unshuffledcards[i] = unshuffledcards[j];
                unshuffledcards[j] = temp;
            }

        }

        Random random = new Random();




        public Deck(string[] suits, int deckSize, int Cardpoints)
        {
            MakeDeck(suits, deckSize, Cardpoints);
            ShuffleDeck2();//Remove After
        }

        public virtual void MakeDeck(string[] suits, int deckSize, int Cardpoints)
        {
            for (int i = 1; i <= deckSize / suits.Length; i++) // Card Loop
            {
                for (int j = 0; j < suits.Length; j++) // Suits Loop
                {
                    Cards.Add(new Card()
                    {
                        Value = i,
                        Suit = suits[j]


                    });
                }


            }
        }

        public Card DrawCard2()
        {
            if (Cards.Count > 0)
            {
                Card card = Cards[0];
                Cards.RemoveAt(0);
                return card;
            }
            return null;
        }

        public void ShuffleDeck2()
        {
            for (int i = Cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }

    

        public string ViewCards()
        {
            string output = "";
            foreach (Card card in Cards)
            {
                output += $"{card.Value} of {card.Suit}\n"; //Show Cards  //Add The Value Points To Show Up

            }
            return output.Trim();
        }

        public string ShowCards()
        {
            string output = "";
            foreach (Card card in Cards) // List Loop
            {
                if (card.Value == 1) //A
                {
                    output += $"Ace of {card.Suit} Which is Worth: {card.Cardpoints}\n";
                }

                else if (card.Value == 11) //J
                {
                    output += $"Jack of {card.Suit} Which is Worth: {card.Cardpoints}\n";
                }
                else if (card.Value == 12) //Q
                {
                    output += $"Queen of {card.Suit} Which is Worth: {card.Cardpoints}\n";
                }
                else if (card.Value == 13) //K
                {
                    output += $"King of {card.Suit} Which is Worth: {card.Cardpoints}\n";
                }
                else
                {
                    output += $"{card.Value} of {card.Suit} Which is Worth: {card.Cardpoints}\n"; //Normal Cards
                }
            }
            return output.Trim();
        }
    }
}


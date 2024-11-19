namespace CardGames
{
    public class Player
    {
        public string name = "Gambler";
        public List<Card> Hand { get; private set; } = new List<Card>(); 

        public void AddCard(Card card)
        {
            if (card != null)
            {
                Hand.Add(card); 
            }
        }


        public void RemoveCard()
        {
            
            Hand.Clear();


        }



    }
}

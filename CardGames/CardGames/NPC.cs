namespace CardGames
{
    public class NPC : Player
    {

        public List<Card> Hand { get; set; }


        public NPC()
        {
            Hand = new List<Card>();
        }
    }
}

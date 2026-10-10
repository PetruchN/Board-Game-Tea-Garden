namespace Tea_Garden.Board
{
    public class ActionCardDeck
    {
        public List<ActionCard> Cards { get; set; }
        
        public ActionCardDeck(List<ActionCard> cards)
        {
            Cards = cards;
        }
    }
}

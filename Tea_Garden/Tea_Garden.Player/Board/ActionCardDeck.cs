namespace Tea_Garden.GameEngine
{
    public class ActionCardDeck
    {
        public List<ActionCard> Cards { get; set; }
        
        public ActionCardDeck(List<ActionCard> cards)
        {
            Cards = cards ?? new List<ActionCard>();
        }
    }
}

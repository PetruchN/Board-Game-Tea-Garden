namespace TeaGarden.GameEngine
{
    public class ImperialCardDeck
    {
        public List<ImperialCard> Cards { get; set; }

        public ImperialCardDeck(List<ImperialCard> cards)
        {
            Cards = cards ?? new List<ImperialCard>();
        }
    }
}

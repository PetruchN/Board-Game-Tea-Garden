namespace Tea_Garden.GameEngine
{
    public class CaravanDeck
    {
        public List<Caravan> Cards { get; set; }

        public CaravanDeck(List<Caravan> cards)
        {
            Cards = cards ?? new List<Caravan>();
        }
    }
}

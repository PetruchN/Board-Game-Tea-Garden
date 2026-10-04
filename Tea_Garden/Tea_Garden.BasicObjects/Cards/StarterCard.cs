namespace Tea_Garden.BasicObjects.Cards
{
    public class StarterCard : ICard
    {
        public int Strength { get; }
        public string Id { get; }
        public List<IBonus> Bonuses { get; }
        public StarterCard(int strength, string id, List<IBonus> bonuses)
        {
            Strength = strength;
            Id = id;
            Bonuses = bonuses;
        }
    }
}

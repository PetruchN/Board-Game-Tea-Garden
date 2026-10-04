namespace Tea_Garden.BasicObjects.Cards
{
    public interface ICard
    {
        public int Strength { get; }
        public string Id { get; }
        public List<IBonus> Bonuses { get; }
    }
}
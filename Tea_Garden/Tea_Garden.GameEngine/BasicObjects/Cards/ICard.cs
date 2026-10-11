namespace Tea_Garden.GameEngine
{
    public interface ICard
    {
        public int Strength { get; }
        public string Id { get; }
        public List<IBonus> Bonuses { get; }
    }
}

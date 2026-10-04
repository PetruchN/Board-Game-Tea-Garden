namespace Tea_Garden.BasicObjects.Cards
{
    public class ImperialCard : ICard
    {
        public int Strength { get; }
        public string Id { get; }
        public List<IBonus> Bonuses { get; }
        public string ImperialBonusId { get; }
        public ImperialCard(int strength, string id, List<IBonus> bonuses, string imperialBonusId)
        {
            Strength = strength;
            Id = id;
            Bonuses = bonuses;
            ImperialBonusId = imperialBonusId;
        }
    }
}

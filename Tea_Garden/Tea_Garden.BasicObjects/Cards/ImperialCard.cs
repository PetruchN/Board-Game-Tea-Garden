namespace Tea_Garden.BasicObjects.Cards
{
    public class ImperialCard : ICard
    {
        public int Strength { get; private set; }
        public string Id { get; private set; }
        public List<IBonus> Bonuses { get; private set; }
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

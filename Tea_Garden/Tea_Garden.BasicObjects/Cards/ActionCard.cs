namespace Tea_Garden.BasicObjects.Cards
{
    public class ActionCard : ICard
    {
        public int Strength { get; }
        public string Id { get; }
        public List<IBonus> Bonuses { get ;}
        public int CostTeaLeafAmount { get; }
        public int CostMinimalTeaLeafQuality { get; }
        public List<KettleColor> Kettles { get; }

        public ActionCard(int strength, string id, List<IBonus> bonuses, int costTeaLeafAmount, int costMinimalTeaLeafQuality, List<KettleColor> kettles)
        {
            Strength = strength;
            Id = id;
            Bonuses = bonuses;
            CostTeaLeafAmount = costTeaLeafAmount;
            CostMinimalTeaLeafQuality = costMinimalTeaLeafQuality;
            Kettles = kettles;
        }
    }
}

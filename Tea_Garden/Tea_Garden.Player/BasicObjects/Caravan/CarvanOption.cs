namespace TeaGarden.GameEngine
{
    public class CaravanOption
    {
        public int Level { get; }
        public int TeaLeafAmount { get; }
        public int FermentedTeaLeafAmount { get; }
        public int MinimalStrength { get; }
        public int MaximalStrength { get; }
        public List<IBonus> Bonuses { get; }

        public CaravanOption(int level, int teaLeafAmount, int fermentedTeaLeafAmount, int minimalStrength, int maximalStrength, List<IBonus> bonuses)
        {
            Level = level;
            TeaLeafAmount = teaLeafAmount;
            FermentedTeaLeafAmount = fermentedTeaLeafAmount;
            MinimalStrength = minimalStrength;
            MaximalStrength = maximalStrength;
            Bonuses = bonuses;
        }
    }
}

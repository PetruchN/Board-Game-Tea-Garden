namespace TeaGarden.GameEngine
{
    public class TeaUniversity
    {
        const int NumberOfLevels = 4;
        public Level[] Levels { get; }

        public TeaUniversity(Level[] levels)
        {
            Levels = levels ?? new Level[NumberOfLevels];
        }
    }
    public class Level
    {
        public IBonus[] FirstChoice { get; }
        public IBonus[] SecondChoice { get; }

        public Level(IBonus[] firstChoice, IBonus[] secondChoice)
        {
            FirstChoice = firstChoice ?? new IBonus[0];
            SecondChoice = secondChoice ?? new IBonus[0];
        }
    }
}

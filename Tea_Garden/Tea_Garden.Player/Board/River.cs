namespace Tea_Garden.GameEngine
{
    public class River 
    {
        const int NumberOfLevels = 9;
        public IBonus[][] Levels { get; }

        public River(IBonus[][] levels)
        {
            Levels = levels ?? new IBonus[NumberOfLevels][];
        }
    }
}

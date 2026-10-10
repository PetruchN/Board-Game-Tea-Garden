namespace Tea_Garden.Board
{
    public class TeaUniversity
    {
        public List<Level> Levels { get; }

        public TeaUniversity(List<Level> levels)
        {
            Levels = levels ?? new List<Level>();
        }
    }
    public class Level
    {
        public IBonus[] FirstChoice;
        public IBonus[] SecondChoice;

        public Level(IBonus[] firstChoice, IBonus[] secondChoice)
        {
            FirstChoice = firstChoice ?? new IBonus[0];
            SecondChoice = secondChoice ?? new IBonus[0];
        }
    }
}

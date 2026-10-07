namespace Tea_Garden.Board
{
    public class TeaUniversity
    {
        public Level FirstLevel { get; } = new Level(
            new IBonus[] {}, 
            new IBonus[] {}
            );
        public Level SecondLevel { get; } = new Level(
            new IBonus[] {}, 
            new IBonus[] {}
            );
        public Level ThirdLevel { get; } = new Level(
            new IBonus[] {}, 
            new IBonus[] {}
            );
        public Level FourthLevel { get; } = new Level(
            new IBonus[] {}, 
            new IBonus[] {}
            );
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

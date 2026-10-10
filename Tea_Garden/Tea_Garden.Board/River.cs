namespace Tea_Garden.Board
{
    public class River
    {
        public IBonus[][] Levels { get; }

        public River(IBonus[][] levels)
        {
            Levels = levels;
        }
    }
}

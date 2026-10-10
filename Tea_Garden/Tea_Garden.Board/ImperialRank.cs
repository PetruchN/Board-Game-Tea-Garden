
namespace Tea_Garden.Board
{
    public class ImperialRank
    {
        public IBonus[][] Levels { get; set; }

        public ImperialRank(IBonus[][] levels)
        {
            Levels = levels;
        }
    }
}


namespace TeaGarden.GameEngine
{
    public class ImperialRank
    {
        const int NumberOfLevels = 6;
        public IBonus[][] Levels { get; set; }

        public ImperialRank(IBonus[][] levels)
        {
            Levels = levels ?? new IBonus[NumberOfLevels][];
        }
    }
}
    

namespace TeaGarden.GameEngine
{
    public class RegionBonus
    {
        public string Id { get; }
        public IBonus Bonus { get; }

        public RegionBonus(string id, IBonus bonus)
        {
            Id = id;
            Bonus = bonus;
        }
    }
}

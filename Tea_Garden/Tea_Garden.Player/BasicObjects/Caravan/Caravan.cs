namespace Tea_Garden.GameEngine
{
    public class Caravan
    {
        public List<CaravanOption> Options { get; }
        public string Id { get; }
        public CaravanType Type { get; }

        public Caravan (List<CaravanOption> options, string id, CaravanType type)
        {
            Options = options;
            Id = id;
            Type = type;
        }
    }

    public enum CaravanType
    {
        Basic,
        Advanced
    }
}

using System.Collections.Generic;

namespace TeaGarden.GameEngine
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
}

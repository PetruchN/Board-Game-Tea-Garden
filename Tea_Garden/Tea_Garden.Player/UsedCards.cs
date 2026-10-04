namespace Tea_Garden.Player
{
    public class UsedCards
    {
        public List<List<ICard>> TurnHistory { get; set; } = new List<List<ICard>>();
        public HashSet<KettleColor> AvailableKettleColors { get; set; } = new HashSet<KettleColor>();
    }
}

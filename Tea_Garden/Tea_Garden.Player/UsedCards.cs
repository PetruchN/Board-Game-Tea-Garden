namespace Tea_Garden.Player
{
    public class UsedCards
    {
        public List<List<ICard>> TurnHistory { get; set; } = new List<List<ICard>>();
        public List<KettleColor> AvailableKettleColors { get; set; } = new List<KettleColor>();
    }
}

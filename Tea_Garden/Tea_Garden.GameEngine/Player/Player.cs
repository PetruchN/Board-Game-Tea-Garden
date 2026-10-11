namespace Tea_Garden.GameEngine
{
    public class Player
    {
        public PlayerColor Color { get; }
        public DrawDeck DrawDeck { get; set; }
        public TrashDeck TrashDeck { get; set; }
        public Hand Hand { get; set; }
        public UsedCards UsedCards { get; set; }
        public OwnedTeaLeaves OwnedTeaLeaves { get; set; }
        public AvailableTeaGardens AvailableTeaGardens { get; set; }
        public CompletedCaravans CompletedCaravans { get; set; }
        public OwnedTokens OwnedTokens { get; set; }
        public OwnedCupTiles OwnedCupTiles { get; set; }
        public SecondaryActionsCounter SecondaryActionsCounter { get; set; }
        public WinningPointsCounter WinningPointsCounter { get; set; }

        public Player (PlayerColor color)
        {
            Color = color;
            DrawDeck = new DrawDeck();
            TrashDeck = new TrashDeck();
            Hand = new Hand();
            UsedCards = new UsedCards();
            OwnedTeaLeaves = new OwnedTeaLeaves();
            AvailableTeaGardens = new AvailableTeaGardens();
            CompletedCaravans = new CompletedCaravans();
            OwnedTokens = new OwnedTokens();
            OwnedCupTiles = new OwnedCupTiles();
            SecondaryActionsCounter = new SecondaryActionsCounter();
            WinningPointsCounter = new WinningPointsCounter();
        }
    }

    public enum PlayerColor
    {
        Red,
        Blue,
        Green,
        Yellow
    }
}

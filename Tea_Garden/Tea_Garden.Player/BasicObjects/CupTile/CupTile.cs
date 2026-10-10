namespace TeaGarden.GameEngine
{
    public class CupTile
    {
        public IBonus Bonus { get; }
        public string Id { get; }
        public CupTileColor LeftColor { get; }
        public CupTileColor RightColor { get; }

        public CupTile(string id, IBonus bonus, CupTileColor leftColor, CupTileColor rightColor)
        {
            Id = id;
            Bonus = bonus;
            LeftColor = leftColor;
            RightColor = rightColor;
        }
    }
}

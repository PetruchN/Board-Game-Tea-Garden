namespace Tea_Garden.GameEngine
{
    public class OwnedCupTiles
    {
        public List<CupRow> CupRows { get; set; } = new List<CupRow>();
    }

    public class CupRow
    {
        public List<CupTile> CupTiles { get; set; } = new List<CupTile>();
        public List<Connection> Connections { get; set; } = new List<Connection>();
    }



    public class Connection
    {
        public bool IsSameColor { get; }
        public bool HasCupToken { get; set; }
        public CupTile LeftTile { get; }
        public CupTile RightTile { get; }

        public Connection(CupTile leftTile, CupTile rightTile)
        {
            LeftTile = leftTile;
            RightTile = rightTile;
            IsSameColor = leftTile.RightColor == rightTile.LeftColor; 
        }
    }
}
namespace TeaGarden.GameEngine
{
    public class CupTilesPiles
    {
        const int PileCount = 5;
        public List<CupTile>[] Piles { get; set; }

        public CupTilesPiles()
        {
            Piles = new List<CupTile>[PileCount];
            for (int i = 0; i < PileCount; i++)
            {
                Piles[i] = new List<CupTile>();
            }
        }
    }
}

namespace Tea_Garden.GameEngine
{
    public class TeaGardenRegion
    {
        public int Id { get; }
        public int TeaLeafQuality { get; }
        public int TeaGardensMaxCapacity { get; }
        public TeaGardenRegionColor RegionColor { get; }

        public RegionBonus RegionBonus { get; private set; } = null!;
        public int[] NeighborRegionIds { get; }
        public int?[]? PointsOnBuild { get; }
        public PlayerColor?[] PlacedTeaGardens { get; set; }

        public TeaGardenRegion(int id, int teaLeafQuality, int teaGardensMaxCapacity, TeaGardenRegionColor regionColor, int[] neighborRegionIds, int?[]? pointsOnBuild)
        {
            Id = id;
            TeaLeafQuality = teaLeafQuality;
            TeaGardensMaxCapacity = teaGardensMaxCapacity;
            RegionColor = regionColor;
            NeighborRegionIds = neighborRegionIds;
            PointsOnBuild = pointsOnBuild;
            PlacedTeaGardens = new PlayerColor?[teaGardensMaxCapacity];
        }
    }

    public enum TeaGardenRegionColor
    {
        Starter,
        Red,
        Blue,
        Green,
        Orange
    }
}

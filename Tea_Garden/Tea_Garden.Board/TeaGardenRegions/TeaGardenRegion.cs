

namespace Tea_Garden.Board.TeaGardenRegions
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
        public string?[]? PlacedTeaGardens { get; set; }

        public TeaGardenRegion(int id, int teaLeafQuality, int teaGardensMaxCapacity, TeaGardenRegionColor regionColor, int[] neighborRegionIds, int?[]? pointsOnBuild)
        {
            Id = id;
            TeaLeafQuality = teaLeafQuality;
            TeaGardensMaxCapacity = teaGardensMaxCapacity;
            RegionColor = regionColor;
            NeighborRegionIds = neighborRegionIds;
            PointsOnBuild = pointsOnBuild;
            PlacedTeaGardens = new string?[teaGardensMaxCapacity];
        }
    }
}

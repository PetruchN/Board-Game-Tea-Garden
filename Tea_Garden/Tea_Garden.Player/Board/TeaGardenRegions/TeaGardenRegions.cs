namespace TeaGarden.GameEngine
{
    public class TeaGardenRegions
    {
        public TeaGardenRegion[] Regions { get; } = new TeaGardenRegion[16]
        {
            new TeaGardenRegion(
                id: 1,
                teaLeafQuality: 2,
                teaGardensMaxCapacity: 4,
                regionColor: TeaGardenRegionColor.Starter,
                neighborRegionIds: new int[] { 2, 3, 6, 7 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 2,
                teaLeafQuality: 3,
                teaGardensMaxCapacity: 3,
                regionColor: TeaGardenRegionColor.Green,
                neighborRegionIds: new int[] { 1, 3, 4 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 3,
                teaLeafQuality: 3,
                teaGardensMaxCapacity: 2,
                regionColor: TeaGardenRegionColor.Green,
                neighborRegionIds: new int[] { 1, 2, 4, 5 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 4,
                teaLeafQuality: 4,
                teaGardensMaxCapacity: 3,
                regionColor: TeaGardenRegionColor.Green,
                neighborRegionIds: new int[] { 2, 3, 5, 16 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 5,
                teaLeafQuality: 4,
                teaGardensMaxCapacity: 3,
                regionColor: TeaGardenRegionColor.Green,
                neighborRegionIds: new int[] { 3, 4, 6, 9, 13 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 6,
                teaLeafQuality: 3,
                teaGardensMaxCapacity: 2,
                regionColor: TeaGardenRegionColor.Blue,
                neighborRegionIds: new int[] { 1, 5, 7, 9 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 7,
                teaLeafQuality: 3,
                teaGardensMaxCapacity: 3,
                regionColor: TeaGardenRegionColor.Blue,
                neighborRegionIds: new int[] { 1, 6, 8, 9 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 8,
                teaLeafQuality: 4,
                teaGardensMaxCapacity: 3,
                regionColor: TeaGardenRegionColor.Blue,
                neighborRegionIds: new int[] { 7, 9, 10 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 9,
                teaLeafQuality: 4,
                teaGardensMaxCapacity: 2,
                regionColor: TeaGardenRegionColor.Blue,
                neighborRegionIds: new int[] { 5, 6, 7, 8 , 10 },
                pointsOnBuild: null
            ),
            new TeaGardenRegion(
                id: 10,
                teaLeafQuality: 5,
                teaGardensMaxCapacity: 3,
                regionColor: TeaGardenRegionColor.Orange,
                neighborRegionIds: new int[] { 8, 9, 11, 12, 13 },
                pointsOnBuild: new int?[] { 2, 1 }
            ),
            new TeaGardenRegion(
                id: 11,
                teaLeafQuality: 6,
                teaGardensMaxCapacity: 3,
                regionColor: TeaGardenRegionColor.Orange,
                neighborRegionIds: new int[] { 10, 12 },
                pointsOnBuild: new int?[] { 4, 2 }
            ),
            new TeaGardenRegion(
                id: 12,
                teaLeafQuality: 6,
                teaGardensMaxCapacity: 2,
                regionColor: TeaGardenRegionColor.Orange,
                neighborRegionIds: new int[] { 10, 11, 14 },
                pointsOnBuild: new int?[] { 4, 2 }
            ),
            new TeaGardenRegion(
                id: 13,
                teaLeafQuality: 5,
                teaGardensMaxCapacity: 2,
                regionColor: TeaGardenRegionColor.Red,
                neighborRegionIds: new int[] { 5, 10, 14, 15, 16},
                pointsOnBuild: new int?[] { 2, 1 }
            ),
            new TeaGardenRegion(
                id: 14,
                teaLeafQuality: 6,
                teaGardensMaxCapacity: 2,
                regionColor: TeaGardenRegionColor.Red,
                neighborRegionIds: new int[] { 12 , 13 , 15 },
                pointsOnBuild: new int?[] { 4, 2 }
            ),
            new TeaGardenRegion(
                id: 15,
                teaLeafQuality: 6,
                teaGardensMaxCapacity: 2,
                regionColor: TeaGardenRegionColor.Red,
                neighborRegionIds: new int[] { 13, 14 , 16 },
                pointsOnBuild: new int?[] { 4, 2 }
            ),
            new TeaGardenRegion(
                id: 16,
                teaLeafQuality: 5,
                teaGardensMaxCapacity: 3,
                regionColor: TeaGardenRegionColor.Red,
                neighborRegionIds: new int[] { 4 , 13, 15 },
                pointsOnBuild: new int?[] { 2, 1 }
            )
        };
    }
}

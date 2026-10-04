namespace Tea_Garden.Player
{
    public class OwnedTeaLeaves
    {
        public TeaBox[] Boxes { get; set; } = new TeaBox[6];
    }

    public struct TeaBox
    {
        public int Fresh { get; set; }
        public int Fermented { get; set; }
    }
}

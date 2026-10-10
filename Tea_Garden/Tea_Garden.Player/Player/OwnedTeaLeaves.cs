namespace Tea_Garden.GameEngine
{
    public class OwnedTeaLeaves
    {
        const int NumberOfBoxes = 6;
        public TeaBox[] Boxes { get; set; } = new TeaBox[NumberOfBoxes];
    }

    public class TeaBox
    {
        public int Fresh { get; set; }
        public int Fermented { get; set; }
    }
}

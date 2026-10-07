namespace Tea_Garden.Board
{
    public class River
    {
        public IBonus LevelOne { get; }
        public IBonus[] LevelTwo { get; } = new IBonus[] { };
        public IBonus LevelThree { get; }
        public IBonus LevelFour { get; }
        public IBonus[] LevelFive { get; } = new IBonus[] { };
        public IBonus LevelSix { get; }
        public IBonus[] LevelSeven { get; } = new IBonus[] { };
        public IBonus[] LevelEight { get; } = new IBonus[] { };
        public IBonus[] LevelNine { get; } = new IBonus[] { };
    }
}

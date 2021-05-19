using RPG.Interfaces;

namespace RPG.Classes
{
    public abstract class Knight : ICreature
    {
        public abstract string Name { get; }
        public abstract int Attack { get; }
        public abstract int Defence { get; }
        public abstract double Speed { get; }
        public abstract int HealthPoints { get; }
        public abstract int Mana { get; }
    }
}
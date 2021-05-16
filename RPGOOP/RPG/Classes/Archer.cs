using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_OOP.Interfaces;

namespace RPG_OOP.Classes
{
    public abstract class Archer : ICreature
    {
        public abstract string Name { get; }
        public abstract int Attack { get; }
        public abstract int Defence { get; }
        public abstract double Speed { get; }
        public abstract int HealthPoints { get; }
        public abstract int Mana { get; }
    }
}
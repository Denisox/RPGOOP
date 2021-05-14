using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_OOP.Interfaces;

namespace RPG_OOP.Classes
{
    public abstract class Mage : ICreature
    {
        public abstract string Name { get; set; }
        public abstract int Attack { get; set; }
        public abstract int Defence { get; set; }
        public abstract double Speed { get; set; }
        public abstract int HealthPoints { get; set; }
        public abstract int Mana { get; set; }
    }
}
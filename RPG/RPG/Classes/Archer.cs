using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces;

namespace RPG.Classes
{
    public abstract class Archer : ICreatures
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Attack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Defence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double HealthPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Mana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

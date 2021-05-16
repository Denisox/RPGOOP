using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_OOP.Interfaces
{
    public interface ICreature
    {
        string Name { get; }
        int Attack { get; }
        int Defence { get; }
        double Speed { get; }
        int HealthPoints { get; }
        int Mana { get; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_OOP.Interfaces
{
    public interface ICreature
    {
        string Name { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }
        double Speed { get; set; }
        int HealthPoints { get; set; }
        int Mana { get; set; }
    }
}
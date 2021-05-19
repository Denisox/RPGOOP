using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces
{
    public interface ICharacters
    {
        string Name { get; set; }
        int Attack { get; }
        int Defence { get; }
        double Speed { get; }
        int HealthPoints { get; }
        int Mana { get; }
        int CurrentHealthPoints { get; set; }
        int CurrentMana { get; set; }

        string AsAString();
    }
}
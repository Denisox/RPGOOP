using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces
{
    interface ICreatures
    {
        string Name { get; set; }
        double Attack { get; set; }
        double Defence { get; set; }
        double Speed { get; set; }
        double HealthPoints { get; set; }
        double Mana { get; set; }
       
    }
}

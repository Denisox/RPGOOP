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

        int IncomingDamage { get; set; }
        int OutgoingDamage { get; set; }

        bool HasShield { get; set; }
        bool HasBuff { get; set; }

        void HealCharacter(ICharacters character);
        void NormalAttack(ICreature newCreature);
        void PowerAttack(ICreature newCreature);
        void GetBuff();
        void GetShield();
        void GetDamage();
        string AsAString();
    }
}
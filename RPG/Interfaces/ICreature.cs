using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces
{
    public interface ICreature
    {
        string Name { get; }
        int Attack { get; }
        int Defence { get; }
        double Speed { get; }
        int HealthPoints { get; }
        int Mana { get; }
        int CurrentHealthPoints { get; set; }
        int IncomingDamage { get; set; }
        int OutgoingDamage { get; set; }

        bool HasShield { get; set; }
        bool HasBuff { get; set; }
        void Heal();
        void GetBuff();
        void GetShield();
        void GetDamage();

        void AttackCharacter(ICharacters newCharacter);

    }
}
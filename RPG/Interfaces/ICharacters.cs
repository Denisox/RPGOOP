using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Items;

namespace RPG.Interfaces
{
    public interface ICharacters
    {
        string Name { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }
        double Speed { get; set; }
        int HealthPoints { get; set; }
        int Mana { get; set; }
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

        string Status();
    }
}
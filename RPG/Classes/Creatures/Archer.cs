using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces;

namespace RPG.Classes
{
    public abstract class Archer : ICreature
    {
        public abstract string Name { get; }
        public abstract int Attack { get; }
        public abstract int Defence { get; }
        public abstract double Speed { get; }
        public abstract int HealthPoints { get; }
        public abstract int Mana { get; }
        public abstract int CurrentHealthPoints { get; set; }

        public abstract int IncomingDamage { get; set; }
        public abstract int OutgoingDamage { get; set; }

        public abstract bool HasShield { get; set; }
        public abstract bool HasBuff { get; set; }

        public virtual void Heal()
        {
            Console.WriteLine("The Creature used Heal!");
            if (Convert.ToInt32(this.CurrentHealthPoints + this.HealthPoints * 0.20) > this.HealthPoints)
            {
                this.CurrentHealthPoints = this.HealthPoints;
            }
            else
            {
                this.CurrentHealthPoints = Convert.ToInt32(0.20 * this.HealthPoints + this.CurrentHealthPoints);
            }
        }

        public virtual void GetBuff()
        {
            Console.WriteLine("The Creature used Buff!");
            if (this.HasBuff == false)
            {
                this.HasBuff = true;
            }
            else
            {
                Console.WriteLine("Can't get a new Buff!");
            }
        }

        public virtual void GetShield()
        {
            Console.WriteLine("The Creature used Shield!");
            if (this.HasShield == false)
            {
                this.HasShield = true;
            }
            else
            {
                Console.WriteLine("Can't get a new Shield!");
            }
        }

        public virtual void AttackCharacter(ICharacters newCharacter)
        {
            Console.WriteLine("The Creature used Attack!");
            if (this.HasShield == false)
            {
                this.OutgoingDamage = Convert.ToInt32(1.3 * this.Attack);
            }
            else
            {
                this.OutgoingDamage = Convert.ToInt32(1.5 * 1.3 * this.Attack);
            }
            newCharacter.IncomingDamage = this.OutgoingDamage;
        }

        public virtual void GetDamage()
        {
            int dealtDamage = Convert.ToInt32(this.IncomingDamage - 0.8 * this.Defence);
            if (dealtDamage < 2)
            {
                dealtDamage = 2;
            }
            if (HasBuff == false)
            {
                this.CurrentHealthPoints = this.CurrentHealthPoints - dealtDamage;
            }
            else
            {
                dealtDamage = Convert.ToInt32(0.5 * dealtDamage);
                this.CurrentHealthPoints = this.CurrentHealthPoints - dealtDamage;
            }
            if (CurrentHealthPoints < 0)
            {
                CurrentHealthPoints = 0;
            }
        }

        public string Status()
        {
            return "\nMob Stats" + "\nHealth: " + this.CurrentHealthPoints + "\nMana: " + this.Mana + "\nAttack: " + this.Attack + "\nDefence: " + this.Defence + "\nSpeed: " + this.Speed + "\n";
        }
    }
}
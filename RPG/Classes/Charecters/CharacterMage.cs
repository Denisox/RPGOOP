using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces;

namespace RPG.CharacterClasses
{
    public abstract class CharacterMage : ICharacters

    {
        public abstract int HealthPoints { get; set; }
        public abstract int Attack { get; set; }
        public abstract int Defence { get; set; }
        public abstract double Speed { get; set; }
        public abstract int Mana { get; set; }
        public abstract string Name { get; set; }
        public abstract int CurrentHealthPoints { get; set; }
        public abstract int CurrentMana { get; set; }
        public abstract int IncomingDamage { get; set; }
        public abstract int OutgoingDamage { get; set; }

        public abstract bool HasShield { get; set; }
        public abstract bool HasBuff { get; set; }

        public virtual void HealCharacter(ICharacters character)
        {
            if (character.CurrentMana >= 25)
            {
                if (Convert.ToInt32(character.CurrentHealthPoints + character.HealthPoints * 0.3) > character.HealthPoints)
                {
                    character.CurrentHealthPoints = character.HealthPoints;
                    CurrentMana -= 25;
                }
                else
                {
                    character.CurrentHealthPoints = Convert.ToInt32(0.3 * character.HealthPoints + character.CurrentHealthPoints);
                    CurrentMana -= 25;
                }
            }
            else
            {
                Console.WriteLine("Not enough mana!");
            }
        }

        public virtual void NormalAttack(ICreature newCreature)
        {
            if (this.HasBuff == false)
            {
                this.OutgoingDamage = Convert.ToInt32(1.15 * this.Attack);
            }
            else
            {
                this.OutgoingDamage = Convert.ToInt32(1.5 * 1.15 * this.Attack);
            }
            newCreature.IncomingDamage = this.OutgoingDamage;
        }

        public virtual void PowerAttack(ICreature newCreature)
        {
            Random newRandom = new Random();
            if (newRandom.Next(100) < 80)
            {
                if (this.CurrentMana >= 35)
                {
                    if (this.HasBuff == false)
                    {
                        this.OutgoingDamage = Convert.ToInt32(2 * this.Attack);
                    }
                    else
                    {
                        this.OutgoingDamage = Convert.ToInt32(1.5 * 2 * this.Attack);
                    }
                    CurrentMana -= 35;
                    newCreature.IncomingDamage = this.OutgoingDamage;
                }
                else
                {
                    Console.WriteLine("Power Attack failed. Not enough mana");
                }
            }
            else
            {
                Console.WriteLine("Power Attack could not get executed!");
            }
        }

        public virtual void GetBuff()
        {
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
            if (this.HasShield == false)
            {
                this.HasShield = true;
            }
            else
            {
                Console.WriteLine("Can't get a new Shield!");
            }
        }

        public virtual void GetDamage()
        {
            int dealtDamage = Convert.ToInt32(this.IncomingDamage - 0.8 * this.Defence);
            if (dealtDamage < 2)
            {
                dealtDamage = 2;
            }
            if (HasShield == false)
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

        public string AsAString()
        {
            throw new NotImplementedException();
        }

        public string Status()
        {
            return "\nCharecter Stats" + "\nHealth: " + this.CurrentHealthPoints + "\nMana: " + this.Mana + "\nAttack: " + this.Attack + "\nDefence: " + this.Defence + "\nSpeed: " + this.Speed + "\n";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces;

namespace RPG.CharacterClasses
{
    public abstract class CharacterKnight : ICharacters
    {
        public abstract int HealthPoints { get; }
        public abstract int Attack { get; }
        public abstract int Defence { get; }
        public abstract double Speed { get; }
        public abstract int Mana { get; }
        public abstract string Name { get; set; }
        public abstract int CurrentHealthPoints { get; set; }
        public abstract int CurrentMana { get; set; }

        public abstract int IncomingDamage { get; set; }
        public abstract int OutgoingDamage { get; set; }

        public abstract bool HasShield { get; set; }
        public abstract bool HasBuff { get; set; }
        public virtual void HealCharacter(ICharacters character)
        {
            if (character.CurrentMana >= 15)
            {
                if (Convert.ToInt32(character.CurrentHealthPoints + character.HealthPoints * 0.2) > character.HealthPoints)
                {
                    character.CurrentHealthPoints = character.HealthPoints;
                    CurrentMana -= 15;
                }

                else
                {
                    character.CurrentHealthPoints = Convert.ToInt32(0.2 * character.HealthPoints + character.CurrentHealthPoints);
                    CurrentMana -= 15;
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
                this.OutgoingDamage = Convert.ToInt32(1.25 * this.Attack);
            }

            else
            {
                this.OutgoingDamage = Convert.ToInt32(1.4 * 1.25 * this.Attack);
            }
            newCreature.IncomingDamage = this.OutgoingDamage;
        }

        public virtual void PowerAttack(ICreature newCreature)
        {

            Random newRandom = new Random();
            if (newRandom.Next(100) < 85)
            {
                if (this.CurrentMana >= 20)
                {
                    if (this.HasBuff == false)
                    {
                        this.OutgoingDamage = Convert.ToInt32(2 * this.Attack);
                    }

                    else
                    {
                        this.OutgoingDamage = Convert.ToInt32(1.4 * 2 * this.Attack);
                    }
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
            return "\nYou have " + this.CurrentHealthPoints + " Health and " + this.CurrentMana + " Mana\nYour Attack is " + this.Attack + " and your Defense is " + this.Defence + ". Speed is" + this.Speed + "\n";
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces;

namespace RPG.CharacterClasses
{
    public abstract class CharacterArcher : ICharacters
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
            if (character.CurrentMana >= 20)
            {
                if (character.CurrentHealthPoints + character.HealthPoints * 0.25 > character.HealthPoints)
                {
                    character.CurrentHealthPoints = character.HealthPoints;
                    CurrentMana -= 20;
                }

                else
                {
                    character.CurrentHealthPoints = Convert.ToInt32(0.25 * character.HealthPoints + character.CurrentHealthPoints);
                    CurrentMana -= 20;
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
                this.OutgoingDamage = Convert.ToInt32(1.2 * this.Attack);
            }

            else
            {
                this.OutgoingDamage = Convert.ToInt32(1.5 * 1.2 * this.Attack);
            }
            newCreature.IncomingDamage = this.IncomingDamage;
        }
        public string AsAString()
        {
            throw new NotImplementedException();
        }
    }
}
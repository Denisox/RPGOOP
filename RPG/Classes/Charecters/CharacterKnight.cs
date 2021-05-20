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
        public virtual void HealCharacter(ICharacters character)
        {
            if (character.CurrentMana >= 15)
            {
                if (character.CurrentHealthPoints + character.HealthPoints * 0.2 > character.HealthPoints)
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

        public string AsAString()
        {
            throw new NotImplementedException();
        }
    }
}
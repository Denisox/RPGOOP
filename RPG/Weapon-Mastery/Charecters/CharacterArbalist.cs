using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;
using RPG.Interfaces;

namespace RPG.CharacterClasses.Weapon_Mastery
{
    public class CharacterArbalist : CharacterArcher, ICharacters, IDisposable
    {
        private string name;

        public override string Name
        {
            get => name;
            set => name = value;
        }

        private int attack;

        public override int Attack
        {
            get => attack;
        }

        private int defence;

        public override int Defence
        {
            get => defence;
        }

        private double speed;

        public override double Speed
        {
            get => speed;
        }

        private int healthPoints;

        public override int HealthPoints
        {
            get => healthPoints;
        }

        private int mana;

        public override int Mana
        {
            get => mana;
        }

        public CharacterArbalist(string name, int attack, int defence, double speed, int hp, int mana)
        {
            this.name = name;
            this.attack = attack;
            this.defence = defence;
            this.speed = speed;
            this.healthPoints = hp;
            this.mana = mana;
        }

        public string AsAString()
        {
            return "\nClass: Crossbow;\nAttack: " + this.attack + "\nDefence: " + this.defence + "\nSpeed: " + this.speed + "\nHP: " + this.healthPoints + "\nMana: " + this.mana;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
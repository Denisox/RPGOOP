using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;
using RPG.Interfaces;

namespace RPG.CharacterClasses.Weapon_Mastery
{
    public class CharacterTwoHandedSwordsman : CharacterKnight, ICharacters
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
            set => attack = value;
        }

        private int defence;

        public override int Defence
        {
            get => defence;
            set => defence = value;
        }

        private double speed;

        public override double Speed
        {
            get => speed;
            set => speed = value;
        }

        private int healthPoints;

        public override int HealthPoints
        {
            get => healthPoints;
            set => healthPoints = value;
        }

        private int mana;

        public override int Mana
        {
            get => mana;
            set => mana = value;
        }

        private int currentHealthPoints;

        public override int CurrentHealthPoints
        {
            get => currentHealthPoints;
            set => currentHealthPoints = value;
        }

        private int currentMana;

        public override int CurrentMana
        {
            get => currentMana;
            set => currentMana = value;
        }

        public override string WeaponType { get; set; }

        public CharacterTwoHandedSwordsman(string name, int attack, int defence, double speed, int hp, int mana)
        {
            this.name = name;
            this.attack = attack;
            this.defence = defence;
            this.speed = speed;
            this.healthPoints = hp;
            this.mana = mana;
            this.currentHealthPoints = this.healthPoints;
            this.currentMana = this.mana;
        }

        private bool hasBuff = false;

        public override bool HasBuff
        {
            get => hasBuff;
            set => hasBuff = value;
        }

        private bool hasShield = false;

        public override bool HasShield
        {
            get => hasShield;
            set => hasShield = value;
        }

        private int incomingDamage = 0;

        public override int IncomingDamage
        {
            get => incomingDamage;
            set => incomingDamage = value;
        }

        private int outgoingDamage = 0;

        public override int OutgoingDamage
        {
            get => outgoingDamage;
            set => outgoingDamage = value;
        }

        public new string AsAString()
        {
            return "\nClass: Two-Hand Swordsman;\nAttack: " + this.attack + "\nDefence: " + this.defence + "\nSpeed: " + this.speed + "\nHP: " + this.healthPoints + "\nMana: " + this.mana;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes;

namespace RPG.Weapon_Mastery
{
    public class Bowman : Archer
    {
        private string name;

        public override string Name
        {
            get => name;
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
        private int currentHealthPoints;
        public override int CurrentHealthPoints
        {
            get => currentHealthPoints;
            set => currentHealthPoints = value;
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

        public Bowman(string name, int attack, int defence, double speed, int hp, int mana)
        {
            this.name = name;
            this.attack = attack;
            this.defence = defence;
            this.speed = speed;
            this.healthPoints = hp;
            this.mana = mana;
            this.currentHealthPoints = this.healthPoints;
        }
    }
}
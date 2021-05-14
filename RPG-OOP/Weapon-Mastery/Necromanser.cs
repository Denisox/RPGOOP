using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_OOP.Classes;

namespace RPG_OOP.Weapon_Mastery
{
    public class Necromanser : Mage
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

        public Necromanser(string name, int attack, int defence, double speed, int hp, int mana)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defence = defence;
            this.Speed = speed;
            this.HealthPoints = hp;
            this.Mana = mana;
        }
    }
}
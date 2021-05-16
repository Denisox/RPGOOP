using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    public class Item
    {
        private string name;
        private string type;
        private int hpAdd;
        private int manaAdd;
        private double speedAdd;
        private int attackAdd;
        private int defenceAdd;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public int HpAdd
        {
            get
            {
                return hpAdd;
            }
        }

        public int ManaAdd
        {
            get
            {
                return manaAdd;
            }
        }

        public double SpeedAdd
        {
            get
            {
                return speedAdd;
            }
        }

        public double AttackAdd
        {
            get
            {
                return attackAdd;
            }
        }

        public double DefenceAdd
        {
            get
            {
                return defenceAdd;
            }
        }

        public Item(string name, string type, int hpAdd, int manaAdd, double speedAdd, int attackAdd, int defenceAdd)
        {
            this.name = name;
            this.type = type;
            this.hpAdd = hpAdd;
            this.manaAdd = manaAdd;
            this.speedAdd = speedAdd;
            this.attackAdd = attackAdd;
            this.defenceAdd = defenceAdd;
        }
    }
}
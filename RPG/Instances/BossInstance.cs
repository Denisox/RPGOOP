using System;
using System.Collections.Generic;
using RPG.Interfaces;
using RPG.Weapon_Mastery;

namespace RPG
{
    public class BossInstance
    {
        public List<ICreature> tier1Boss = new List<ICreature>(7)
        {
                new Arbalist("Polygon", Convert.ToInt32(13 * 1.5), Convert.ToInt32(8 * 1.5), 1.1, Convert.ToInt32(110 * 1.5), Convert.ToInt32(30 * 1.5)),
                new Bowman("Green Arrow", Convert.ToInt32(12 * 1.5), Convert.ToInt32(7 * 1.5), 1.3, Convert.ToInt32(110 * 1.5), Convert.ToInt32(30 * 1.5)),
                new OneHandedSwordsman("Arabor", Convert.ToInt32(10 * 1.5), Convert.ToInt32(15 * 1.5), 1.25, Convert.ToInt32(150 * 1.5), Convert.ToInt32(30 * 1.5)),
                new TwoHandedSwordsman("Dark King", Convert.ToInt32(15 * 1.5), Convert.ToInt32(5 * 1.5), 1.15, Convert.ToInt32(170 * 1.5), Convert.ToInt32(30 * 1.5)),
                new Spearman("Shin-Zao", Convert.ToInt32(12 * 1.5), Convert.ToInt32(10 * 1.5), 1.30, Convert.ToInt32(150 * 1.5), Convert.ToInt32(0 * 1.5)),
                new Pyromancer("Lulilium", Convert.ToInt32(10 * 1.5), Convert.ToInt32(8 * 1.5), 1, Convert.ToInt32(120 * 1.5), Convert.ToInt32(150 * 1.5)),
                new Necromancer("Darquesse", Convert.ToInt32(8 * 1.5), Convert.ToInt32(8 * 1.5), 1, Convert.ToInt32(90 * 1.5), Convert.ToInt32(200 * 1.5))
        };

        public List<ICreature> tier2Boss = new List<ICreature>(7)
        {
                new Arbalist("Vipertron", Convert.ToInt32(13 * 2.5), Convert.ToInt32(8 * 2.5), 1.1, Convert.ToInt32(110 * 2.5), Convert.ToInt32(30 * 2.5)),
                new Bowman("Raftel", Convert.ToInt32(12 * 2.5), Convert.ToInt32(7 * 2.5), 1.3, Convert.ToInt32(110 * 2.5), Convert.ToInt32(30 * 2.5)),
                new OneHandedSwordsman("Kobalion", Convert.ToInt32(10 * 2.5), Convert.ToInt32(15 * 2.5), 1.25, Convert.ToInt32(150 * 2.5), Convert.ToInt32(30 * 2.5)),
                new TwoHandedSwordsman("Tornadus", Convert.ToInt32(15 * 2.5), Convert.ToInt32(5 * 2.5), 1.15, Convert.ToInt32(170 * 2.5), Convert.ToInt32(30 * 2.5)),
                new Spearman("The Wasp", Convert.ToInt32(12 * 2.5), Convert.ToInt32(10 * 2.5), 1.30, Convert.ToInt32(150 * 2.5), Convert.ToInt32(0 * 2.5)),
                new Pyromancer("Hellfire", Convert.ToInt32(10 * 2.5), Convert.ToInt32(8 * 2.5), 1, Convert.ToInt32(120 * 2.5), Convert.ToInt32(150 * 2.5)),
                new Necromancer("The Archivist", Convert.ToInt32(8 * 2.5), Convert.ToInt32(8 * 2.5), 1, Convert.ToInt32(90 * 2.5), Convert.ToInt32(200 * 2.5))
        };

        public List<ICreature> tier3Boss = new List<ICreature>(7)
        {
                new Arbalist("Arcus The Great", Convert.ToInt32(13 * 3.5), Convert.ToInt32(8 * 3.5), 1.1, Convert.ToInt32(110 * 3.5), Convert.ToInt32(30 * 3.5)),
                new Bowman("Razorwind", Convert.ToInt32(12 * 3.5), Convert.ToInt32(7 * 3.5), 1.3, Convert.ToInt32(110 * 3.5), Convert.ToInt32(30 * 3.5)),
                new OneHandedSwordsman(" Executioner of Denial", Convert.ToInt32(10 * 3.5), Convert.ToInt32(15 * 3.5), 1.25, Convert.ToInt32(150 * 3.5), Convert.ToInt32(30 * 3.5)),
                new TwoHandedSwordsman("Ragnarok", Convert.ToInt32(15 * 3.5), Convert.ToInt32(5 * 3.5), 1.15, Convert.ToInt32(170 * 3.5), Convert.ToInt32(30 * 3.5)),
                new Spearman("Bone Piercer", Convert.ToInt32(12 * 3.5), Convert.ToInt32(10 * 3.5), 1.30, Convert.ToInt32(150 * 3.5), Convert.ToInt32(0 * 3.5)),
                new Pyromancer("Meteor Strike", Convert.ToInt32(10 * 3.5), Convert.ToInt32(8 * 3.5), 1, Convert.ToInt32(120 * 3.5), Convert.ToInt32(150 * 3.5)),
                new Necromancer("Malistaire", Convert.ToInt32(8 * 3.5), Convert.ToInt32(8 * 3.5), 1, Convert.ToInt32(90 * 3.5), Convert.ToInt32(200 * 3.5))
        };
    }
}
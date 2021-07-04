using System.Collections.Generic;
using RPG.Interfaces;
using RPG.Weapon_Mastery;

namespace RPG.Instances
{
    public class MobsInstance
    {
        // Mobs List Tier 1
        public List<ICreature> tier1Creatures = new List<ICreature>(7)
            {
                new Arbalist("tier1 Arbalist", 13, 8, 1.1, 110, 30),
                new Bowman("tier1 Bowman", 12, 7, 1.3, 110, 30),
                new OneHandedSwordsman("tier1 One-Handed Swordsman", 10, 15, 1.25, 150, 30),
                new TwoHandedSwordsman("tier1 Two-Handed Swordsman", 15, 5, 1.15, 170, 30),
                new Spearman("tier1 Spearman", 12, 10, 1.30, 150, 0),
                new Pyromancer("tier1 Pyromancer", 10, 8, 1, 120, 150),
                new Necromancer("tier1 Necromancer", 8, 8, 1, 90, 200)
            };

        // Mobs List Tier 2
        public List<ICreature> tier2Creatures = new List<ICreature>(7)
            {
                new Arbalist("tier2 Arbalist", 20, 14, 1.10, 220, 50),
                new Bowman("tier2 Bowman", 17, 14, 1.30, 230, 50),
                new OneHandedSwordsman("tier2 One-Handed Swordsman", 20, 20, 1.25, 200, 60),
                new TwoHandedSwordsman("tier2 Two-Handed Swordsman", 20, 13, 1.15, 260, 60),
                new Spearman("tier2 Spearman", 18, 15, 1.30, 250, 0),
                new Pyromancer("tier2 Pyromancer", 15, 18, 1.25, 240, 250),
                new Necromancer("tier2 Necromancer", 15, 16, 1.25, 240, 250)
            };

        // Mobs List Tier 3
        public List<ICreature> tier3Creatures = new List<ICreature>(7)
            {
                new Arbalist("tier3 Arbalist", 26, 14, 1.10, 220, 30),
                new Bowman("tier3 Bowman", 23, 20, 1.30, 280, 100),
                new OneHandedSwordsman("tier3 One-Handed Swordsman", 25, 25, 1.25, 320, 80),
                new TwoHandedSwordsman("tier3 Two-Handed Swordsman", 27, 25, 1.15, 300, 80),
                new Spearman("tier3 Spearman", 23, 20, 1.30, 300, 0),
                new Pyromancer("tier3 Pyromancer", 18, 23, 1.30, 300, 400),
                new Necromancer("tier3 Necromancer", 20, 20, 1.40, 300, 400)
            };
    }
}
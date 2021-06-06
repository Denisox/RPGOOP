using System.Collections.Generic;
using RPG.Items;
using RPG.Interfaces;
using RPG.Weapon_Mastery;

namespace RPG
{
    public class ItemsInstance
    {
        public List<Item> weaponsTier1 = new List<Item>()
            {
                new Item("Galvanic Staff", "Mage", 0, 0, 0.1, 4, 0),
                new Item("Cerulean Edge", "OHS", 0, 0, 0.2, 2, 0),
                new Item("Spear of Regeneration", "Spear", 0, 0, 0.2, 4, 0),
                new Item("Shield of Valor", "OHS", 0, 0, 0, 1, 3),
                new Item("Destructive Blade", "THS", 0, 0, 0.1, 4, 0),
                new Item("Crimson Bow", "Bow", 0, 0, 0.2, 3, 0),
                new Item("Azure Crossbow of Destruction", "Crossbow", 0, 0, 0.3, 2, 0)
            };

        public List<Item> weaponsTier2 = new List<Item>()
            {
                new Item("Icy Staff", "Mage", 0, 0, 0.2, 5, 0),
                new Item("Sword of Dignity", "OHS", 0, 0, 0.3, 3, 0),
                new Item("Spear of Wolf's Vengance", "Spear", 0, 0, 0.3, 5, 0),
                new Item("Shield of Infinity", "OHS", 0, 0, 0, 1, 4),
                new Item("Serpent Blade", "THS", 0, 0, 0.15, 5, 0),
                new Item("Purple Bow of Nobility", "Bow", 0, 0, 0.25, 4, 0),
                new Item("Crossbow of Eternity", "Crossbow", 0, 0, 0.35, 3, 0)
            };

        public List<Item> weaponsTier3 = new List<Item>()
            {
                new Item("Mage Staff of Isolation", "Mage", 0, 0, 0.3, 7, 0),
                new Item("Black Destroyer", "OHS", 0, 0, 0.3, 5, 0),
                new Item("Spear of Witch's Wrath", "Spear", 0, 0, 0.35, 6, 0),
                new Item("Shield of Brutality", "OHS", 0, 0, 0, 1, 6),
                new Item("Blade of the Undefeated", "THS", 0, 0, 0.2, 7, 0),
                new Item("The Bow", "Bow", 0, 0, 0.3, 5, 0),
                new Item("Mega V", "Crossbow", 0, 0, 0.4, 4, 0)
            };

        public List<Item> armorTier1 = new List<Item>()
            {
                new Item("Evergreen Armor", "all", 20, 5, 0, 0, 4),
                new Item("Mantle of Destruction", "all", 12, 5, 0.3, 0, 3),
                new Item("Shell of the Undying", "all", 30, 5, 0, 0, 1)
            };

        public List<Item> armorTier2 = new List<Item>()
            {
                new Item("Oceanic Gear", "all", 30, 8, 0, 0, 8),
                new Item("Robe of Power", "all", 18, 8, 0.5, 0, 6),
                new Item("Heavy Fortress", "all", 45, 8, 0, 0, 2)
            };

        public List<Item> armorTier3 = new List<Item>()
            {
                new Item("Borealis Shirt if Shivers", "all", 60, 16, 0, 0, 20),
                new Item("Gear of the Unstopable", "all", 36, 16, 0.7, 0, 15),
                new Item("Life God's Robe", "all", 90, 16, 0, 0, 5)
            };

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
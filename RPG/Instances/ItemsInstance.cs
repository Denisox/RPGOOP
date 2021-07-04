using System.Collections.Generic;
using RPG.Items;
using RPG.Interfaces;
using RPG.Weapon_Mastery;

namespace RPG
{
    public class ItemsInstance
    {
        // Weapons List Tier 1
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

        // Weapons List Tier 2
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

        // Weapons List Tier 3
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

        // Armors List Tier 1
        public List<Item> armorTier1 = new List<Item>()
            {
                new Item("Evergreen Armor", "all", 20, 5, 0, 0, 4),
                new Item("Mantle of Destruction", "all", 12, 5, 0.3, 0, 3),
                new Item("Shell of the Undying", "all", 30, 5, 0, 0, 1)
            };

        // Armors List Tier 2
        public List<Item> armorTier2 = new List<Item>()
            {
                new Item("Oceanic Gear", "all", 30, 8, 0, 0, 8),
                new Item("Robe of Power", "all", 18, 8, 0.5, 0, 6),
                new Item("Heavy Fortress", "all", 45, 8, 0, 0, 2)
            };

        // Armors List Tier 3
        public List<Item> armorTier3 = new List<Item>()
            {
                new Item("Borealis Shirt if Shivers", "all", 60, 16, 0, 0, 20),
                new Item("Gear of the Unstopable", "all", 36, 16, 0.7, 0, 15),
                new Item("Life God's Robe", "all", 90, 16, 0, 0, 5)
            };
    }
}
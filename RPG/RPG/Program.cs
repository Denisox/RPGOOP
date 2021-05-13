﻿using System;
using RPG.Items;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Item staff1 = new Item("Galvanic Staff", "Mage", 0, 0, 0.1, 4, 0);
            Item sword1 = new Item("Cerulean Edge", "OHS", 0, 0, 0.2, 2, 0);
            Item spear1 = new Item("Spear of Regeneration", "Spear", 0, 0, 0.2, 4, 0);
            Item shield1 = new Item("Shield of Valor", "OHS", 0, 0, 0, 1, 3);
            Item blade1 = new Item("Destructive Blade", "THS", 0, 0, 0.1, 4, 0);
            Item bow1 = new Item("Crimson Bow", "bow", 0, 0, 0.2, 3, 0);
            Item crossbow1 = new Item("Azure Crossbow of Destruction", "crossbow", 0, 0, 0.3, 2, 0);
            List<Item> weaponsTier1 = new List<Item>()
            {
                staff1,
                sword1,
                spear1,
                shield1,
                blade1,
                bow1,
                crossbow1
            };

            Item staff2 = new Item("Icy Staff", "Mage", 0, 0, 0.2, 5, 0);
            Item sword2 = new Item("Sword of Dignity", "OHS", 0, 0, 0.3, 3, 0);
            Item spear2 = new Item("Spear of Wolf's Vengance", "Spear", 0, 0, 0.3, 5, 0);
            Item shield2 = new Item("Shield of Infinity", "OHS", 0, 0, 0, 1, 4);
            Item blade2 = new Item("Serpent Blade", "THS", 0, 0, 0.15, 5, 0);
            Item bow2 = new Item("Purple Bow of Nobility", "bow", 0, 0, 0.25, 4, 0);
            Item crossbow2 = new Item("Crossbow of Eternity", "crossbow", 0, 0, 0.35, 3, 0);
            List<Item> weaponsTier2 = new List<Item>()
            {
                staff2,
                sword2,
                spear2,
                shield2,
                blade2,
                bow2,
                crossbow2
            };

            Item staff3 = new Item("Mage Staff of Isolation", "Mage", 0, 0, 0.3, 7, 0);
            Item sword3 = new Item("Black Destroyer", "OHS", 0, 0, 0.3, 5, 0);
            Item spear3 = new Item("Spear of Witch's Wrath", "Spear", 0, 0, 0.35, 6, 0);
            Item shield3 = new Item("Shield of Brutality", "OHS", 0, 0, 0, 1, 6);
            Item blade3 = new Item("Blade of the Undefeated", "THS", 0, 0, 0.2, 7, 0);
            Item bow3 = new Item("The Bow", "bow", 0, 0, 0.3, 5, 0);
            Item crossbow3 = new Item("Mega V", "crossbow", 0, 0, 0.4, 4, 0);
            List<Item> weaponsTier3 = new List<Item>()
            {
                staff3,
                sword3,
                spear3,
                shield3,
                blade3,
                bow3,
                crossbow3
            };

        }
    }
}

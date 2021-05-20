﻿using System;
using System.Collections.Generic;
using RPG.Items;
using RPG.Interfaces;
using RPG.Weapon_Mastery;
using RPG.CharacterClasses.Weapon_Mastery;
using RPG.CharacterClasses;
using RPG.Classes;

namespace RPG
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Item> weaponsTier1 = new List<Item>()
            {
                new Item("Galvanic Staff", "Mage", 0, 0, 0.1, 4, 0),
                new Item("Cerulean Edge", "OHS", 0, 0, 0.2, 2, 0),
                new Item("Spear of Regeneration", "Spear", 0, 0, 0.2, 4, 0),
                new Item("Shield of Valor", "OHS", 0, 0, 0, 1, 3),
                new Item("Destructive Blade", "THS", 0, 0, 0.1, 4, 0),
                new Item("Crimson Bow", "bow", 0, 0, 0.2, 3, 0),
                new Item("Azure Crossbow of Destruction", "crossbow", 0, 0, 0.3, 2, 0)
            };

            List<Item> weaponsTier2 = new List<Item>()
            {
                new Item("Icy Staff", "Mage", 0, 0, 0.2, 5, 0),
                new Item("Sword of Dignity", "OHS", 0, 0, 0.3, 3, 0),
                new Item("Spear of Wolf's Vengance", "Spear", 0, 0, 0.3, 5, 0),
                new Item("Shield of Infinity", "OHS", 0, 0, 0, 1, 4),
                new Item("Serpent Blade", "THS", 0, 0, 0.15, 5, 0),
                new Item("Purple Bow of Nobility", "bow", 0, 0, 0.25, 4, 0),
                new Item("Crossbow of Eternity", "crossbow", 0, 0, 0.35, 3, 0)
            };

            List<Item> weaponsTier3 = new List<Item>()
            {
                new Item("Mage Staff of Isolation", "Mage", 0, 0, 0.3, 7, 0),
                new Item("Black Destroyer", "OHS", 0, 0, 0.3, 5, 0),
                new Item("Spear of Witch's Wrath", "Spear", 0, 0, 0.35, 6, 0),
                new Item("Shield of Brutality", "OHS", 0, 0, 0, 1, 6),
                new Item("Blade of the Undefeated", "THS", 0, 0, 0.2, 7, 0),
                new Item("The Bow", "bow", 0, 0, 0.3, 5, 0),
                new Item("Mega V", "crossbow", 0, 0, 0.4, 4, 0)
            };

            List<Item> armorTier1 = new List<Item>()
            {
                new Item("Evergreen Armor", "all", 20, 5, 0, 0, 4),
                new Item("Mantle of Destruction", "all", 12, 5, 0.3, 0, 3),
                new Item("Shell of the Undying", "all", 30, 5, 0, 0, 1)
            };

            List<Item> armorTier2 = new List<Item>()
            {
                new Item("Oceanic Gear", "all", 30, 8, 0, 0, 8),
                new Item("Robe of Power", "all", 18, 8, 0.5, 0, 6),
                new Item("Heavy Fortress", "all", 45, 8, 0, 0, 2)
            };

            List<Item> armorTier3 = new List<Item>()
            {
                new Item("Borealis Shirt if Shivers", "all", 60, 16, 0, 0, 20),
                new Item("Gear of the Unstopable", "all", 36, 16, 0.7, 0, 15),
                new Item("Life God's Robe", "all", 90, 16, 0, 0, 5)
            };

            CharacterArcher character1 = new CharacterArbalist("default", 13, 8, 1.3, 150, 30);
            CharacterArcher character2 = new CharacterBowman("default", 12, 7, 1.2, 140, 40);
            CharacterKnight character3 = new CharacterOneHandedSwordsman("default", 12, 10, 1.3, 140, 50);
            CharacterKnight character4 = new CharacterTwoHandedSwordsman("default", 15, 7, 1, 180, 60);
            CharacterMage character5 = new CharacterPyromancer("default", 12, 9, 1.2, 130, 200);
            CharacterMage character6 = new CharacterNecromancer("default", 9, 8, 1.25, 220, 220);
            CharacterKnight character7 = new CharacterSpearman("default", 13, 10, 1.30, 150, 50);

            List<ICharacters> characters = new List<ICharacters>()
            {
                character1,
                character2,
                character3,
                character4,
                character5,
                character6,
                character7
            };

            double coeficientTier1 = 1.5;
            double coeficientTier2 = 2.5;
            double coeficientTier3 = 3.5;

            List<ICreature> tier1Boss = new List<ICreature>(7)
            {
<<<<<<< HEAD
                new Arbalist("Marroweater the Deathbringer", Convert.ToInt32(13 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1.1, Convert.ToInt32(110 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new Bowman("Lightshorn the Impaler", Convert.ToInt32(12 * coeficientTier1), Convert.ToInt32(7 * coeficientTier1), 1.3, Convert.ToInt32(110 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new OneHandedSwordsman("Mordath the Undefeated", Convert.ToInt32(10 * coeficientTier1), Convert.ToInt32(15 * coeficientTier1), 1.25, Convert.ToInt32(150 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new TwoHandedSwordsman("Dreadnaught the Miser", Convert.ToInt32(15 * coeficientTier1), Convert.ToInt32(5 * coeficientTier1), 1.15, Convert.ToInt32(170 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new Spearman("Thornblight - the Reaper's Kiss", Convert.ToInt32(12 * coeficientTier1), Convert.ToInt32(10 * coeficientTier1), 1.30, Convert.ToInt32(150 * coeficientTier1), Convert.ToInt32(0 * coeficientTier1)),
                new Pyromancer("Bramblejack the Wicked", Convert.ToInt32(10 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1, Convert.ToInt32(120 * coeficientTier1), Convert.ToInt32(150 * coeficientTier1)),
                new Necromancer("Abolusha - Oracle of Curses", Convert.ToInt32(8 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1, Convert.ToInt32(90 * coeficientTier1), Convert.ToInt32(200 * coeficientTier1))
=======
                new Arbalist("Polygon", Convert.ToInt32(13 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1.1, Convert.ToInt32(110 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new Bowman("Green Arrow", Convert.ToInt32(12 * coeficientTier1), Convert.ToInt32(7 * coeficientTier1), 1.3, Convert.ToInt32(110 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new OneHandedSwordsman("Arabor", Convert.ToInt32(10 * coeficientTier1), Convert.ToInt32(15 * coeficientTier1), 1.25, Convert.ToInt32(150 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new TwoHandedSwordsman("Dark King", Convert.ToInt32(15 * coeficientTier1), Convert.ToInt32(5 * coeficientTier1), 1.15, Convert.ToInt32(170 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new Spearman("Shin-Zao", Convert.ToInt32(12 * coeficientTier1), Convert.ToInt32(10 * coeficientTier1), 1.30, Convert.ToInt32(150 * coeficientTier1), Convert.ToInt32(0 * coeficientTier1)),
                new Pyromancer("Lulilium", Convert.ToInt32(10 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1, Convert.ToInt32(120 * coeficientTier1), Convert.ToInt32(150 * coeficientTier1)),
                new Necromancer("Darquesse", Convert.ToInt32(8 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1, Convert.ToInt32(90 * coeficientTier1), Convert.ToInt32(200 * coeficientTier1))
>>>>>>> f0c519262bc91fbf89cb244a6dada6aa8b40eb53
            };

            List<ICreature> tier2Boss = new List<ICreature>(7)
            {
<<<<<<< HEAD
                new Arbalist("Grayskin the Conqueror", Convert.ToInt32(13 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1.1, Convert.ToInt32(110 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new Bowman("Damnerstake of the Iron Cage", Convert.ToInt32(12 * coeficientTier2), Convert.ToInt32(7 * coeficientTier2), 1.3, Convert.ToInt32(110 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new OneHandedSwordsman("Deathmire Wyrmtonguer", Convert.ToInt32(10 * coeficientTier2), Convert.ToInt32(15 * coeficientTier2), 1.25, Convert.ToInt32(150 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new TwoHandedSwordsman("Typhus Horsegutter", Convert.ToInt32(15 * coeficientTier2), Convert.ToInt32(5 * coeficientTier2), 1.15, Convert.ToInt32(170 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new Spearman("Wolftamer Knightslayer", Convert.ToInt32(12 * coeficientTier2), Convert.ToInt32(10 * coeficientTier2), 1.30, Convert.ToInt32(150 * coeficientTier2), Convert.ToInt32(0 * coeficientTier2)),
                new Pyromancer("Skinrender the Flameborne", Convert.ToInt32(10 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1, Convert.ToInt32(120 * coeficientTier2), Convert.ToInt32(150 * coeficientTier2)),
                new Necromancer("Portent the Cannibal", Convert.ToInt32(8 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1, Convert.ToInt32(90 * coeficientTier2), Convert.ToInt32(200 * coeficientTier2))
=======
                new Arbalist("Vipertron", Convert.ToInt32(13 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1.1, Convert.ToInt32(110 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new Bowman("Raftel", Convert.ToInt32(12 * coeficientTier2), Convert.ToInt32(7 * coeficientTier2), 1.3, Convert.ToInt32(110 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new OneHandedSwordsman("Kobalion", Convert.ToInt32(10 * coeficientTier2), Convert.ToInt32(15 * coeficientTier2), 1.25, Convert.ToInt32(150 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new TwoHandedSwordsman("Tornadus", Convert.ToInt32(15 * coeficientTier2), Convert.ToInt32(5 * coeficientTier2), 1.15, Convert.ToInt32(170 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new Spearman("The Wasp", Convert.ToInt32(12 * coeficientTier2), Convert.ToInt32(10 * coeficientTier2), 1.30, Convert.ToInt32(150 * coeficientTier2), Convert.ToInt32(0 * coeficientTier2)),
                new Pyromancer("Hellfire", Convert.ToInt32(10 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1, Convert.ToInt32(120 * coeficientTier2), Convert.ToInt32(150 * coeficientTier2)),
                new Necromancer("The Archivist", Convert.ToInt32(8 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1, Convert.ToInt32(90 * coeficientTier2), Convert.ToInt32(200 * coeficientTier2))
>>>>>>> f0c519262bc91fbf89cb244a6dada6aa8b40eb53
            };

            List<ICreature> tier3Boss = new List<ICreature>(7)
            {
<<<<<<< HEAD
                new Arbalist("Corpsebreath Skullgrinder", Convert.ToInt32(13 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1.1, Convert.ToInt32(110 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new Bowman("Grendle Bloodmount", Convert.ToInt32(12 * coeficientTier3), Convert.ToInt32(7 * coeficientTier3), 1.3, Convert.ToInt32(110 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new OneHandedSwordsman("Limper Stormbringer", Convert.ToInt32(10 * coeficientTier3), Convert.ToInt32(15 * coeficientTier3), 1.25, Convert.ToInt32(150 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new TwoHandedSwordsman("Tempest Bileblossom", Convert.ToInt32(15 * coeficientTier3), Convert.ToInt32(5 * coeficientTier3), 1.15, Convert.ToInt32(170 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new Spearman("Kane the Hobbled", Convert.ToInt32(12 * coeficientTier3), Convert.ToInt32(10 * coeficientTier3), 1.30, Convert.ToInt32(150 * coeficientTier3), Convert.ToInt32(0 * coeficientTier3)),
                new Pyromancer("Gluttonous Blackheart", Convert.ToInt32(10 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1, Convert.ToInt32(120 * coeficientTier3), Convert.ToInt32(150 * coeficientTier3)),
                new Necromancer("Ashencroft Soulbinder", Convert.ToInt32(8 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1, Convert.ToInt32(90 * coeficientTier3), Convert.ToInt32(200 * coeficientTier3))
=======
                new Arbalist("Arcus The Great", Convert.ToInt32(13 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1.1, Convert.ToInt32(110 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new Bowman("Razorwind", Convert.ToInt32(12 * coeficientTier3), Convert.ToInt32(7 * coeficientTier3), 1.3, Convert.ToInt32(110 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new OneHandedSwordsman(" Executioner of Denial", Convert.ToInt32(10 * coeficientTier3), Convert.ToInt32(15 * coeficientTier3), 1.25, Convert.ToInt32(150 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new TwoHandedSwordsman("Ragnarok", Convert.ToInt32(15 * coeficientTier3), Convert.ToInt32(5 * coeficientTier3), 1.15, Convert.ToInt32(170 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new Spearman("Bone Piercer", Convert.ToInt32(12 * coeficientTier3), Convert.ToInt32(10 * coeficientTier3), 1.30, Convert.ToInt32(150 * coeficientTier3), Convert.ToInt32(0 * coeficientTier3)),
                new Pyromancer("Meteor Strike", Convert.ToInt32(10 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1, Convert.ToInt32(120 * coeficientTier3), Convert.ToInt32(150 * coeficientTier3)),
                new Necromancer("Malistaire", Convert.ToInt32(8 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1, Convert.ToInt32(90 * coeficientTier3), Convert.ToInt32(200 * coeficientTier3))
>>>>>>> f0c519262bc91fbf89cb244a6dada6aa8b40eb53
            };

            List<ICreature> tier1Creatures = new List<ICreature>(7)
            {
                new Arbalist("default", 13, 8, 1.1, 110, 30),
                new Bowman("default", 12, 7, 1.3, 110, 30),
                new OneHandedSwordsman("default", 10, 15, 1.25, 150, 30),
                new TwoHandedSwordsman("default", 15, 5, 1.15, 170, 30),
                new Spearman("default", 12, 10, 1.30, 150, 0),
                new Pyromancer("default", 10, 8, 1, 120, 150),
                new Necromancer("default", 8, 8, 1, 90, 200)
            };

            List<ICreature> tier2Creatures = new List<ICreature>(7)
            {
                new Arbalist("default", 20, 14, 1.10, 220, 50),
                new Bowman("default", 17, 14, 1.30, 230, 50),
                new OneHandedSwordsman("default", 20, 20, 1.25, 200, 60),
                new TwoHandedSwordsman("default", 20, 13, 1.15, 260, 60),
                new Spearman("default", 18, 15, 1.30, 250, 0),
                new Pyromancer("default", 15, 18, 1.25, 240, 250),
                new Necromancer("default", 15, 16, 1.25, 240, 250)
            };

            List<ICreature> tier3Creatures = new List<ICreature>(7)
            {
                new Arbalist("default", 26, 14, 1.10, 220, 30),
                new Bowman("default", 23, 20, 1.30, 280, 100),
                new OneHandedSwordsman("default", 25, 25, 1.25, 320, 80),
                new TwoHandedSwordsman("default", 27, 25, 1.15, 300, 80),
                new Spearman("default", 23, 20, 1.30, 300, 0),
                new Pyromancer("default", 18, 23, 1.30, 300, 400),
                new Necromancer("default", 20, 20, 1.40, 300, 400)
            };

            Console.WriteLine("List of the possible characters: ");
            foreach (ICharacters character in characters)
            {
                Console.WriteLine(character.AsAString());
            }

            Console.WriteLine();
            string choice = "Choose Class: |    Crossbow    |   Bow   |     One-Hand Swordsman     |      Two-Hand Swordsman     |      Spearman     |      Pyromancer     |        Necromancer      |";

            for (int i = 0; i < choice.Length; i++)
            {
                Console.Write("-");

                if (i == choice.Length - 1)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine(choice);

            for (int i = 0; i < choice.Length; i++)
            {
                Console.Write("-");

                if (i == choice.Length - 1)
                {
                    Console.WriteLine();
                }
            }

            ICharacters currentCharacter = null;
            while (currentCharacter == null)
            {
                Console.Write("Enter class name: ");
                string chosenClass = Console.ReadLine();

                switch (chosenClass)
                {
                    case "Crossbow":
                        currentCharacter = character1;
                        Console.WriteLine("You have chosen class Crossbow\n");
                        break;
                    case "Bow":
                        currentCharacter = character2;
                        Console.WriteLine("You have chosen class Bow\n");
                        break;
                    case "One-Hand Swordsman":
                        currentCharacter = character3;
                        Console.WriteLine("You have chosen class OHS\n");
                        break;
                    case "Two-Hand Swordsman":
                        currentCharacter = character4;
                        Console.WriteLine("You have chosen class THS\n");
                        break;
                    case "Pyromancer":
                        currentCharacter = character5;
                        Console.WriteLine("You have chosen class Pyromancer\n");
                        break;
                    case "Necromancer":
                        currentCharacter = character6;
                        Console.WriteLine("You have chosen class Necromancer\n");
                        break;
                    case "Spearman":
                        currentCharacter = character7;
                        Console.WriteLine("You have chosen class Spearman\n");
                        break;
                    default:
                        Console.WriteLine("Bad Input\n");
                        break;
                }
            }

            Console.Write("Enter name: ");
            string givenName = Console.ReadLine();
            while (string.IsNullOrEmpty(givenName))
            {
                Console.WriteLine("Your Character must have a name!");
                givenName = Console.ReadLine();
            }

            currentCharacter.Name = givenName;
            Console.WriteLine("Your name is " + currentCharacter.Name + "\n");

            foreach (var item in tier1Boss)
            {
                Console.WriteLine($"{item.Name}, {item.Attack}, {item.Defence}, {item.HealthPoints}, {item.Mana}, {item.Speed}");
            }

        }
    }
}
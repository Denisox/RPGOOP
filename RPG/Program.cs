using System;
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

            Item armor1 = new Item("Evergreen Armor", "all", 20, 5, 0, 0, 4);
            Item armor2 = new Item("Mantle of Destruction", "all", 12, 5, 0.3, 0, 3);
            Item armor3 = new Item("Shell of the Undying", "all", 30, 5, 0, 0, 1);

            List<Item> armorTier1 = new List<Item>()
            {
                armor1,
                armor2,
                armor3
            };

            Item armor4 = new Item("Oceanic Gear", "all", 30, 8, 0, 0, 8);
            Item armor5 = new Item("Robe of Power", "all", 18, 8, 0.5, 0, 6);
            Item armor6 = new Item("Heavy Fortress", "all", 45, 8, 0, 0, 2);

            List<Item> armorTier2 = new List<Item>()
            {
                armor4,
                armor5,
                armor6
            };

            Item armor7 = new Item("Borealis Shirt if Shivers", "all", 60, 16, 0, 0, 20);
            Item armor8 = new Item("Gear of the Unstopable", "all", 36, 16, 0.7, 0, 15);
            Item armor9 = new Item("Life God's Robe", "all", 90, 16, 0, 0, 5);

            List<Item> armorTier3 = new List<Item>()
            {
                armor7,
                armor8,
                armor9
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

            Archer creature1Tier1 = new Arbalist("default", 13, 8, 1.1, 110, 30);
            Archer creature2Tier1 = new Bowman("default", 12, 7, 1.3, 110, 30);
            Knight creature3Tier1 = new OneHandedSwordsman("default", 10, 15, 1.25, 150, 30);
            Knight creature4Tier1 = new TwoHandedSwordsman("default", 15, 5, 1.15, 170, 30);
            Knight creature5Tier1 = new Spearman("default", 12, 10, 1.30, 150, 0);
            Mage creature6Tier1 = new Pyromanser("default", 10, 8, 1, 120, 150);
            Mage creature7Tier1 = new Necromanser("default", 8, 8, 1, 90, 200);

            List<ICreature> tier1Creatures = new List<ICreature>(7)
            {
                creature1Tier1,
                creature2Tier1,
                creature3Tier1,
                creature4Tier1,
                creature5Tier1,
                creature6Tier1,
                creature7Tier1
            };

            Archer creature1Tier2 = new Arbalist("default", 20, 14, 1.10, 220, 50);
            Archer creature2Tier2 = new Bowman("default", 17, 14, 1.30, 230, 50);
            Knight creature3Tier2 = new OneHandedSwordsman("default", 20, 20, 1.25, 200, 60);
            Knight creature4Tier2 = new TwoHandedSwordsman("default", 20, 13, 1.15, 260, 60);
            Knight creature5Tier2 = new Spearman("default", 18, 15, 1.30, 250, 0);
            Mage creature6Tier2 = new Pyromanser("default", 15, 18, 1.25, 240, 250);
            Mage creature7Tier2 = new Necromanser("default", 15, 16, 1.25, 240, 250);

            List<ICreature> tier2Creatures = new List<ICreature>(7)
            {
                creature1Tier2,
                creature2Tier2,
                creature3Tier2,
                creature4Tier2,
                creature5Tier2,
                creature6Tier2,
                creature7Tier2
            };

            Archer creature1Tier3 = new Arbalist("default", 26, 14, 1.10, 220, 30);
            Archer creature2Tier3 = new Bowman("default", 23, 20, 1.30, 280, 100);
            Knight creature3Tier3 = new OneHandedSwordsman("default", 25, 25, 1.25, 320, 80);
            Knight creature4Tier3 = new TwoHandedSwordsman("default", 27, 25, 1.15, 300, 80);
            Knight creature5Tier3 = new Spearman("default", 23, 20, 1.30, 300, 0);
            Mage creature6Tier3 = new Pyromanser("default", 18, 23, 1.30, 300, 400);
            Mage creature7Tier3 = new Necromanser("default", 20, 20, 1.40, 300, 400);

            List<ICreature> tier3Creatures = new List<ICreature>(7)
            {
                creature1Tier3,
                creature2Tier3,
                creature3Tier3,
                creature4Tier3,
                creature5Tier3,
                creature6Tier3,
                creature7Tier3
            };

            Console.WriteLine("List of the possible characters: ");
            foreach (ICharacters character in characters)
            {
                Console.WriteLine(character.AsAString());
            }

            Console.WriteLine();
            string choice = "Choose Class: |    Crossbow    |   Bow   |     One - Hand Swordsman     |      Two - Hand Swordsman     |      Spearman     |      Pyromancer     |        Necromancer      |";

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
        }
    }
}
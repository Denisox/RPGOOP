using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Items;
using RPG.Interfaces;
using RPG.Classes;
using RPG.CharacterClasses;
using RPG.Weapon_Mastery;
using RPG.CharacterClasses.Weapon_Mastery;

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
            
           CharacterArbalist character1 = new CharacterArbalist("default", 13, 8, 1.3, 150, 30);
            CharacterBowman character2 = new CharacterBowman("default", 12, 7, 1.2, 140, 40 );
            CharacterOneHandedSwordsman character3 = new CharacterOneHandedSwordsman("default", 12, 10, 1.3, 140, 50);
            CharacterTwoHandedSwordsman character4 = new CharacterTwoHandedSwordsman("default", 15, 7, 1, 180, 60);
            CharacterPyromancer character5 = new CharacterPyromancer("default", 12, 9, 1.2, 130, 200);
            CharacterNecromancer character6 = new CharacterNecromancer("default", 9, 8, 1.25, 220, 220 );
            CharacterSpearman character7 = new CharacterSpearman("default", 13, 10, 1.30, 150, 50);

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

            Console.WriteLine("\nList of the possible characters: \n");
            foreach(ICharacters character in characters)
            {
                Console.WriteLine(character.AsAString());
            }
            Console.WriteLine("Choose Class from the following: Crossbow, Bow, One-Hand Swordsman, Two-Hand Swordsman, Spearman, Pyromancer or Necromancer\n");


            ICharacters currentCharacter = null;
            while (currentCharacter == null)
            {
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
                        Console.WriteLine("Bad Input");
                        break;
                }
            }

            String givenName = Console.ReadLine();
            while (String.IsNullOrEmpty(givenName))
            {
                Console.WriteLine("Your Character must have a name!");
                givenName = Console.ReadLine();
            }

            currentCharacter.Name = givenName;
            Console.WriteLine("Your name is " + currentCharacter.Name);



        }
    }
}
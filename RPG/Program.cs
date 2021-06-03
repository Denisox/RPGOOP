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
            List<Item> weaponsTier1 = new List<Item>()
            {
                new Item("Galvanic Staff", "Mage", 0, 0, 0.1, 4, 0),
                new Item("Cerulean Edge", "OHS", 0, 0, 0.2, 2, 0),
                new Item("Spear of Regeneration", "Spear", 0, 0, 0.2, 4, 0),
                new Item("Shield of Valor", "OHS", 0, 0, 0, 1, 3),
                new Item("Destructive Blade", "THS", 0, 0, 0.1, 4, 0),
                new Item("Crimson Bow", "Bow", 0, 0, 0.2, 3, 0),
                new Item("Azure Crossbow of Destruction", "Crossbow", 0, 0, 0.3, 2, 0)
            };

            List<Item> weaponsTier2 = new List<Item>()
            {
                new Item("Icy Staff", "Mage", 0, 0, 0.2, 5, 0),
                new Item("Sword of Dignity", "OHS", 0, 0, 0.3, 3, 0),
                new Item("Spear of Wolf's Vengance", "Spear", 0, 0, 0.3, 5, 0),
                new Item("Shield of Infinity", "OHS", 0, 0, 0, 1, 4),
                new Item("Serpent Blade", "THS", 0, 0, 0.15, 5, 0),
                new Item("Purple Bow of Nobility", "Bow", 0, 0, 0.25, 4, 0),
                new Item("Crossbow of Eternity", "Crossbow", 0, 0, 0.35, 3, 0)
            };

            List<Item> weaponsTier3 = new List<Item>()
            {
                new Item("Mage Staff of Isolation", "Mage", 0, 0, 0.3, 7, 0),
                new Item("Black Destroyer", "OHS", 0, 0, 0.3, 5, 0),
                new Item("Spear of Witch's Wrath", "Spear", 0, 0, 0.35, 6, 0),
                new Item("Shield of Brutality", "OHS", 0, 0, 0, 1, 6),
                new Item("Blade of the Undefeated", "THS", 0, 0, 0.2, 7, 0),
                new Item("The Bow", "Bow", 0, 0, 0.3, 5, 0),
                new Item("Mega V", "Crossbow", 0, 0, 0.4, 4, 0)
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

            // attack and health * 1.5
            // defence * 1.2

            CharacterArcher character1 = new CharacterArbalist("default", 20, 12, 1.3, 225, 30);
            CharacterArcher character2 = new CharacterBowman("default", 18, 8, 1.2, 168, 40);
            CharacterKnight character3 = new CharacterOneHandedSwordsman("default", 18, 12, 1.3, 168, 50);
            CharacterKnight character4 = new CharacterTwoHandedSwordsman("default", 23, 8, 1, 216, 60);
            CharacterMage character5 = new CharacterPyromancer("default", 18, 11, 1.2, 156, 200);
            CharacterMage character6 = new CharacterNecromancer("default", 14, 10, 1.25, 264, 220);
            CharacterKnight character7 = new CharacterSpearman("default", 20, 12, 1.30, 180, 50);

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
                new Arbalist("Polygon", Convert.ToInt32(13 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1.1, Convert.ToInt32(110 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new Bowman("Green Arrow", Convert.ToInt32(12 * coeficientTier1), Convert.ToInt32(7 * coeficientTier1), 1.3, Convert.ToInt32(110 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new OneHandedSwordsman("Arabor", Convert.ToInt32(10 * coeficientTier1), Convert.ToInt32(15 * coeficientTier1), 1.25, Convert.ToInt32(150 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new TwoHandedSwordsman("Dark King", Convert.ToInt32(15 * coeficientTier1), Convert.ToInt32(5 * coeficientTier1), 1.15, Convert.ToInt32(170 * coeficientTier1), Convert.ToInt32(30 * coeficientTier1)),
                new Spearman("Shin-Zao", Convert.ToInt32(12 * coeficientTier1), Convert.ToInt32(10 * coeficientTier1), 1.30, Convert.ToInt32(150 * coeficientTier1), Convert.ToInt32(0 * coeficientTier1)),
                new Pyromancer("Lulilium", Convert.ToInt32(10 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1, Convert.ToInt32(120 * coeficientTier1), Convert.ToInt32(150 * coeficientTier1)),
                new Necromancer("Darquesse", Convert.ToInt32(8 * coeficientTier1), Convert.ToInt32(8 * coeficientTier1), 1, Convert.ToInt32(90 * coeficientTier1), Convert.ToInt32(200 * coeficientTier1))
            };

            List<ICreature> tier2Boss = new List<ICreature>(7)
            {
                new Arbalist("Vipertron", Convert.ToInt32(13 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1.1, Convert.ToInt32(110 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new Bowman("Raftel", Convert.ToInt32(12 * coeficientTier2), Convert.ToInt32(7 * coeficientTier2), 1.3, Convert.ToInt32(110 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new OneHandedSwordsman("Kobalion", Convert.ToInt32(10 * coeficientTier2), Convert.ToInt32(15 * coeficientTier2), 1.25, Convert.ToInt32(150 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new TwoHandedSwordsman("Tornadus", Convert.ToInt32(15 * coeficientTier2), Convert.ToInt32(5 * coeficientTier2), 1.15, Convert.ToInt32(170 * coeficientTier2), Convert.ToInt32(30 * coeficientTier2)),
                new Spearman("The Wasp", Convert.ToInt32(12 * coeficientTier2), Convert.ToInt32(10 * coeficientTier2), 1.30, Convert.ToInt32(150 * coeficientTier2), Convert.ToInt32(0 * coeficientTier2)),
                new Pyromancer("Hellfire", Convert.ToInt32(10 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1, Convert.ToInt32(120 * coeficientTier2), Convert.ToInt32(150 * coeficientTier2)),
                new Necromancer("The Archivist", Convert.ToInt32(8 * coeficientTier2), Convert.ToInt32(8 * coeficientTier2), 1, Convert.ToInt32(90 * coeficientTier2), Convert.ToInt32(200 * coeficientTier2))
            };

            List<ICreature> tier3Boss = new List<ICreature>(7)
            {
                new Arbalist("Arcus The Great", Convert.ToInt32(13 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1.1, Convert.ToInt32(110 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new Bowman("Razorwind", Convert.ToInt32(12 * coeficientTier3), Convert.ToInt32(7 * coeficientTier3), 1.3, Convert.ToInt32(110 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new OneHandedSwordsman(" Executioner of Denial", Convert.ToInt32(10 * coeficientTier3), Convert.ToInt32(15 * coeficientTier3), 1.25, Convert.ToInt32(150 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new TwoHandedSwordsman("Ragnarok", Convert.ToInt32(15 * coeficientTier3), Convert.ToInt32(5 * coeficientTier3), 1.15, Convert.ToInt32(170 * coeficientTier3), Convert.ToInt32(30 * coeficientTier3)),
                new Spearman("Bone Piercer", Convert.ToInt32(12 * coeficientTier3), Convert.ToInt32(10 * coeficientTier3), 1.30, Convert.ToInt32(150 * coeficientTier3), Convert.ToInt32(0 * coeficientTier3)),
                new Pyromancer("Meteor Strike", Convert.ToInt32(10 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1, Convert.ToInt32(120 * coeficientTier3), Convert.ToInt32(150 * coeficientTier3)),
                new Necromancer("Malistaire", Convert.ToInt32(8 * coeficientTier3), Convert.ToInt32(8 * coeficientTier3), 1, Convert.ToInt32(90 * coeficientTier3), Convert.ToInt32(200 * coeficientTier3))
            };

            List<ICreature> tier1Creatures = new List<ICreature>(7)
            {
                new Arbalist("tier1 Arbalist", 13, 8, 1.1, 110, 30),
                new Bowman("tier1 Bowman", 12, 7, 1.3, 110, 30),
                new OneHandedSwordsman("tier1 One-Handed Swordsman", 10, 15, 1.25, 150, 30),
                new TwoHandedSwordsman("tier1 Two-Handed Swordsman", 15, 5, 1.15, 170, 30),
                new Spearman("tier1 Spearman", 12, 10, 1.30, 150, 0),
                new Pyromancer("tier1 Pyromancer", 10, 8, 1, 120, 150),
                new Necromancer("tier1 Necromancer", 8, 8, 1, 90, 200)
            };

            List<ICreature> tier2Creatures = new List<ICreature>(7)
            {
                new Arbalist("tier2 Arbalist", 20, 14, 1.10, 220, 50),
                new Bowman("tier2 Bowman", 17, 14, 1.30, 230, 50),
                new OneHandedSwordsman("tier2 One-Handed Swordsman", 20, 20, 1.25, 200, 60),
                new TwoHandedSwordsman("tier2 Two-Handed Swordsman", 20, 13, 1.15, 260, 60),
                new Spearman("tier2 Spearman", 18, 15, 1.30, 250, 0),
                new Pyromancer("tier2 Pyromancer", 15, 18, 1.25, 240, 250),
                new Necromancer("tier2 Necromancer", 15, 16, 1.25, 240, 250)
            };

            List<ICreature> tier3Creatures = new List<ICreature>(7)
            {
                new Arbalist("tier3 Arbalist", 26, 14, 1.10, 220, 30),
                new Bowman("tier3 Bowman", 23, 20, 1.30, 280, 100),
                new OneHandedSwordsman("tier3 One-Handed Swordsman", 25, 25, 1.25, 320, 80),
                new TwoHandedSwordsman("tier3 Two-Handed Swordsman", 27, 25, 1.15, 300, 80),
                new Spearman("tier3 Spearman", 23, 20, 1.30, 300, 0),
                new Pyromancer("tier3 Pyromancer", 18, 23, 1.30, 300, 400),
                new Necromancer("tier3 Necromancer", 20, 20, 1.40, 300, 400)
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
                        Console.WriteLine("You have chosen class: Crossbow\n");
                        break;

                    case "Bow":
                        currentCharacter = character2;
                        Console.WriteLine("You have chosen class: Bow\n");
                        break;

                    case "One-Hand Swordsman":
                        currentCharacter = character3;
                        Console.WriteLine("You have chosen class: OHS\n");
                        break;

                    case "Two-Hand Swordsman":
                        currentCharacter = character4;
                        Console.WriteLine("You have chosen class: THS\n");
                        break;

                    case "Pyromancer":
                        currentCharacter = character5;
                        Console.WriteLine("You have chosen class: Pyromancer\n");
                        break;

                    case "Necromancer":
                        currentCharacter = character6;
                        Console.WriteLine("You have chosen class: Necromancer\n");
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
            Console.WriteLine("Your name is " + currentCharacter.Name + ", let the Combat begin\n");

            Program program = new Program();
            program.CombatTier(currentCharacter, tier1Creatures, tier1Boss, weaponsTier1, armorTier1);

            if (currentCharacter.CurrentHealthPoints > 0)
            {
                Console.WriteLine("\n\nCongratulations! You finished Stage 1! Two more to go!");
                program.ItemDropTier2(weaponsTier2, armorTier2);
            }
            else
            {
                System.Environment.Exit(0);
            }

            program.CombatTier(currentCharacter, tier2Creatures, tier2Boss, weaponsTier1, armorTier1);

            if (currentCharacter.CurrentHealthPoints > 0)
            {
                Console.WriteLine("\n\nCongratulations! You finished Stage 2! One more to go!");
                program.ItemDropTier3(weaponsTier3, armorTier3);
            }
            else
            {
                System.Environment.Exit(0);
            }

            program.CombatTier(currentCharacter, tier3Creatures, tier3Boss, weaponsTier1, armorTier1);

            if (currentCharacter.CurrentHealthPoints > 0)
            {
                Console.WriteLine("\n\nCongratulations! You finished Stage 3! Game Over, you win!");
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        private void ItemDropTier1(List<Item> weaponsTier1, List<Item> armorTier1)
        {
            Random randomNum = new Random();
            int indexWeapon = 0, indexArmor = 0;
            int chance = randomNum.Next(1, 101);

            if (chance <= 70)
            {
                indexWeapon = randomNum.Next(weaponsTier1.Count);
                Console.WriteLine($"Drop: {weaponsTier1[indexWeapon].Name}");
            }
            else
            {
                indexArmor = randomNum.Next(armorTier1.Count);
                Console.WriteLine($"Drop: {armorTier1[indexArmor].Name}");
            }
        }

        private void ItemDropTier2(List<Item> weaponsTier2, List<Item> armorTier2)
        {
            Random randomNum = new Random();
            int indexWeapon = randomNum.Next(weaponsTier2.Count);
            int indexArmor = randomNum.Next(armorTier2.Count);

            Console.WriteLine($"Drops: {weaponsTier2[indexWeapon].Name} and {armorTier2[indexArmor].Name}");
        }

        private void ItemDropTier3(List<Item> weaponsTier3, List<Item> armorTier3)
        {
            Random randomNum = new Random();
            int indexWeapon = randomNum.Next(weaponsTier3.Count);
            int indexArmor = randomNum.Next(armorTier3.Count);

            Console.WriteLine($"Drops: {weaponsTier3[indexWeapon].Name} and {armorTier3[indexArmor].Name}");
        }

        public void CombatTier(ICharacters currentCharacter, List<ICreature> tier1Creatures, List<ICreature> tier1Boss, List<Item> weaponsTier1, List<Item> armorTier1)
        {
            for (int i = 0; i < 3; i++)
            {
                Random random1 = new Random();
                int index = random1.Next(tier1Creatures.Count);
                ICreature currentCreature = tier1Creatures[index];

                Console.WriteLine("\nYou will be fighting a: " + currentCreature.Name + "\n");

                if (currentCharacter.Speed >= currentCreature.Speed)
                {
                    while (currentCharacter.CurrentHealthPoints > 0 && currentCreature.CurrentHealthPoints > 0)
                    {
                        Console.Write("\nList of possible commands: Attack / Buff / Shield / Heal / Power Attack\nEnter a command: ");
                        string currentCommand = Console.ReadLine();
                        ExecuteCommand(currentCommand, currentCharacter, currentCreature);
                        Console.WriteLine("You used: " + currentCommand);
                        Console.WriteLine(currentCharacter.Status());
                        Console.WriteLine(currentCreature.Status());

                        if (currentCreature.CurrentHealthPoints <= 0)
                        {
                            break;
                        }

                        string mobCommand = MobAction(currentCharacter, currentCreature);
                        Console.WriteLine("The mob used " + mobCommand);
                        Console.WriteLine(currentCharacter.Status());
                        Console.WriteLine(currentCreature.Status());
                    }

                    SomeoneDied(currentCharacter, currentCreature);
                    ItemDropTier1(weaponsTier1, armorTier1);
                    Reheal(currentCharacter);
                }
                else
                {
                    while (currentCharacter.CurrentHealthPoints > 0 && currentCreature.CurrentHealthPoints > 0)
                    {
                        Console.Write("\nList of possible commands: Attack / Buff / Shield / Heal / Power Attack\nEnter a command: ");
                        string currentCommand = Console.ReadLine();
                        string mobCommand = MobAction(currentCharacter, currentCreature);
                        Console.WriteLine("The mob used " + mobCommand);
                        Console.WriteLine(currentCharacter.Status());
                        Console.WriteLine(currentCreature.Status());

                        if (currentCharacter.CurrentHealthPoints <= 0)
                        {
                            break;
                        }

                        ExecuteCommand(currentCommand, currentCharacter, currentCreature);
                        Console.WriteLine("You used: " + currentCommand);
                        Console.WriteLine(currentCharacter.Status());
                        Console.WriteLine(currentCreature.Status());
                    }

                    SomeoneDied(currentCharacter, currentCreature);
                    Reheal(currentCharacter);
                }
            }

            Random random2 = new Random();
            int indexBoss = random2.Next(tier1Boss.Count);
            ICreature currentBoss = tier1Boss[indexBoss];
            Console.WriteLine("\nYou will be fighting a: " + currentBoss.Name + "\n");

            if (currentCharacter.Speed >= currentBoss.Speed)
            {
                while (currentBoss.CurrentHealthPoints > 0 && currentBoss.CurrentHealthPoints > 0)
                {
                    Console.Write("\nList of possible commands: Attack / Buff / Shield / Heal / Power Attack\nEnter a command: ");
                    string currentCommand = Console.ReadLine();
                    ExecuteCommand(currentCommand, currentCharacter, currentBoss);
                    Console.WriteLine("You used: " + currentCommand);
                    Console.WriteLine(currentCharacter.Status());
                    Console.WriteLine(currentBoss.Status());

                    if (currentBoss.CurrentHealthPoints <= 0)
                    {
                        break;
                    }

                    Console.WriteLine("The boss used: " + MobAction(currentCharacter, currentBoss));
                    Console.WriteLine(currentCharacter.Status());
                    Console.WriteLine(currentBoss.Status());
                }

                SomeoneDied(currentCharacter, currentBoss);
                Reheal(currentCharacter);
            }
            else
            {
                while (currentCharacter.CurrentHealthPoints > 0 && currentBoss.CurrentHealthPoints > 0)
                {
                    Console.Write("\nList of possible commands: Attack / Buff / Shield / Heal / Power Attack\nEnter a command: ");
                    string currentCommand = Console.ReadLine();
                    Console.WriteLine("The boss used: " + MobAction(currentCharacter, currentBoss));

                    Console.WriteLine(currentCharacter.Status());
                    Console.WriteLine(currentBoss.Status());

                    if (currentCharacter.CurrentHealthPoints <= 0)
                    {
                        break;
                    }

                    ExecuteCommand(currentCommand, currentCharacter, currentBoss);
                    Console.WriteLine("You used: " + currentCommand);
                    Console.WriteLine(currentCharacter.Status());
                    Console.WriteLine(currentBoss.Status());
                }

                SomeoneDied(currentCharacter, currentBoss);
                Reheal(currentCharacter);
            }
        }

        private void ExecuteCommand(string currentCommand, ICharacters currentCharacter, ICreature currentCreature)
        {
            while (true)
            {
                currentCommand = currentCommand.ToLower();
                if (currentCommand == "attack")
                {
                    currentCharacter.NormalAttack(currentCreature);
                    currentCreature.GetDamage();
                    Recharge(currentCharacter);
                    break;
                }
                else if (currentCommand == "buff")
                {
                    currentCharacter.GetBuff();
                    Recharge(currentCharacter);
                    break;
                }
                else if (currentCommand == "shield")
                {
                    currentCharacter.GetShield();
                    Recharge(currentCharacter);
                    break;
                }
                else if (currentCommand == "heal")
                {
                    currentCharacter.HealCharacter(currentCharacter);
                    Recharge(currentCharacter);
                    break;
                }
                else if (currentCommand == "power attack")
                {
                    currentCharacter.PowerAttack(currentCreature);
                    currentCreature.GetDamage();
                    Recharge(currentCharacter);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command");
                    currentCommand = Console.ReadLine();
                }
            }
        }

        private string MobAction(ICharacters currentCharacter, ICreature currentCreature)
        {
            Random random2 = new Random();
            int chanceForMob = random2.Next(1, 101);
            if (chanceForMob < 70)
            {
                currentCreature.AttackCharacter(currentCharacter);
                currentCharacter.GetDamage();
                return "Attack";
            }
            else if (chanceForMob >= 70 && chanceForMob < 84)
            {
                currentCreature.GetBuff();
                return "Buff";
            }
            else if (chanceForMob >= 84 && chanceForMob <= 98)
            {
                currentCreature.GetShield();
                return "Shield";
            }
            else if (chanceForMob > 98)
            {
                currentCreature.Heal();
                return "Heal";
            }
            return "Bug, no command";
        }

        private void SomeoneDied(ICharacters currentCharacter, ICreature currentCreature)
        {
            if (currentCharacter.CurrentHealthPoints <= 0)
            {
                Console.WriteLine("You have died! Game over! You Lose!");
            }

            if (currentCreature.CurrentHealthPoints <= 0)
            {
                Console.WriteLine("You defeated this mob!");
            }
        }

        private void Recharge(ICharacters currentCharacter)
        {
            currentCharacter.CurrentMana += 7;
        }

        private void Reheal(ICharacters currentCharacter)
        {
            if (Convert.ToInt32(1.2 * currentCharacter.CurrentHealthPoints) <= currentCharacter.HealthPoints)
            {
                currentCharacter.CurrentHealthPoints = Convert.ToInt32(currentCharacter.CurrentHealthPoints * 1.2);
            }
            else
            {
                currentCharacter.CurrentHealthPoints = currentCharacter.HealthPoints;
            }
        }
    }
}
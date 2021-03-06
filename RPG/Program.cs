using System;
using System.Collections.Generic;
using RPG.Items;
using RPG.Interfaces;
using RPG.Instances;

namespace RPG
{
    public class Program
    {
        private Item currentWeapon = null;
        private Item currentArmor = null;
        private Item oldWeapon = new Item("null", "all", 0, 0, 0, 0, 0);
        private Item oldArmor = new Item("null", "all", 0, 0, 0, 0, 0);

        private static void Main(string[] args)
        {
            ItemsInstance itemsInstance = new ItemsInstance();
            CharactеrInstance characterInstance = new CharactеrInstance();
            MobsInstance mobsInstance = new MobsInstance();
            BossInstance bossInstance = new BossInstance();
            Program program = new Program();

            // list of list of all weapons and armors
            List<List<Item>> containsAllItems = new List<List<Item>>()
            {
                itemsInstance.weaponsTier1,
                itemsInstance.armorTier1,
                itemsInstance.weaponsTier2,
                itemsInstance.armorTier2,
                itemsInstance.weaponsTier3,
                itemsInstance.armorTier3
            };

            // list of all available charecters
            List<ICharacters> characters = new List<ICharacters>()
            {
                characterInstance.character1,
                characterInstance.character2,
                characterInstance.character3,
                characterInstance.character4,
                characterInstance.character5,
                characterInstance.character6,
                characterInstance.character7
            };

            // display all possible classes
            program.DisplayPossibleClasses(characters);

            ICharacters currentCharacter = null;

            // choose class
            currentCharacter = program.ChooseCurrentCharacterClass(currentCharacter, characterInstance);

            // choose name
            program.ChooseCurrentCharacterName(currentCharacter);

            // --------------------------------------------------------------------------------------------------

            // stage 1 combat start
            program.CombatTier(currentCharacter, mobsInstance.tier1Creatures, bossInstance.tier1Boss, itemsInstance.weaponsTier1, itemsInstance.armorTier1);

            // stage 1 finished, 2 more to go!
            program.Stage1Completed(currentCharacter);

            // --------------------------------------------------------------------------------------------------

            // stage 2 combat start
            program.CombatTier(currentCharacter, mobsInstance.tier2Creatures, bossInstance.tier2Boss, itemsInstance.weaponsTier2, itemsInstance.armorTier2);

            // stage 2 finished, 1 more to go!
            program.Stage2Completed(currentCharacter);

            // --------------------------------------------------------------------------------------------------

            // stage 3 combat start
            program.CombatTier(currentCharacter, mobsInstance.tier3Creatures, bossInstance.tier3Boss, itemsInstance.weaponsTier3, itemsInstance.armorTier3);

            // stage 3 finished, you win!
            program.Stage3Completed(currentCharacter);
            Program.GameOver();
        }

        // Method returns the class type and sets the weapon type prop
        public ICharacters ChooseCurrentCharacterClass(ICharacters currentCharacter, CharactеrInstance characterInstance)
        {
            while (currentCharacter == null)
            {
                Console.Write("Enter class name: ");
                string chosenClass = Console.ReadLine();

                switch (chosenClass)
                {
                    case "Crossbow":
                        currentCharacter = characterInstance.character1;
                        currentCharacter.WeaponType = "Crossbow";
                        Console.WriteLine("You have chosen class: Crossbow\n");
                        break;

                    case "Bow":
                        currentCharacter = characterInstance.character2;
                        currentCharacter.WeaponType = "Bow";
                        Console.WriteLine("You have chosen class: Bow\n");
                        break;

                    case "One-Hand Swordsman":
                        currentCharacter = characterInstance.character3;
                        currentCharacter.WeaponType = "OHS";
                        Console.WriteLine("You have chosen class: OHS\n");
                        break;

                    case "Two-Hand Swordsman":
                        currentCharacter = characterInstance.character4;
                        currentCharacter.WeaponType = "THS";
                        Console.WriteLine("You have chosen class: THS\n");
                        break;

                    case "Pyromancer":
                        currentCharacter = characterInstance.character5;
                        currentCharacter.WeaponType = "Mage";
                        Console.WriteLine("You have chosen class: Pyromancer\n");
                        break;

                    case "Necromancer":
                        currentCharacter = characterInstance.character6;
                        currentCharacter.WeaponType = "Mage";
                        Console.WriteLine("You have chosen class: Necromancer\n");
                        break;

                    case "Spearman":
                        currentCharacter = characterInstance.character7;
                        currentCharacter.WeaponType = "Spear";
                        Console.WriteLine("You have chosen class Spearman\n");
                        break;

                    default:
                        Console.WriteLine("Bad Input\n");
                        break;
                }
            }
            return currentCharacter;
        }

        // prints the name of the current character and sets Name prop
        public void ChooseCurrentCharacterName(ICharacters currentCharacter)
        {
            Console.Write("Enter name: ");
            string givenName = Console.ReadLine();
            while (string.IsNullOrEmpty(givenName))
            {
                Console.WriteLine("Your Character must have a name!");
                givenName = Console.ReadLine();
            }

            currentCharacter.Name = givenName;
            Console.WriteLine("Your name is " + currentCharacter.Name + ", let the Combat begin\n");
        }

        // prints all possible classes the user can choose from
        public void DisplayPossibleClasses(List<ICharacters> characters)
        {
            Console.WriteLine("List of the possible characters: ");
            foreach (ICharacters character in characters)
            {
                Console.WriteLine(character.AsAString());
            }

            Console.WriteLine();
            string choice = "Choose Class: |    Crossbow    |   Bow   |     One-Hand Swordsman     |      Two-Hand Swordsman     |      Spearman     |      Pyromancer     |        Necromancer      |";

            Console.WriteLine(choice);
        }

        // print message after stage 1 is completed
        public void Stage1Completed(ICharacters currentCharacter)
        {
            if (currentCharacter.CurrentHealthPoints > 0)
            {
                Console.WriteLine("\n\nCongratulations! You finished Stage 1! Two more to go!");
            }
            else
            {
                return;
            }
        }

        // print message after stage 2 is completed
        public void Stage2Completed(ICharacters currentCharacter)
        {
            if (currentCharacter.CurrentHealthPoints > 0)
            {
                Console.WriteLine("\n\nCongratulations! You finished Stage 2! Two more to go!");
            }
            else
            {
                return;
            }
        }

        // print message after stage 3 is completed
        public void Stage3Completed(ICharacters currentCharacter)
        {
            if (currentCharacter.CurrentHealthPoints > 0)
            {
                Console.WriteLine("\n\nCongratulations! You finished Stage 3! Game Over, you win!");
            }
            else
            {
                return;
            }
        }

        // Drop random weapon and armor after stage 1 is completed
        private void ItemDropTier1(List<Item> weaponsTier1, List<Item> armorTier1)
        {
            Random randomNum = new Random();
            int indexWeapon = 0, indexArmor = 0;
            int chance = randomNum.Next(1, 101);

            indexWeapon = randomNum.Next(weaponsTier1.Count);
            indexArmor = randomNum.Next(armorTier1.Count);
            currentWeapon = weaponsTier1[indexWeapon];
            currentArmor = armorTier1[indexArmor];
            Console.WriteLine($"Drops\nWeapon: {weaponsTier1[indexWeapon].Name}\nArmor: {armorTier1[indexArmor].Name}");
        }

        // Drop random weapon and armor after stage 2 is completed
        private void ItemDropTier2(List<Item> weaponsTier2, List<Item> armorTier2)
        {
            Random randomNum = new Random();
            int indexWeapon = randomNum.Next(weaponsTier2.Count);
            int indexArmor = randomNum.Next(armorTier2.Count);
            currentWeapon = weaponsTier2[indexWeapon];
            currentArmor = armorTier2[indexArmor];
            Console.WriteLine($"Drops\nWeapon: {weaponsTier2[indexWeapon].Name}\nArmor: {armorTier2[indexArmor].Name}");
        }

        // Drop random weapon and armor after stage 3 is completed
        private void ItemDropTier3(List<Item> weaponsTier3, List<Item> armorTier3)
        {
            Random randomNum = new Random();
            int indexWeapon = randomNum.Next(weaponsTier3.Count);
            int indexArmor = randomNum.Next(armorTier3.Count);
            currentWeapon = weaponsTier3[indexWeapon];
            currentArmor = armorTier3[indexArmor];
            Console.WriteLine($"Drops\nWeapon: {weaponsTier3[indexWeapon].Name}\nArmor: {armorTier3[indexArmor].Name}");
        }

        // start boss battle (1 boss per stage)
        public void BossBattle(ICharacters currentCharacter, List<ICreature> tier1Creatures, List<ICreature> tier1Boss, List<Item> weaponsTier1, List<Item> armorTier1)
        {
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
                    Console.WriteLine(currentCharacter.Status());
                    Console.WriteLine(currentBoss.Status());

                    if (currentBoss.CurrentHealthPoints <= 0)
                    {
                        break;
                    }

                    Console.WriteLine(currentCharacter.Status());
                    Console.WriteLine(currentBoss.Status());
                }

                SomeoneDied(currentCharacter, currentBoss);
                if (currentCharacter.CurrentHealthPoints <= 0)
                {
                    return;
                }
                Reheal(currentCharacter);
                ItemDropTier1(weaponsTier1, armorTier1);
                GettingEquipment(currentWeapon, currentArmor, oldWeapon, oldArmor, currentCharacter);
                ItemDropTier1(weaponsTier1, armorTier1);
                GettingEquipment(currentWeapon, currentArmor, oldWeapon, oldArmor, currentCharacter);
            }
            else
            {
                while (currentCharacter.CurrentHealthPoints > 0 && currentBoss.CurrentHealthPoints > 0)
                {
                    Console.Write("\nList of possible commands: Attack / Buff / Shield / Heal / Power Attack\nEnter a command: ");
                    string currentCommand = Console.ReadLine();

                    Console.WriteLine(currentCharacter.Status());
                    Console.WriteLine(currentBoss.Status());

                    if (currentCharacter.CurrentHealthPoints <= 0)
                    {
                        break;
                    }

                    ExecuteCommand(currentCommand, currentCharacter, currentBoss);
                    Console.WriteLine(currentCharacter.Status());
                    Console.WriteLine(currentBoss.Status());
                }

                SomeoneDied(currentCharacter, currentBoss);
                if (currentCharacter.CurrentHealthPoints <= 0)
                {
                    return;
                }
                Reheal(currentCharacter);
            }
        }

        // mob battle (3 mobs per stage)
        public void MobBattle(ICharacters currentCharacter, List<ICreature> tier1Creatures, List<ICreature> tier1Boss, List<Item> weaponsTier1, List<Item> armorTier1)
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
                        Console.WriteLine(currentCharacter.Status());
                        Console.WriteLine(currentCreature.Status());

                        if (currentCreature.CurrentHealthPoints <= 0)
                        {
                            break;
                        }

                        string mobCommand = MobAction(currentCharacter, currentCreature);
                        Console.WriteLine(currentCharacter.Status());
                        Console.WriteLine(currentCreature.Status());
                    }

                    SomeoneDied(currentCharacter, currentCreature);
                    if (currentCharacter.CurrentHealthPoints <= 0)
                    {
                        return;
                    }
                    Reheal(currentCharacter);
                }
                else
                {
                    while (currentCharacter.CurrentHealthPoints > 0 && currentCreature.CurrentHealthPoints > 0)
                    {
                        Console.Write("\nList of possible commands: Attack / Buff / Shield / Heal / Power Attack\nEnter a command: ");
                        string currentCommand = Console.ReadLine();
                        string mobCommand = MobAction(currentCharacter, currentCreature);
                        Console.WriteLine(currentCharacter.Status());
                        Console.WriteLine(currentCreature.Status());

                        if (currentCharacter.CurrentHealthPoints <= 0)
                        {
                            break;
                        }

                        ExecuteCommand(currentCommand, currentCharacter, currentCreature);
                        Console.WriteLine(currentCharacter.Status());
                        Console.WriteLine(currentCreature.Status());
                    }

                    SomeoneDied(currentCharacter, currentCreature);

                    if (currentCharacter.CurrentHealthPoints <= 0)
                    {
                        return;
                    }
                    Reheal(currentCharacter);
                }

                ItemDropTier1(weaponsTier1, armorTier1);
                GettingEquipment(currentWeapon, currentArmor, oldWeapon, oldArmor, currentCharacter);
            }
        }

        // start battle
        public void CombatTier(ICharacters currentCharacter, List<ICreature> tier1Creatures, List<ICreature> tier1Boss, List<Item> weaponsTier1, List<Item> armorTier1)
        {
            if (currentCharacter.CurrentHealthPoints <= 0)
            {
                return;
            }

            MobBattle(currentCharacter, tier1Creatures, tier1Boss, weaponsTier1, armorTier1);

            if (currentCharacter.CurrentHealthPoints <= 0)
            {
                return;
            }

            BossBattle(currentCharacter, tier1Creatures, tier1Boss, weaponsTier1, armorTier1);
        }

        // get command input from user
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
                    currentCharacter.HealCharacter();
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

        // mob combat
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

        // ends the game if health <= 0 and prints victory message if mob health <= 0
        private void SomeoneDied(ICharacters currentCharacter, ICreature currentCreature)
        {
            if (currentCharacter.CurrentHealthPoints <= 0)
            {
                Console.WriteLine("You have died! Game over! You Lose!");
            }

            if (currentCreature.CurrentHealthPoints <= 0)
            {
                Console.WriteLine("You defeated this mob!");
                currentCharacter.HasBuff = false;
                currentCharacter.HasShield = false;
            }
        }

        private void Recharge(ICharacters currentCharacter)
        {
            if (currentCharacter.CurrentMana + 7 <= currentCharacter.Mana)
            {
                currentCharacter.CurrentMana += 7;
            }
            else
            {
                currentCharacter.CurrentMana = currentCharacter.Mana;
            }
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

        // equip new armor and weapon
        private void Equip(Item currentWeapon, Item oldWeapon, ICharacters currentCharacter, string equipCommand)
        {
            if (equipCommand == "y")
            {
                if (currentCharacter.WeaponType == currentWeapon.Type || currentWeapon.Type == "all")
                {
                    RemoveCurrentItemStats(oldWeapon, currentCharacter);
                    AddNewItemStats(currentWeapon, currentCharacter);
                    oldWeapon = currentWeapon;
                }
                else
                {
                    Console.WriteLine("The item is not compatible with your class!");
                }
            }
            else if (equipCommand == "n")
            {
                Console.WriteLine("Item " + currentWeapon.Name + " successfully discarded!");
            }
            else
            {
                throw new Exception("Command not recognized! Game over!");
            }
        }

        // removes the stats of the current weapon
        private void RemoveCurrentItemStats(Item oldWeapon, ICharacters currentCharacter)
        {
            currentCharacter.HealthPoints -= oldWeapon.HpAdd;
            currentCharacter.Mana -= oldWeapon.ManaAdd;
            currentCharacter.Attack -= Convert.ToInt32(oldWeapon.AttackAdd);
            currentCharacter.Defence -= Convert.ToInt32(oldWeapon.DefenceAdd);
            currentCharacter.Speed -= oldWeapon.DefenceAdd;
        }

        // adds the stats of the new weapon
        private void AddNewItemStats(Item currentWeapon, ICharacters currentCharacter)
        {
            currentCharacter.HealthPoints += currentWeapon.HpAdd;
            currentCharacter.Mana += currentWeapon.ManaAdd;
            currentCharacter.Attack += Convert.ToInt32(currentWeapon.AttackAdd);
            currentCharacter.Defence += Convert.ToInt32(currentWeapon.DefenceAdd);
            currentCharacter.Speed += currentWeapon.SpeedAdd;

            Console.WriteLine("\n Item " + currentWeapon.Name + " successfully equipped!");
        }

        private void GettingEquipment(Item currentWeapon, Item currentArmor, Item oldWeapon, Item oldArmor, ICharacters currentCharacter)
        {
            Console.WriteLine("\nDo you want to equip the dropped weapon? This will discard your current weapon if you have one. y/n\n");
            string equipWeaponCommand = Console.ReadLine();
            Equip(currentWeapon, oldWeapon, currentCharacter, equipWeaponCommand);

            Console.WriteLine("\nDo you want to equip the dropped armor? This will discard your current armor if you have one. y/n\n");
            string equipArmorCommand = Console.ReadLine();
            Equip(currentArmor, oldArmor, currentCharacter, equipArmorCommand);
        }

        private static void GameOver()
        {
            Console.WriteLine("The game is over! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
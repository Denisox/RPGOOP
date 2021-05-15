using System;
using RPG_OOP.Classes;
using RPG_OOP.Weapon_Mastery;
using RPG_OOP.Interfaces;
using System.Collections.Generic;

namespace RPG_OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ICreature> newList = new List<ICreature>();

            newList.Add(new Pyromanser("Denko the great", 150, 50, 1.50, 500, 200));
            newList.Add(new Necromanser("Denko the second great", 130, 30, 1.25, 300, 100));
            newList.Add(new OneHandedSwordsman("Denis the one handed swords man", 200, 100, 1.50, 500, 50));
            newList.Add(new TwoHandedSwordsman("Denis the two handed swords man", 300, 200, 1.25, 700, 50));
            newList.Add(new Bowman("Denko the sniper", 250, 100, 1.75, 500, 30));

            foreach (ICreature var in newList)
            {
                Console.WriteLine($"Name: {var.Name}, Attack: {var.Attack}, Defence: {var.Defence}, Speed: {var.Speed}, HP: {var.HealthPoints}, Mana: {var.Mana}");
            }
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG;
using RPG.Interfaces;
using RPG.Classes;
using RPG.CharacterClasses;
using RPG.Weapon_Mastery;
using RPG.CharacterClasses.Weapon_Mastery;

namespace UnitTest
{
    [TestClass]
    public class AllUnitTests
    {
        [TestMethod]
        public void Damage()
        {
            var Arbalist = new Arbalist("name", 10, 0, 10, 10, 10);
            Arbalist.IncomingDamage = 5;
            Arbalist.GetDamage();
            Assert.AreEqual(5, Arbalist.CurrentHealthPoints);

        }
        [TestMethod]
        public void DamageWithDefence()
        {
          
            var Arbalist1 = new Arbalist("name", 10, 10, 10, 10, 10);
            Arbalist1.IncomingDamage = 9;
            Arbalist1.GetDamage();
            Assert.AreEqual(7, Arbalist1.CurrentHealthPoints);
            

        }
        [TestMethod]
        public void LethalDamage()
        {

            var Arbalist1 = new Arbalist("name", 10, 10, 10, 10, 10);
            Arbalist1.IncomingDamage = 60;
            Arbalist1.GetDamage();
            Assert.AreEqual(0, Arbalist1.CurrentHealthPoints);


        }
        [TestMethod]
        public void NormalAttack()
        {
            var Arbalist = new CharacterArbalist("name", 10, 10, 10, 10, 10);
            var Bowman = new Bowman("name", 10, 10, 10, 10, 10);
            Arbalist.NormalAttack(Bowman);
            Assert.AreEqual(12, Arbalist.OutgoingDamage);

        }
        [TestMethod]
        public void NormalAttackWithBuff()
        {
            var Arbalist = new CharacterArbalist("name", 10, 10, 10, 10, 10);
            var Bowman = new Bowman("name", 10, 10, 10, 10, 10);
            Arbalist.HasBuff = true;
            Arbalist.NormalAttack(Bowman);
            Assert.AreEqual(18, Arbalist.OutgoingDamage);

        }
        [TestMethod]
        public void EnoughManaForHeal()
        {
            var Arbalist = new CharacterArbalist("name", 10, 10, 10, 10, 50);
            var Bowman = new CharacterBowman("name", 10, 10, 10, 10, 0);
            
            Arbalist.HealCharacter(Bowman);
            Assert.AreEqual(30, Arbalist.CurrentMana);

        }
        [TestMethod]
        public void NotEnoughManaForHeal()
        {
            var Arbalist = new CharacterArbalist("name", 10, 10, 10, 10, 0);
            var Bowman = new CharacterBowman("name", 10, 10, 10, 10, 50);

            Arbalist.HealCharacter(Bowman);
            Assert.AreEqual(10, Bowman.HealthPoints);

        }
        [TestMethod]
        public void GetShield()
        {
            var Arbalist = new CharacterArbalist("name", 10, 10, 10, 10, 0);

            Arbalist.GetShield();
            Assert.IsTrue(Arbalist.HasShield);

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG;
using RPG.Interfaces;
using RPG.Classes;
using RPG.CharacterClasses;
using RPG.Weapon_Mastery;

namespace UnitTests
{
    [TestClass]
    public class Instances_Test
    {
        [TestMethod]
        public void BossInstanceTier1_CheckIfNotEmpty()
        {
            BossInstance tier1 = new BossInstance();
            Assert.IsNotNull(tier1.tier1Boss);
        }

        [TestMethod]
        public void BossInstanceTier2_CheckIfNotEmpty()
        {
            BossInstance tier2 = new BossInstance();
            Assert.IsNotNull(tier2.tier2Boss);
        }

        [TestMethod]
        public void BossInstanceTier3_CheckIfNotEmpty()
        {
            BossInstance tier3 = new BossInstance();
            Assert.IsNotNull(tier3.tier3Boss);
        }

        [TestMethod]
        public void Character1Instance_CheckIfNameIsNotEmpty()
        {
            CharactеrInstance char1 = new CharactеrInstance();
            var expected = "default";
            Assert.AreEqual(char1.character1.Name, expected);
        }

        [TestMethod]
        public void Character1Instance_CheckIfAttackIsNotZero()
        {
            CharactеrInstance char1 = new CharactеrInstance();
            var expected = 0;
            Assert.AreNotEqual(char1.character1.Attack, expected);
        }

        [TestMethod]
        public void Character1Instance_CheckIfDefenceIsNotZero()
        {
            CharactеrInstance char1 = new CharactеrInstance();
            var expected = 0;
            Assert.AreNotEqual(char1.character1.Defence, expected);
        }

        [TestMethod]
        public void Character1Instance_CheckIfSpeedIsNotZero()
        {
            CharactеrInstance char1 = new CharactеrInstance();
            var expected = 0;
            Assert.AreNotEqual(char1.character1.Speed, expected);
        }

        [TestMethod]
        public void Character1Instance_CheckIfHPIsNotZero()
        {
            CharactеrInstance char1 = new CharactеrInstance();
            var expected = "default";
            Assert.AreNotEqual(char1.character1.HealthPoints, expected);
        }

        [TestMethod]
        public void Character1Instance_CheckIfManaIsNotZero()
        {
            CharactеrInstance char1 = new CharactеrInstance();
            var expected = 0;
            Assert.AreNotEqual(char1.character1.Mana, expected);
        }
        [TestMethod]
        public void CharacterClass_CheckGetBuff()
        {
            Necromancer char1 = new Necromancer("default", 0 , 0, 0, 0, 0);
            char1.GetBuff();
            var expected = true;
            Assert.AreEqual(char1.HasBuff, expected);
        }

    }
}
using RPG.CharacterClasses.Weapon_Mastery;
using RPG.CharacterClasses;
using RPG.Interfaces;

namespace RPG
{
    public class CharactеrInstance
    {
        public ICharacters currentCharacter = null;

        public CharacterArcher character1 = new CharacterArbalist("default", 20, 12, 1.3, 225, 30);
        public CharacterArcher character2 = new CharacterBowman("default", 18, 8, 1.2, 168, 40);
        public CharacterKnight character3 = new CharacterOneHandedSwordsman("default", 18, 12, 1.3, 168, 50);
        public CharacterKnight character4 = new CharacterTwoHandedSwordsman("default", 23, 8, 1, 216, 60);
        public CharacterMage character5 = new CharacterPyromancer("default", 18, 11, 1.2, 156, 200);
        public CharacterMage character6 = new CharacterNecromancer("default", 14, 10, 1.25, 264, 220);
        public CharacterKnight character7 = new CharacterSpearman("default", 20, 12, 1.30, 180, 50);
    }
}
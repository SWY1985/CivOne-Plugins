using CivOne.Enums;

namespace CivOne.Units
{
    [Name("Warrior")]
    public class Warrior : UnitModification
    {
        public Warrior() : base(UnitType.Militia)
        {
            SetSprite("CivOne.Resources.Warrior.gif");
        }
    }
}
using CivOne.Enums;

namespace CivOne.Leaders
{
    [Name("Cleopatra")]
    [Aggression(AggressionLevel.Aggressive)]
    [Development(DevelopmentLevel.Perfectionist)]
    [Militarism(MilitarismLevel.Civilized)]
    public class Cleopatra : LeaderModification
    {
        public Cleopatra() : base(Leader.Ramesses)
        {
        }
    }
}
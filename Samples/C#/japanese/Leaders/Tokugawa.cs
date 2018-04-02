using CivOne.Enums;

namespace CivOne.Leaders
{
    [Name("Tokugawa")]
    [Aggression(AggressionLevel.Normal)]
    [Development(DevelopmentLevel.Expansionistic)]
    [Militarism(MilitarismLevel.Normal)]
    public class Tokugawa : LeaderModification
    {
        public Tokugawa() : base(Leader.Shaka)
        {
            SetPortrait("CivOne.Resources.Tokugawa.gif");
            SetPortraitSmall("CivOne.Resources.TokugawaSmall.gif");
        }
    }
}
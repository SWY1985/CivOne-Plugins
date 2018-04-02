using CivOne.Enums;

namespace CivOne.Civilizations
{
    [Name("Japanese", "Japanese")]
    [CityNames("Tokyo", "Kyoto", "Osaka", "Nagoya", "Yokohama", "Kobe", "Fukuoka", "Sendai", "Kanazawa", "Sapporo", "Matsuyama", "Akita", "Hiroshima", "Nagasaki", "Nara", "Kamakura")]
    [StartingPosition(73, 18)]
    public class Japanese : CivilizationModification
    {
        public Japanese() : base(Civilization.Zulus)
        {
        }
    }
}
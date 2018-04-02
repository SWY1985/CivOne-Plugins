namespace CivOne.Civilizations

open CivOne.Enums

[<Name("Chinese", "Chinese")>]
[<CityNames("Peking", "Shanghai", "Canton", "Nanking", "Tsingtao", "Hangchow", "Tientsin", "Tatung", "Macao", "Anyang", "Shantung", "Chinan", "Kaifeng", "Ningpo", "Paoting", "Yangchow")>]
[<StartingPosition(66, 19)>]
[<CivilizationLeader(Leader.Mao)>]
type Chinese() =
    inherit CivilizationModification(Civilization.Romans)
    
namespace CivOne.Civilizations

open CivOne.Enums

[<Name("Roman", "Romans")>]
[<CityNames("Rome", "Caesarea", "Carthage", "Nicopolis", "Byzantium", "Brundisium", "Syracuse", "Antioch", "Palmyra", "Cyrene", "Gordion", "Tyrus", "Jerusalem", "Seleucia", "Ravenna", "Artaxata")>]
[<StartingPosition(36, 19)>]
[<CivilizationLeader(Leader.Caesar)>]
type Romans() =
    inherit CivilizationModification(Civilization.Chinese)
    
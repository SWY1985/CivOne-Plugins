namespace CivOne

type Plugin() =

    member this.Name = (this :> IPlugin).Name
    member this.Author = (this :> IPlugin).Author
    member this.Version = (this :> IPlugin).Version

    interface IPlugin with
        member this.Name: string = "Swap Civilizations"
        member this.Author: string = "SWY1985"
        member this.Version: string = "0.1.0"
    
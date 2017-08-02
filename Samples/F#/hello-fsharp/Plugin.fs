namespace CivOne

open CivOne.Interfaces

type Plugin() =
    interface IPlugin with
        member this.Name: string = "Hello F#!"
        member this.Author: string = "SWY1985"
        member this.Version: string = "0.1.0"
    
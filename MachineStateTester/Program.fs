// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open AssertionParser

[<EntryPoint>]
let main argv = 
    test assertionParser "assert file \"c:\\temp.text\" exists" |> ignore
    test assertionParser "assert directory \"c:\\temp\" exists" |> ignore

    printfn "Press Any Key to Continue"
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
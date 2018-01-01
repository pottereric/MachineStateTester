module AssertionParser

open FParsec
open AssertionTypes


let fileAssertionParser = stringCIReturn "file" {
    kind = AssertionKind.File; target = ""; action = AssertionAction.Exists}

let directoryAssertionParser = stringCIReturn "directory" {
    kind = AssertionKind.Directory; target = ""; action = AssertionAction.Exists}

let assertionParser = pstring "assert " >>. (fileAssertionParser <|> directoryAssertionParser)

let test p str =
    match run p str with
    | Success(result, _, _)   -> printfn "Success: %A" result
    | Failure(errorMsg, _, _) -> printfn "Failure: %s" errorMsg

let testIgnore p str =
    match run p str with
    | Success(result, _, _)   -> ignore
    | Failure(errorMsg, _, _) -> ignore

testIgnore assertionParser "" |> ignore
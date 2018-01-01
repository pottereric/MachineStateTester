module AssertionTypes

type AssertionKind = 
    File
    | Directory

type AssertionAction =
    Exists
    | Absent

type Assertion = {
    kind : AssertionKind
    target : string
    action : AssertionAction
    }

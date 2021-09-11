open System

let pigLatin (input : string) =
    let isVowel ch =
        match ch with 
        | 'a' | 'e' | 'i' | 'o' | 'u'
        | 'A' | 'E' | 'I' | 'O' | 'u' -> true 
        | _ -> false

    if isVowel input.[0] then
        input + "yay"
    else
        input.[1..] + string(input.[0]) + "ay"

[<EntryPoint>]
let main argv =
    if argv.Length <> 2 then
        printfn "You need to enter two arguments!"
        1
    else
        let input = argv.[0]
        printfn "Hello, %s! Your string in pig latin is %s" argv.[0] (pigLatin argv.[1]) 
        0 // Return code.

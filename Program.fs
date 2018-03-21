// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let result1 = FSharp.Math.square (2)
    let result1 = FSharp.Math.division (2,0)
    printfn "O resultado é %d" result1
    0 // return an integer exit code
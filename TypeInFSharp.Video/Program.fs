// For more information see https://aka.ms/fsharp-console-apps

let a = (
    let b = true
    let by = 255uy
    let sby = -128y
    let i16 = -32768s
    let ui16 = 65535us
    let i32 = -2147483648
    let ui32 = 4294967295u
    let i64 = -9223372036854775808L
    let ui64 = 18446744073709551615UL
    let ptr = nativeint 1
    let uptr = unativeint 1
    let dec = 1.0m
    let flt = 1.0f
    let dbl = 1.0
    let chr = 'a'
    let str = "abc"
    let unit = ()
    1
)

let array1 = [| 1; 3 |]
let list1 = [ 1; 3 ]

array1.[0] <- 2
// list1.[0] <- 2
let list2 = list1 |> List.append [ 2 ]
printfn "%A" list2
let list3 = list1 @ [ 2; 3 ]
let list4 = 2 :: list1

let seq1 = seq {1; 2}
printfn "%A" (seq1 |> Seq.toList)
let seq2 = seq{ 1..10..100 }
printfn "%A" (seq2 |> Seq.toList)
let seq3 = seq{ for i in 1..10 -> i }
printfn "%A" (seq3 |> Seq.toList)

let seq4 = seq{ for i in 1..10 do yield! seq {1;2} }
printfn "%A" (seq4 |> Seq.toList)

let seq5 = Seq.init 10 (fun i -> i)
printfn "%A" (seq5)

let seq6 = Seq.initInfinite (fun i -> i)
printfn "%A" (seq6 |> Seq.take 50 |> Seq.toList)
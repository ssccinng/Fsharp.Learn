// For more information see https://aka.ms/fsharp-console-apps
type Class(a) =
    member _.a = a
    member this.b = 1
    member val c = 1
    new() = Class(0)
    

let a = Class()



type Record = { A: int
                B1: int }
type RecordB = {B: int
                A: Record}

(
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
    ()
)
let R = {A = 2; B1 = 3}
let BR = {B = 3; A = R}
let BAnon = {| B = 1 |}
let C = Class()

let c = 1, 2

let d = fst c


let a1 = [|1; 2; 3|] 
let a2 = 
    [|1
      2
      3|]
a2.[0] <- 2

//使用[| |]定义数组, 请注意使用；或者换行分隔数组元素
//否则会认为是一个元组的元素的数组

let se = [1, 2]
let l1 = [1; 2] 
// 同样的，使用[;]定义列表,
let l2 = l1 @ [3; 4]
// 使用@连接两个列表
let l3 = 1 :: l2

// 使用::添加元素到列表头部 
let s1 = seq { 0..10..100 }
// 使用序列表达式生成序列
let s2 = seq { for i in 0..10 -> i + 1 }
// 使用for循环->生成序列
let s3 = seq {
    for i in 0..10 do
        yield i + 1
}
// 通过yield关键字生成序列

let s4 = seq {
    for i in 0..10 do
        yield! seq {1; 2; 3; 4}
}
// 使用yield!关键字生成平铺后的序列

printfn "%A" (s1 |> Seq.toList)
printfn "%A" (s2 |> Seq.toList)
printfn "%A" (s3 |> Seq.toList)
printfn "%A" (s4 |> Seq.toList)
// 因为序列是惰性的，所以需要使用Seq.toList将序列转换为列表

let m1 = Map.ofList [(1, "a"); (2, "b")]
let m2 = m1 |> Map.add 3 "c"
let set1 = Set.ofList [1; 2; 3]
let set2 = Set.add 4 set1



let se3 = seq {1}

type Point = { X: float; Y: float; Z: float } // 定义一个Point的记录类型
let mypoint3D = { X = 1.0; Y = 1.0; Z = 0.0 } // 通过记录表达式创建一个Point类型的值
// type Point3D = { X: float; Y: float; Z: float }
// Ambiguity: Point or Point3D?

type Address = 
| Email of string
| Phone of string
| QQ of int

let sendMessage addr msg = 
    match addr with
    | Email email -> printfn "Send email to %s: %s" email msg
    | Phone phone -> printfn "Send message to %s: %s" phone msg
    | QQ qq -> printfn "Send message to %d: %s" qq msg
    
    

type Maybe<'a> = 
| Just of 'a
| Nothing

type Option<'a> =
| Some of 'a
| None




    

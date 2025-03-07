// For more information see https://aka.ms/fsharp-console-apps
type test =
    | AA of int
    | BB
// [<RequireQualifiedAccess>]
type Shape =
    | Rectangle of width : float * length  : float
    | Circle of radius : float
    | Prism of width : float * float * height : float
    
let getShapeWidth shape =
    match shape with
    | Rectangle(width = w) -> w
    | Circle(radius = r) -> 2. * r
    | Prism(width = w) -> w
let prism = Prism( 5., 2.0, height = 3.0)
printfn $"%A{prism}"

type AA1 = | A of int
let a = A 1
let rect = Rectangle(length = 1.3, width = 10.0)
let (A (a1)) = a
let a4 = a1

let re = Rectangle(width = 1.1, length = 1.4)
let prism1 = Prism(5., 2.0, 3.0)

type Expr =
    | Number of int
    | Add of Expr * Expr
    | Subtract of Expr * Expr
    | Multiply of Expr * Expr
    | Divide of Expr * Expr
    
let a = Add (Number 1, Number 3)

type OrderStatus =
    | Pending
    | Paid of paymentId: string
    | Shipped of trackingNumber: string
    | Delivered
    
let v = Paid "!@"

let printOrderStatus status =
    match status with
    | Pending -> printfn "Order is pending"
    | Paid paymentId1 -> printfn "Order paid with ID: %s" paymentId1
    | Shipped trackingNumber -> printfn "Order shipped with tracking: %s" trackingNumber
    | Delivered -> printfn "Order delivered"

printOrderStatus v


type MaybeBuilder() =
    member this.Bind(x, f) =  x |> Option.bind f
    member this.Return(x) = Some x

let maybe = MaybeBuilder()

let example x y =
    maybe {
        let! a = Some x
        let! b = Some y
        return a + b
    }
type Shape =
    | Rectangle of width: float * height: float
    | Circle of radius: float
    | Prism of width: float * float * height: float
    
let rect = Rectangle(3.5, height = 2.0)
let getShapeSize = function
    | Rectangle(width, length) -> width * length
    | Circle(radius) -> 3.14 * radius * radius
    | Prism(width, length, height) -> width * length * height
let getShapeWidth = function
    | Rectangle(width = w) -> w
    | Circle(radius = r) -> 2. * r
    | Prism(width = w) -> w
    
printfn "%A" (getShapeSize rect)
let circle = Circle(5)
// let flag = circle.IsCircle
printfn "%A" (getShapeWidth circle)

// type Any = | A of Any
type List<'a> = | Cons of 'a * List<'a> | Empty

type Tree<'a> = | Leaf of 'a | Node of 'a * Tree<'a> * Tree<'a>
// [<Struct>]
type Expr =
    | Number of int
    | Add of Expr * Expr
    | Subtract of Expr * Expr
    | Multiply of Expr * Expr
    | Divide of Expr * Expr
let a = Subtract (Add (Number 1, Number 3) , Multiply (Number 2, Number 3))
// (1 + 3) - (2 * 3)

let calc expr =
    () // 课后作业

type File =
    | File of string * int
and Folder =
    | Folder of string * (FolderOrFile list)
and FolderOrFile = 
    | FolderItem of Folder
    | FileItem of File

type MaybeSize = | Size of float | NoSize

let getShapeSize2 = function
    | Prism(w,l,h) -> NoSize
    | Rectangle(w,h) -> Size (w * h)
    | Circle r -> Size (r * r * 3.14159)
type Maybe<'a> = | Just of 'a | Nothing

type Option<'a> = | Some of 'a | None

type Person = {Name: string; Age: int option}

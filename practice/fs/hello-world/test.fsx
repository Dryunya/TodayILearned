//lists
let firstList = [ 1; 2; 3; 4; 5 ]
let secondList = 0 :: firstList
let anotherList = [ -2; -1 ] @ secondList

//functions
let Square x = x * x

let GetEvens list =
    let isEven x = x % 2 = 0
    List.filter isEven list

let PipedOperations list =
    list
    |> List.map (fun x -> x * 3)
    |> GetEvens    
    |> List.sum

PipedOperations anotherList

let simplePatternMatch x =
   let a = x % 2
   match a with
    | 0 -> 10
    | 1 -> 20
    | _ -> 30

let mapInAction = List.map simplePatternMatch firstList

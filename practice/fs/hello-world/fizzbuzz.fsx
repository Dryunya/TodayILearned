let isDivisibleBy n divisor = (n % divisor) = 0

type CarbonatedResult =
    | Carbonated of string
    | Uncarbonated of int

let carbonate divisor label n =
    if(isDivisibleBy n divisor) then
        Carbonated label
    else
        Uncarbonated n

let bind nextFunction result =
    match result with
    | Carbonated str ->
        Carbonated str
    | Uncarbonated n ->
        nextFunction n

let carbonateRemaining result =
    match result with
    | Carbonated str ->
        str
    | Uncarbonated n ->
        string(n)

let fizzBuzz n =
    n
    |> carbonate 15 "FizzBuzz"
    |> bind (carbonate 3 "Fizz")
    |> bind (carbonate 5 "Buzz")
    |> carbonateRemaining

let fizzBuzzN n =
    [1..n]
    |> List.map fizzBuzz
    |> List.iter (printf "%s, ")


printf "\n ----- Start ------ \n\n"
fizzBuzzN 40
printf "\n\n ----- Finish ----- \n\n"

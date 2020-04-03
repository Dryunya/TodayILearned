open System

let replace (oldValue: String) (newValue: String) (inputStr: String) = inputStr.Replace(oldValue, newValue)

let replicatei num = String.replicate num "I"

let convertToRoman num = 
    replicatei num
    |> replace "IIIII" "V"
    |> replace "VV" "X"
    |> replace "XXXXX" "L"
    |> replace "LL" "C"
    |> replace "CCCCC" "D"
    |> replace "DD" "M"
    |> replace "VIIII" "IX"
    |> replace "IIII" "IV"
    |> replace "LXXXX" "XC"

let num = 14
let romanNum = convertToRoman num
printf "\n\n %i -> %s \n\n" num romanNum

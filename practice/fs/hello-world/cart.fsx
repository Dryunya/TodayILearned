// =============================
// Domain model
// =============================

type CartItem = string

type EmptyState = NoItems

type ActiveState =
    { UnpaidItems: CartItem list }

type PaidForState =
    { PaidItems: CartItem list
      Payment: decimal }

type Cart =
    | Empty of EmptyState
    | Active of ActiveState
    | PaidFor of PaidForState

// =============================
// operations on empty state
// =============================

let addToEmptyState item = Cart.Active { UnpaidItems = [ item ] }

// =============================
// operations on active state
// =============================

let addToActiveState state item =
    let newList = item :: state.UnpaidItems
    Cart.Active { state with UnpaidItems = newList }

let removeFromActiveState state item =
    let newList = state.UnpaidItems |> List.filter ( fun i -> i <> item )

    match newList with
        | [] -> Cart.Empty NoItems
        | _ -> Cart.Active { state with UnpaidItems = newList }

let payForActiveState state amount =
    Cart.PaidFor { PaidItems = state.UnpaidItems; Payment = amount }

// =============================
// operations
// =============================

type EmptyState with
   member this.Add = addToEmptyState

type ActiveState with
   member this.Add = addToActiveState this 
   member this.Remove = removeFromActiveState this 
   member this.Pay = payForActiveState this


let addItemToCart cart item =  
   match cart with
   | Empty state -> state.Add item
   | Active state -> state.Add item
   | PaidFor state ->  
       printfn "ERROR: The cart is paid for"
       cart   

let removeItemFromCart cart item =  
   match cart with
   | Empty state -> 
      printfn "ERROR: The cart is empty"
      cart   // return the cart 
   | Active state -> 
      state.Remove item
   | PaidFor state ->  
      printfn "ERROR: The cart is paid for"
      cart   // return the cart

let displayCart cart  =  
   match cart with
   | Empty state -> 
      printfn "The cart is empty"   // can't do state.Items
   | Active state -> 
      printfn "The cart contains %A unpaid items"
                                                state.UnpaidItems
   | PaidFor state ->  
      printfn "The cart contains %A paid items. Amount paid: %f"
                                    state.PaidItems state.Payment

type Cart with
   static member NewCart = Cart.Empty NoItems
   member this.Add = addItemToCart this 
   member this.Remove = removeItemFromCart this 
   member this.Display = displayCart this 

 //------------------

printf "\n---------result--------\n\n"

let emptyCart = Cart.NewCart
printf "emptyCart="; emptyCart.Display

let cartA = emptyCart.Add "A"
printf "cartA="; cartA.Display

let cartAB = cartA.Add "B"
printf "cartAB="; cartAB.Display

let cartB = cartAB.Remove "A"
printf "cartB="; cartB.Display

let emptyCart2 = cartB.Remove "B"
printf "emptyCart2="; emptyCart2.Display

printf "\n------------------------\n"
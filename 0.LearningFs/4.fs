(* 
   Function
   F# is a functional programming language, so function is regarded as data type, 
   also can be handled as first class citizen.
*)

let some_var = 3

// You can define function like mathematical expression
// without arguments
let some_function = 
  // Function body
  some_var + 1  // this function returns 4
  
// with arguments
let some_function_2 arg1 arg2 arg3 arg4 =
  arg1 + arg2 + arg3 + arg4  // this function returns sum of its arguments

// strong typed arguments, return type
let some_function_3 (arg1:int) (arg2:int) (arg3:int) (arg4:int) : int =
  arg1 + arg2 + arg3 + arg4  // same as some_funciton_2, but int only


printfn "%f" ( some_function_2 2.0f 3.0f 4.2f 5.3f) // prints 14.500000
printfn "%f" ( some_function_3 2.0f 3.0f 4.2f 5.3f) // oops, error. float32 cannot be argument of some_function_3
printfn "%d" ( some_function_3 1 2 3 4)             // prints 10


// for recursion, add "rec" keyword
let rec sum x:uint32 =
  if x = 0 then 0
  else x + (sum x-1)
 
printfn "%u" (sum 5)


// the type of function is described with arrow notation.
let some_function_4 (x:int) (y:float) =
  "some_string_data" 
// then the type is int -> float -> string.
// let's use lambda with function gets func argument.

let fun_fun (f: int -> int) x = f (x * x)
let lmb_fun = fun_fun (fun _x -> _x + 1) 4

printfn "%i" lmb_fun // prints 17

// functions can be composed with operator >> (not RSH, RSH is >>>)
let comp_a x = x + 1
let comp_b x = x * x
let abfun = comp_a >> comp_b

printfn "%i" (abfun 3) // prints 16

// also being chained via pipelining
let _double x = x * 2
let _triple x = x * 3
let result = 3 |> _double |> _triple

printfn "%i" result // prints 18

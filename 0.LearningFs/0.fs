(*
    This is a preparation for SICPwFS project, I have no F# skills.
    So I decided to learn basics briefly.
    
    Referred tutorialspoint.com, F# Basic Tutorial.
    https://www.tutorialspoint.com/fsharp/index.htm
*)

// to use .NET features, use open
open System //; F# does not put semicolon to the end of line.

let somefunc x =
  x + 3 // to return a value, just write the value what you want to return.

let main() = 
  // .NET featrues can be used in F#
  Console.WriteLine("Hello Functional Programming!, {0}", (somefunc))

main()

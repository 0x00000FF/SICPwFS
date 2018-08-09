// Referred tutorialspoint.com, F# Basic Tutorial.

open System //; F# does not put semicolon to the end of line.

let somefunc =
  3 // to return value, just write the value what you want to return.

let main() = 
  // .NET featrues can be used in F#
  Console.WriteLine("Hello Functional Programming!, {0}", (somefunc))

main()

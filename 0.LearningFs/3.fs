// Decision Making(Branching), Loop
// F# supports branching statements, such as if, elif, else, etc.

let simpleif arg =
  if arg = "Hello" then
    printfn "Hello There!"
    
simpleif "Hello"               // Hello There!
simpleif "Good Morning!"       // <nothing>

let ifelse arg = 
  if arg = 0 then
    printfn "arg is zero"
  else
    printfn "arg is not zero"
    
ifelse 3 // arg is not zero
ifelse 0 // arg is zero

let ifelif arg =
  if arg < 1 then
    printfn "%i" (10 - arg)
  elif ( arg < 5 && arg >= 1 ) then
    printfn "%i" (10 + arg)
  else
    printfn "Too big!"

ifelif -1 // 11
ifelif 2  // 12
ifelif 6  // Too big!


// F# supports for-to and for-downto statement.

let sum100 = 
  let mutable sum = 0
  for i = 1 to 100 do // same as for(var i = 1; i <= 100; ++i) in C#
    sum <- sum + i
  sum

printfn "%i" sum100 // 5050

let down5 =
  for i = 5 downto 1 do
    printfn "%i" i

down5 // 5 4 3 2 1 (line breaks on each blank)

// Of course, while-do is available too!

let whiledo arg =
  let mutable _arg = arg
  while ( _arg <> 0 ) do
    printfn "arg is not zero!! retrying..."
    
    // check _arg is negative or not
    if _arg < 0 then 
      _arg <- _arg + 1
    else
      _arg <- _arg - 1
      
  printfn "OKAY!"

whiledo 3 // prints OKAY after 3 times of retry
whiledo 0 // OKAY!






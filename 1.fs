(*

  1.1
    This question provides scheme codes, Requires student to guess which value will be printed on interpreter. 

    10  // prints 10

    (+ 5 3 4) // prints 12

    (- 9 1) // prints 8

    (/ 6 2) // prints 3

    (+ (* 2 4) (- 4 6)) // prints 6
    
    (define a 3)
    
    (define b (+ a 1))
    
    (+ a b (* a b)) // prints 19
    
    (= a b) // #f
    
    (if (and (> b a) (< b (* a b)))
        b
        a) // prints 4
        
    (cond ((=a 4) 6)
          ((=b 4) (+ 6 7 a))
          (else 25)) // prints 16
    
    (+ 2 (if (> b a) b a)) // prints 6
    
    (* (cond ((> a b) a)
             ((< a b) b)
             (else -1))
       (+ a 1)) // prints 16

   ----
   
   1.2 Pass (Change given expression to prefix notation)
   
   Of course, I did.
   
   ----
*)

// 1.3
// has many flaws, need to be revised
let exp_and_add x y z =
  if (x > y && x > z) then
    if y > z then
      x ** y + z
    else
      x ** z + y
  elif (y > x && y > z) then
    if x > z then
      y ** x + z
    else
      y ** z + x
  elif (z > x && z > y) then
    if x > y then
      z ** x + y
    else
      z ** y + x
      
(*

1.4
  for the procedure
    (define (a-plus-abs-b a b)
      ((if (< b 0) + -) a b))
  
  let the arguments a=3, b=4. then
  
  (a-plus-abs-b 3 4)
  
  b is positive, so the operator should be +, therefore the procedure will return 7.
  
  In other case, let a=4, b=-1. then
  
  (a-plus-abs-b 4 -1)
  
  b is negative, so the operator should be -, therefore the procedure will return 5.

*)



// Variables and Operators

// You can declare strong-typed variables with colon.
let _strong_type_int    :int     = 3
let _strong_type_float32:float32 = 3.0F

// Variable names can be combined with operators.
let a:int = 3
let b:int = 4
let c = a + b // c is 7

// Variables cannot be declared duplicately
let a:int = 6 // Not possible

// Variables are immutable, which means once variable is bound to value, it cannot be changed.
// Thus, this sentence below is not possible.
a <- 7 

// ... unless it is declared as mutable.
let mutable k = 4
k <- 5 // k is 5 now.

// Arithmetic operators are same as C# one.
let _add_a = 3
let _add_b = 4
let _add_c = _add_a + _add_b // _add_c is 7

let _sub_a = 10
let _sub_b = 2
let _sub_c = _sub_a + _sub_b // _sub_c is 8

let _mul_a = 5
let _mul_b = 4
let _mul_c = _mul_a * _mul_b // _mul_c is 20

let _div_a = 10
let _div_b = 2
let _div_c = _div_a / _div_b // _div_c is 5

let _mod_a = 5
let _mod_b = 2
let _mod_c = _mod_a % _mod_b // _mod_c is 1

// F# can use exponential operator unlike C#.
// exponential operator supports floating point type only.
let _exp_a = 2.0f
let _exp_b = 5.0f
let _exp_c = _exp_a ** _exp_b // _exp_c is 32.0f

// Comparison operators
let _cmp_a = 10
let _cmp_b = 5

let _equals      = (_cmp_a =  _cmp_b) // false
let _not_equals  = (_cmp_a <> _cmp_b) // true
let _bigger      = (_cmp_a >  _cmp_b) // true
let _lesser      = (_cmp_a <  _cmp_b) // false

let _cmp_c = 5

let _eq_or_bigr  = (_cmp_b >= _cmp_c) // true
let _eq_or_less  = (_cmp_b <= _cmp_a) // true

// Boolean operators
let _bool_a   = true
let _bool_b   = false
let _bool_and = ( _bool_a && _bool_b ) // false
let _bool_or  = ( _bool_a || _bool_b ) // true
let _bool_not = not _bool_b            // true

// Bitwise operators are available
// &&& : bitwise AND
// ||| : bitwise OR
// ^^^ : bitwise XOR
// ~~~ : complement
// <<< : LSH
// >>> : RSH

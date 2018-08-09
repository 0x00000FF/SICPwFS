// Date types of F#

// You can declare variable as like function.
// number literal 3 is regarded as int32.
let _var = 3

// Other integer type literals have suffix.
let _signed_int8    = 3y
let _unsigned_int8  = 3uy
let _signed_int16   = 3s
let _unsigned_int16 = 3us
let _signed_int32   = 3
let _unsigned_int32 = 3u
let _signed_int64   = 3L
let _unsigned_int64 = 3UL
let _bigint         = 3I

// For 32bit floating point data types, add suffix F
let _float_32       = 1.2f
let _float_64       = 1.2     // Double in other language, but in F#, it is called just "float".

// Decimal (128bit), Rational (at least 32bit)
let _decimal        = 3M
let _decimal_neg    = -3M

// Rational requires reference FSharp.PowerPack.dll
let _rational       = 3N
let _rational_neg   = -3N

// Char and String is same as C#.
// String has unicode characters, and 20bytes overhead. 2 bytes of memory is allocated for each character. 
let _char           = 'A'
let _string         = "Hello!"

// Boolean type (8 bit)
let _bool           = true


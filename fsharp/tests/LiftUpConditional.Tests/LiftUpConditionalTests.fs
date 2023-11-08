module LiftUpConditionalTests

open Xunit
open LiftUpConditional

[<Theory>]
[<InlineData(true, true)>]
[<InlineData(true, false)>]
[<InlineData(false, true)>]
[<InlineData(false, false)>]
let ``Give a and b value as string`` a b =
    (Kata.liftUpConditional a b) = $"A{a}B{b}"

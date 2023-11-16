Demo code for Lift-Up Conditional Introduction learning hour
============================================================

Those code examples in different language are companion code for the [Lift-Up Conditional introduction](https://www.sammancoaching.org/learning_hours/refactoring/lift_up_conditional_intro.html) learning hour.

## How to use this example

During the concept part 2, you can use this code to demonstrate the Lift-Up conditional technique to move the ```if(b)``` condition at the beginning of the function.

### Example in OCaml

Initial code 

```OCaml
let liftUpConditional a b =
  if a then 
    if b then 
        "ATrueBTrue"
    else
        "ATrueBFalse"
  else
    if b then 
        "AFalseBTrue"
    else
        "AFalseBFalse"
```

should be safely transformed like this with the Lift-Up conditional technique.

```OCaml
let liftUpConditional a b =
  if b then 
    if a then 
        "ATrueBTrue"
    else
        "AFalseBTrue"
  else
    if a then 
        "ATrueBFalse"
    else
        "AFalseBFalse"
```

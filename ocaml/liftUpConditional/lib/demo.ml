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
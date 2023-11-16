let boolStringCapitalized b =
  b |> string_of_bool |> String.capitalize_ascii

let expectedString a b = 
  "A"^boolStringCapitalized a^"B"^boolStringCapitalized b

let test a b () =
  Alcotest.(check string) "Matching string" (expectedString a b) (Demo.liftUpConditional a b)

let () =
  let open Alcotest in
  run "Demo" [
      "liftUpConditional", [
          test_case "A true B true"     `Quick (test true true);
          test_case "A true B false"    `Quick (test true false);
          test_case "A false B true"    `Quick (test false true);
          test_case "A false B false"    `Quick (test false false);
      ];
  ]
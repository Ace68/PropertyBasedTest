module CalculatorFunctionTest.CalculatorFunctionalTestRefactored

open CalculatorFunctional.CalculatorLibrary
open NUnit.Framework

// Generating 100 pairs of random ints.
// The property parameter will be a function that takes two ints and returns a bool
let propertyCheck property =
  // property has type: int -> int -> bool
  for _ in [1..100] do
    let x = randInt()
    let y = randInt()
    let result = property x y
    Assert.That(result, Is.True)

let commutativeProperty x y =
  let result1 = add x y
  let result2 = add y x // reversed params
  result1 = result2
  
[<Test>]
let addDoesNotDependOnParameterOrder() =
  Assert.That(propertyCheck, Is.EqualTo(commutativeProperty))

let add1TwiceIsAdd2Property x _ =
  let result1 = x |> add 1 |> add 1
  let result2 = x |> add 2
  result1 = result2

[<Test>]
let addOneTwiceIsSameAsAddTwo() =
  Assert.That(propertyCheck, Is.EqualTo(add1TwiceIsAdd2Property))

let identityProperty x _ =
  let result1 = x |> add 0
  result1 = x

[<Test>]
let addZeroIsSameAsDoingNothing() =
  Assert.That(propertyCheck, Is.EqualTo(identityProperty))
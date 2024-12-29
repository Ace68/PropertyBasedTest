module CalculatorFunctionTestRefactored

open CalculatorFunctional.CalculatorLibrary
open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

// The EDFH (Enterprise Developer From Hell) pattern
[<Test>]
let ``Add two numbers, expect their sum``() =
    let testData = [ (1,2,3); (2,2,4); (3,5,8); (27,15,42) ]
    for (x,y,expected) in testData do
        let actual = add x y
        Assert.That(actual, Is.EqualTo(expected))
        
// A generic test to add two random numbers
[<Test>]
let ``Add two random numbers, expect their sum``() =
  let x = randInt()
  let y = randInt()
  let expected = x + y
  let actual = add x y
  Assert.That(actual, Is.EqualTo(expected))
  
// Commutative property of addition
// It doesn’t depend on addition itself, but it does eliminate a whole class of incorrect implementations.
[<Test>]
let addDoesNotDependOnParameterOrder() =
  for _ in [1..100] do
    let x = randInt()
    let y = randInt()
    let result1 = add x y
    let result2 = add y x // reversed params
    Assert.That(result1, Is.EqualTo(result2))
    
// So now what about the difference between add and multiply? What does addition really mean?
// But now we are assuming the existence of multiplication!
[<Test>]
let ``Add a number to itself or Multiply a number by 2, expect their equal``() =
    let x = randInt()
    let result1 = add x x
    let result2 = x * 2
    Assert.That(result1, Is.EqualTo(result2))
    
// That’s great! add works perfectly with this test, while multiply doesn’t.
[<Test>]
let addOneTwiceIsSameAsAddTwo() =
  for _ in [1..100] do
    let x = randInt()
    let result1 = x |> add 1 |> add 1
    let result2 = x |> add 2
    Assert.That(result1, Is.EqualTo(result2))

// What happens when you add zero to a number? You always get the same number back.
[<Test>]
let addZeroIsSameAsDoingNothing() =
  for _ in [1..100] do
    let x = randInt()
    let result1 = x |> add 0
    let result2 = x
    Assert.That(result1, Is.EqualTo(result2))

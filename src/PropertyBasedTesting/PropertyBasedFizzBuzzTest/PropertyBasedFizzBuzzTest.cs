using FsCheck;
using FsCheck.Xunit;

namespace PropertyBasedFizzBuzzTest;

/// <summary>
/// Properties for FizzBuzz
/// The multiples of three should be replaced with "Fizz"
/// The multiples of five should be replaced with "Buzz"
/// The multiples of three and five should be replaced with "FizzBuzz"
/// The non multiples of three or five should be replaced with the number itself
/// </summary>
public class PropertyBasedFizzBuzzTest
{
    [Property(Arbitrary = [typeof(RandomMultipleOfThreeGenerator)])]
    public Property MultiplesOfThreeShouldBeReplacedWithFizz(int numberToCheck)
    {
        return FizzBuzz.FizzBuzz.ChkNumber(numberToCheck).Contains("Fizz").ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomMultipleOfFiveGenerator)])]
    public Property MultiplesOfFiveShouldBeReplacedWithBuzz(int numberToCheck)
    {
        return FizzBuzz.FizzBuzz.ChkNumber(numberToCheck).Contains("Buzz").ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomMultipleOfThreeAndFiveGenerator)])]
    public Property MultiplesOfThreeAndFiveShouldBeReplacedWithFizzBuzz(int numberToCheck)
    {
        return FizzBuzz.FizzBuzz.ChkNumber(numberToCheck).Contains("FizzBuzz").ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomNonMultipleOfThreeOrFiveGenerator)])]
    public Property NonMultiplesOfThreeAndFiveShouldBeReplacedWithTheNumberItself(int numberToCheck)
    {
        return FizzBuzz.FizzBuzz.ChkNumber(numberToCheck).Equals(numberToCheck.ToString()).ToProperty();
    }
}
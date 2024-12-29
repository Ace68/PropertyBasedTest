namespace ExampleBasedFizzBuzzTest;

public class ExampleBasedFizzBuzzTest
{
    [Fact]
    public void Verify_Number_IsFizz()
    {
        var numberToVerify = 6;

        Assert.Equal("Fizz", FizzBuzz.FizzBuzz.ChkNumber(numberToVerify));
    }

    [Fact]
    public void Verify_Number_IsBuzz()
    {
        var numberToVerify = 5;

        Assert.Equal("Buzz", FizzBuzz.FizzBuzz.ChkNumber(numberToVerify));
    }

    [Fact]
    public void Verify_Number_IsFizzBuzz()
    {
        var numberToVerify = 15;

        Assert.Equal("FizzBuzz",FizzBuzz.FizzBuzz.ChkNumber(numberToVerify));
    }

    [Fact]
    public void Verify_Number_IsNotFizzBuzz()
    {
        var numberToVerify = 7;

        Assert.Equal(FizzBuzz.FizzBuzz.ChkNumber(numberToVerify), numberToVerify.ToString("N"));
    }

    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(7, ".NetPordenone")]
    [InlineData(8, "8.00")]
    public void Verify_ChkFizzBuzz_With_Combinations(int numberToVerify, string stringExpected)
    {
        var combinations = new List<Tuple<int, string>>
        {
            new (3, "Fizz"),
            new (5, "Buzz"),
            new (7, ".NetPordenone"),
        };

        Assert.Equal(stringExpected,FizzBuzz.FizzBuzz.ChkFizzBuzz(combinations, numberToVerify));
    }
}
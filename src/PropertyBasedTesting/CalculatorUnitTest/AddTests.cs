using Calculator;
namespace CalculatorUnitTest;

public class AddTests
{
    [Theory]
    [InlineData(4, 5)]
    [InlineData(3, 2)]
    public void Can_Add_Respect_The_Commutative_Property(int number1, int number2)
    {
        var result1 = Calculator.Calculator.Add(number1, number2);
        var result2 = Calculator.Calculator.Add(number2, number1);
        
        Assert.Equal(result1, result2);
    }
    
    [Theory]
    [InlineData(4, 5, 6)]
    [InlineData(3, 2, 1)]
    public void Can_Add_Respect_The_Associative_Property(int number1, int number2, int number3)
    {
        var result1 = Calculator.Calculator.Add(Calculator.Calculator.Add(number1, number2), number3);
        var result2 = Calculator.Calculator.Add(number2, Calculator.Calculator.Add(number1, number3));
        
        Assert.Equal(result1, result2);
    }
    
    [Theory]
    [InlineData(4)]
    [InlineData(3)]
    public void Can_Add_Respect_The_Identity_Property(int number)
    {
        var result = Calculator.Calculator.Add(number, 0);
        
        Assert.Equal(number, result);
    }
}
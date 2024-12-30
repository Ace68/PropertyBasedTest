using FsCheck;
using FsCheck.Xunit;

namespace CalculatorUnitTest;

/// <summary>
/// Properties for Add
/// Commutative: a + b = b + a
/// Associative: a + (b + c) = (a + b) + c
/// Identity: a + 0 = a
/// </summary>
public class PropertyBasedTestCalculator
{
    [Property(Arbitrary = [typeof(RandomNumberGenerator)])]
    public Property AddRespectsCommutativityProperty(int firstNumber, int secondNumber)
    {
        return (Calculator.Calculator.Add(firstNumber, secondNumber) == Calculator.Calculator.Add(secondNumber, firstNumber)).ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomNumberGenerator)])]
    public Property AddRespectsAssociativityProperty(int firstNumber, int secondNumber, int thirdNumber)
    {
        return (Calculator.Calculator.Add(firstNumber, Calculator.Calculator.Add(secondNumber, thirdNumber)) == Calculator.Calculator.Add(Calculator.Calculator.Add(firstNumber, secondNumber), thirdNumber)).ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomNumberGenerator)])]
    public Property AddRespectsIdentityProperty(int rootNumber)
    {
        return (Calculator.Calculator.Add(rootNumber, 0) == rootNumber).ToProperty();
    }
}
using System.Text;

namespace CalculatorUnitTest;

public class ExampleBasedTestCircle
{
    [Theory]
    [InlineData(5)]
    public void Can_Print_A_Circle(int radius)
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        Calculator.Circle.PrintCircle(radius);

        // Assert
        var expected = new StringBuilder();
        expected.AppendLine("     *****     ");
        expected.AppendLine("  ***********  ");
    }
}
using FsCheck;

namespace CalculatorUnitTest;

public static class RandomNumberGenerator
{
    public static Arbitrary<int> Generate() =>
        Arb.Default.Int32().Filter(n => n > 0);
}
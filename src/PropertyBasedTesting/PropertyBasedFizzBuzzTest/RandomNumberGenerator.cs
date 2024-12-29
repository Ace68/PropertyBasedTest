using FsCheck;

namespace PropertyBasedFizzBuzzTest;

public static class RandomNumberGenerator
{
    public static Arbitrary<int> Generate() =>
        Arb.Default.Int32().Filter(n => n is >= 1 and <= 100);
}

public static class RandomMultipleOfThreeGenerator
{
    public static Arbitrary<int> Generate() =>
        Arb.Default.Int32().Filter(n => n is >= 1 and <= 100 && n % 3 == 0);
}

public static class RandomMultipleOfFiveGenerator
{
    public static Arbitrary<int> Generate() =>
        Arb.Default.Int32().Filter(n => n is >= 1 and <= 100 && n % 5 == 0);
}

public static class RandomMultipleOfThreeAndFiveGenerator
{
    public static Arbitrary<int> Generate() =>
        Arb.Default.Int32().Filter(n => n is >= 1 and <= 100 && n % 15 == 0);
}

public static class RandomNonMultipleOfThreeOrFiveGenerator
{
    public static Arbitrary<int> Generate() =>
        Arb.Default.Int32().Filter(n => n is >= 1 and <= 100 && n % 3 != 0 && n % 5 != 0);
}
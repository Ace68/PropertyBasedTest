using FsCheck;

namespace DiamondTest;

public static class RandomLetterGenerator
{
    public static Arbitrary<char> Generate() =>
        Arb.Default.Char().Filter(c => c is >= 'A' and <= 'Z');
}

// It's possible to use the following RandomLetterGenerator, without FxCheck, instead of the one above:
// public static class RandomCharGenerator
// {
//     private static readonly Random _random = new Random();
//
//     public static char Generate()
//     {
//         return (char)_random.Next('A', 'Z' + 1);
//     }
// }
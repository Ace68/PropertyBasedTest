using FsCheck;

namespace PropertyBasedTesting;

public static class LetterGenerator
{
    public static Arbitrary<char> Generate() =>
        Arb.Default.Char().Filter(c => c >= 'A' && c <= 'Z');
}
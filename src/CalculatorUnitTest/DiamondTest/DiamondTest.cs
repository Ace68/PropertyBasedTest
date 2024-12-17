using FsCheck;
using FsCheck.Xunit;

namespace DiamondTest;

public class DiamondTest
{
    [Property(Arbitrary = [typeof(RandomLetterGenerator)])]
    public Property NotEmpty(char c)
    {
        return Diamond.Diamond.Generate(c).All(s => s != string.Empty).ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomLetterGenerator)])]
    public Property FirstLineContainsA(char c)
    {
        return Diamond.Diamond.Generate(c).First().Contains('A').ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomLetterGenerator)])]
    public Property LastLineContainsA(char c)
    {
        return Diamond.Diamond.Generate(c).Last().Contains('A').ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomLetterGenerator)])]
    public Property AllRowsExceptFirstAndLastContainTwoIdenticalLetters(char c)
    {
        if (c == 'A') return true.ToProperty();

        var diamond = Diamond.Diamond.Generate(c).ToArray()[1..^1];
        return diamond.All(x =>
        {
            var s = x.Replace(" ", string.Empty);
            var b = s.Length == 2 && s.First() == s.Last();
            return b;
        }).ToProperty();
    }
    
    [Property(Arbitrary = [typeof(RandomLetterGenerator)])]
    public Property SymmetricAroundHorizontalAxis(char c)
    {
        var diamond = Diamond.Diamond.Generate(c).ToArray();
        var half = diamond.Length / 2;
        var topHalf = diamond[..half];
        var bottomHalf = diamond[(half + 1)..];
        
        return topHalf.Reverse().SequenceEqual(bottomHalf).ToProperty();
    }

    [Property(Arbitrary = [typeof(RandomLetterGenerator)])]
    public Property SymmetricAroundVerticalAxis(char c)
    {
        return Diamond.Diamond.Generate(c).ToArray()
            .All(row =>
            {
                var half = row.Length / 2;
                var firstHalf = row[..half];
                var secondHalf = row[(half + 1)..];
                    
                return firstHalf.Reverse().SequenceEqual(secondHalf);
            }).ToProperty();
    }
}
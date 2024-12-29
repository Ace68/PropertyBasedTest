namespace FizzBuzz;

public static class FizzBuzz
{
    public static string ChkNumber(int numberToVerify)
    {
        if (numberToVerify % 3 == 0 && numberToVerify % 5 == 0)
            return "FizzBuzz";

        if (numberToVerify % 3 == 0)
            return "Fizz";

        return numberToVerify % 5 == 0
            ? "Buzz" 
            : numberToVerify.ToString();
    }
    
    public static string ChkFizzBuzz(IEnumerable<Tuple<int, string>> combinations, int number)
    {
        var matchingCombs = combinations.Where(c => IsMatch(number, c.Item1)).ToList();

        if (matchingCombs.Any())
            return string.Join("", matchingCombs.Select(c => c.Item2));

        return number.ToString("N");
    }

    private static bool IsMatch(int i, int comb) => i % comb == 0;
}
namespace Calculator;

public static class Circle
{
    public static void PrintCircle(int radius)
    {
        double thickness = 0.4;
        char symbol = '*';

        double rIn = radius - thickness;
        double rOut = radius + thickness;

        for (double y = radius; y >= -radius; --y)
        {
            for (double x = -radius; x < rOut; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= rIn * rIn && value <= rOut * rOut)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
using NumSysConvLib.Conversions;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Whole:");
        test_DecToBin(5);
        test_DecToBin(10);
        test_DecToBin(20);

        Console.WriteLine("\nFractional:");
        test_DecToBin(20.5);
        test_DecToBin(1.75);
        test_DecToBin(13.25);
    }

    public static void test_DecToBin(int input)
    {
        int output = NumberSystem.DecToBin(input);
        Console.WriteLine($"Input: {input}\tBinary: {output}");
    }

    public static void test_DecToBin(double input)
    {
        double output = NumberSystem.DecToBin(input);
        Console.WriteLine($"Input: {input}\tBinary: {output}");
    }
}
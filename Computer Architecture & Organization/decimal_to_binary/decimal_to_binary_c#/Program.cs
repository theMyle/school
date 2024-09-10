using NumSysConvLib.Conversions;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Decimal to Binary Conversion\n");

        Console.Write("Enter a number:\t");
        String? input = Console.ReadLine();

        double number = 0;
        if (!Double.TryParse(input, out number))
        {
            Console.WriteLine("Error parsing input. Must be a number.");
            Environment.Exit(1);
        };

        double result = NumberSystem.DecToBin(number);
        Console.WriteLine($"Binary:\t{result}");
    }
}
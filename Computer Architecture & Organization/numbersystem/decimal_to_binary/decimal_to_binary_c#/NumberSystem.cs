namespace NumSysConvLib.Conversions
{
    /// <summary>
    /// A class full of functionalities for converting to different type of number systems.
    /// </summary>
    public static class NumberSystem
    {
        // Decimal to Binary
        public static int DecToBin(int number)
        {
            int multiplier = 1;
            int output = 0;

            while (number != 0)
            {
                int remainder = number % 2;
                number /= 2;
                output += remainder * multiplier;
                multiplier *= 10;
            }
            return output;
        }

        public static double DecToBin(double number)
        {
            double output = DecToBin((int)number);
            double fractional = number - (int)number;
            int decimalPlace = -1;

            while (fractional != 0.0)
            {
                int whole = (int)(fractional * 2);
                fractional = (fractional * 2) - whole;
                output += whole * Math.Pow(10, decimalPlace);
                decimalPlace--;
            }
            return output;
        }
    }
}

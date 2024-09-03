namespace NumSysConvLib.Conversions
{
    /// <summary>
    /// A class full of functionalities for converting to different type of number systems.
    /// </summary>
    public static class NumberSystem
    {
        /// <summary>
        /// Converts decimal to binary format.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Binary representation</returns>
        public static int DecToBin(int number)
        {
            int currentVal = number;
            int remainder = 0;
            int decimalPlace = 0;
            int output = 0;

            while (currentVal != 0)
            {
                remainder = currentVal % 2;
                currentVal /= 2;
                output += remainder * (int)Math.Pow(10, decimalPlace);
                decimalPlace++;
            }
            return output;
        }

        /// <summary>
        /// Converts decimal to binary format.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Binary representation</returns>
        public static double DecToBin(double number)
        {
            int whole = (int)number;
            double fractional = number - whole;
            double output = DecToBin(whole);
            int decimalPlace = 1;

            while (fractional != 0.0)
            {
                whole = (int)(fractional * 2.0);
                fractional = (fractional * 2) - whole;
                output += whole * Math.Pow(10, -decimalPlace);
                decimalPlace++;
            }
            return output;
        }

    }
}

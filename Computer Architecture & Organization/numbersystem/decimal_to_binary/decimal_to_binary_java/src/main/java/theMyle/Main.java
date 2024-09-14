package theMyle;

public class Main {
    public static void main(String[] args) {
        System.out.println("Whole numbers:");
        int result = decToBin(10);
        System.out.printf("10 - Binary Value: %d\n", result);

        result = decToBin(20);
        System.out.printf("20 - Binary Value: %d\n", result);

        result = decToBin(100);
        System.out.printf("100 - Binary Value: %d\n", result);

        System.out.println("\nFractional numbers:");
        double result2 = decToBin(100.5);
        System.out.printf("100.5 - Binary Value: %.2f\n", result2);

        result2 = decToBin(10.75);
        System.out.printf("10.75 - Binary Value: %.2f\n", result2);

        result2 = decToBin(12.25);
        System.out.printf("12.25 - Binary Value: %.2f\n", result2);
    }

    private static int decToBin(final int number) {
        int currentVal = number;
        int remainder = 0;
        int decimalPlace = 0;
        int output = 0;

        while (currentVal != 0) {
            remainder = currentVal % 2;
            currentVal /= 2;
            output += remainder * (int) Math.pow(10, decimalPlace);
            decimalPlace++;
        }

        return output;
    }

    private static double decToBin(final double number) {
        int whole = (int) number;
        double decimal = number - whole;

        double output = 0;
        int remainder = 0;
        int decimalPlace = 0;

        // calculate whole number
        while (whole != 0) {
            remainder = whole % 2;
            whole /= 2;
            output += remainder * Math.pow(10, decimalPlace);
            decimalPlace++;
        }

        // calculate fractional part
        decimalPlace = 1;
        while (decimal != 0.0) {
            whole = (int) (decimal * 2);
            decimal = (decimal * 2.0) - whole;
            output += whole * Math.pow(10, -decimalPlace);
            decimalPlace++;
        }

        return output;
    }
}
package org.theMyle;

import java.io.*;
import java.text.ParseException;

public class Main {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        float dividend = 0;
        float divisor = 0;
        float quotient = 0;
        int remainder = 0;

        try {
            System.out.print("Enter dividend: ");
            dividend = Float.parseFloat(reader.readLine());

            System.out.print("Enter divisor: ");
            divisor = Float.parseFloat(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error reading input:\n\tError: %s\n", e);
            return;
        } catch (NumberFormatException e) {
            System.out.printf("Invalid input type, must be a number:\n\tError: %s\n", e);
            return;
        }

        try {
            quotient = dividend / divisor;
            remainder = (int) (dividend) % (int) (divisor);
        } catch (ArithmeticException e) {
            System.out.printf("Error computing:\n\tError: %s\n", e);
            return;
        }

        System.out.printf("\nQuotient: %d\n", (int) (quotient));
        System.out.printf("Remainder: %d\n", remainder);
    }
}
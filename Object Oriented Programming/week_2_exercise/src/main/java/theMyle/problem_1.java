package theMyle;

import java.io.*;

public class problem_1 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = "";
        int firstNumber = 0;
        int secondNumber = 0;
        int thirdNumber = 0;
        int fourthNumber = 0;
        int fifthNumber = 0;

        int sum = 0;
        int difference = 0;
        int product = 0;
        int quotient = 0;

        try {
            System.out.print("Enter the first number: ");
            input = reader.readLine();
            firstNumber = Integer.parseInt(input);

            System.out.print("Enter the second number: ");
            input = reader.readLine();
            secondNumber = Integer.parseInt(input);

            System.out.print("Enter the third number: ");
            input = reader.readLine();
            thirdNumber = Integer.parseInt(input);

            System.out.print("Enter the fourth number: ");
            input = reader.readLine();
            fourthNumber = Integer.parseInt(input);

            System.out.print("Enter the fifth number: ");
            input = reader.readLine();
            fifthNumber = Integer.parseInt(input);

        } catch (IOException e) {
            System.out.println("Error");
            return;
        }

        sum = firstNumber + secondNumber;
        difference = sum - thirdNumber;
        product = difference * fourthNumber;
        quotient = product/fifthNumber;

        System.out.println("The sum is " + sum);
        System.out.println("The difference is " + difference);
        System.out.println("The product is " + product);
        System.out.println("The quotient is " + quotient);
    }
}
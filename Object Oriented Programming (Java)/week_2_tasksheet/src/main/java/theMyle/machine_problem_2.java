package theMyle;

import java.io.*;

public class machine_problem_2 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int num1 = 0;
        int num2 = 0;

        try {
            System.out.print("Enter the first number: ");
            num1 = Integer.parseInt(reader.readLine());

            System.out.print("Enter the second number: ");
            num2 = Integer.parseInt(reader.readLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;
        } catch (IOException e) {
            System.out.printf("Error parsing input: %s\n", e.getMessage());
            return;
        }

        System.out.printf("After swapping the first number: %d\n", num1);
        System.out.printf("After swapping the second number: %d\n", num2);
    }
}
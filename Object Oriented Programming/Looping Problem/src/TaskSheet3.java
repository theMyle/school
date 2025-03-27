import javax.swing.*;
import java.awt.*;
import java.util.Scanner;

public class TaskSheet3 {
    public static void main(String[] args) {
        String input = "";
        int number = 0;

        try {
            System.out.print("Enter a number: ");
            Scanner scanner = new Scanner(System.in);
            number = Integer.parseInt(scanner.nextLine());
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage() + "\n\tMust be a number");
            return;
        }

        // WHILE LOOP
        System.out.println("\nWHILE:");
        int output = 1; int i = 1;
        while (i <= number) {
            output *= i;
            i++;
        }
        System.out.println("Factorial Value: " + output);

        // DO WHILE
        System.out.println("\nDO WHILE:");
        output = 1; i = 1;
        do {
            output *= i;
            i++;
        }
        while (i <= number);
        System.out.println("Factorial Value: " + output);

        // FOR
        output = 1;
        System.out.println("\nFOR:");
        for (i = 1; i <= number; i++) {
            output *= i;
        }
        System.out.println("Factorial Value: " + output);
    }
}

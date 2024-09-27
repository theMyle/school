import java.io.*;

public class problem04 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int first = 0;
        int second = 0;
        int third = 0;

        try {
            System.out.print("Enter the first integer: ");
            first = Integer.parseInt(reader.readLine());
            System.out.print("Enter the second integer: ");
            second = Integer.parseInt(reader.readLine());
            System.out.print("Enter the third integer: ");
            third = Integer.parseInt(reader.readLine());
        } catch (Exception error) {
            System.out.println("Error: " + error.getMessage());
            return;
        }

        if (first == second || second == third || first == third) {
            System.out.print("Equal numbers: ");
            if (first == second)
                System.out.print(first + " ");
            if (second == third)
                System.out.print(second + " ");
            if (first == third)
                System.out.print(first + " ");
            System.out.println();
        } else {
            double average = (first + second + third) / 3.0;
            System.out.printf("Average: %.2f\n", average);
        }
    }
}
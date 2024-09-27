import java.io.*;

public class problem03 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int first = 0;
        int second = 0;

        try {
            System.out.print("Enter the first integer: ");
            first = Integer.parseInt(reader.readLine());
            System.out.print("Enter the second integer: ");
            second = Integer.parseInt(reader.readLine());
        } catch (Exception error) {
            System.out.println("Error: " + error.getMessage());
            return;
        }

        if (first != second) {
            int higher = Math.max(first, second);
            System.out.println("Higher number: " + higher);
        }
    }
}

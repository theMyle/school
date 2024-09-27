import java.io.*;

public class problem02 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int units = 0;
        int tuition_fee = 0;

        try {
            System.out.print("Enter the number of units registered: ");
            units = Integer.parseInt(reader.readLine());
        } catch (Exception error) {
            System.out.println("Error: " + error.getMessage());
            return;
        }

        if (units >= 21) {
            tuition_fee = 7000;
        } else {
            tuition_fee = units * 300;
        }

        System.out.printf("Tuition fee: %d\n", tuition_fee);
    }
}
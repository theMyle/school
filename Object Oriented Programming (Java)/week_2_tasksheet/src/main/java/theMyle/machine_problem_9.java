package theMyle;

import java.io.*;

public class machine_problem_9 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int kmph = 0;
        double mph = 0;

        try {
            System.out.print("Enter the distance in kilometer: ");
            kmph = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error parsing input: %s\n", e.getMessage());
            return;
        }

        // calculate
        mph = (kmph * 0.6213712);
        System.out.printf("The %d km/hr is equivalent to: %.2f m/h\n", kmph, mph);
    }
}

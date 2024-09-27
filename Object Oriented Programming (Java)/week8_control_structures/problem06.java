import java.io.*;

public class problem06 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int speed = 0;

        try {
            System.out.print("Enter the aircraft speed in km/h: ");
            speed = Integer.parseInt(reader.readLine());
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
            return;
        }

        if (speed < 500) {
            System.out.println("It's a BIRD!");
        } else if (speed >= 500 && speed <= 1100) {
            System.out.println("It's a military aircraft!");
        } else {
            System.out.println("It's a civilian aircraft");
        }
    }
}
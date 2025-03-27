import java.util.Scanner;

public class TaskSheet2 {
    public static void main(String[] args) {

        // WHILE LOOP
        System.out.println("WHILE:");
        int x = 1;
        int y = 5;

        while (y >= 1) {
            System.out.print(y + ", " + x + ", ");
            y--;
            x++;
        }

        // DO WHILE LOOP
        System.out.println("\n\nDO WHILE:");
        x = 1;
        y = 5;

        do {
            System.out.print(y + ", " + x + ", ");
            y--;
            x++;
        }
        while (y >= 1);

        // FOR LOOP
        System.out.println("\n\nFOR:");
        x = 1;
        y = 5;

        for (int i = 0; i < 5; i++) {
            System.out.print((y - i) + ", " + (x + i) + ", ");
        }
    }
}

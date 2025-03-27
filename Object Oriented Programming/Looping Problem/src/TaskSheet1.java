public class TaskSheet1 {
    public static void main(String[] args) {
        int x = 1;

        // While Loop
        System.out.println("WHILE:");
        while (x < 6) {
            System.out.println("Num: " + x + "\tSquared: " + x*x);
            x++;
        }

        // Do While Loop
        System.out.println("\nDO WHILE:");
        x = 1;
        do {
            System.out.println("Num: " + x + "\tSquared: " + x*x);
            x++;
        } while (x < 6);

        // For Loop
        System.out.println("\nFOR:");
        x = 1;
        for (int i = x; i<6; i++) {
            System.out.println("Num: " + i + "\tSquared: " + i*i);
        }
    }
}

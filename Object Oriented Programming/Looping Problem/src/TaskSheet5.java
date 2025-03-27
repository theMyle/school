import java.util.Scanner;

public class TaskSheet5 {
    public static void main(String[] args) {
        String input = "";
        int num = 0;

        try {
            System.out.print("Enter a number: ");
            Scanner scanner = new Scanner(System.in);
            num = Integer.parseInt(scanner.nextLine());
        } catch (Exception e) {
            System.out.println("Error parsing input: " + e.getMessage());
            return;
        }

        int prev = 0;
        int current = 1;
        int itr = num;

        // while loop
        while (itr > 0) {
            System.out.print(current + " ");
            int temp = prev;
            prev = current;
            current = temp + current;
            itr--;
        }
        System.out.println();

        // do while
        prev = 0;
        current = 1;
        itr = num;

        do {
            itr--;
            System.out.print(current + " ");
            int temp = prev;
            prev = current;
            current = temp + current;
        }
        while (itr > 0);
        System.out.println();

        // for loop
        prev = 0;
        current = 1;

        for (itr = num; itr > 0; itr--) {
            System.out.print(current + " ");
            int temp = prev;
            prev = current;
            current = temp + current;
        }
    }
}

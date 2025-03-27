import java.util.Scanner;

public class TaskSheet4 {
    public static void main(String[] args) {
        String input = "";
        String output = "";

        System.out.print("Enter a number: ");
        Scanner scanner = new Scanner(System.in);
        input = scanner.nextLine();

        // While Loop
        int x = input.length()-1;
        while (x >= 0) {
            output += input.charAt(x);
            x--;
        }
        System.out.println("Reverse Number (WHILE): " + output);


        // Do While
        output = "";
        x = input.length()-1;
        do {
            output += input.charAt(x);
            x--;
        }
        while (x >= 0);
        System.out.println("Reverse Number (DO WHILE): " + output);


        // For Loop
        output = "";
        for (x = input.length()-1; x >= 0; x--) {
            output += input.charAt(x);
        }
        System.out.println("Reverse Number (FOR LOOP): " + output);
    }
}

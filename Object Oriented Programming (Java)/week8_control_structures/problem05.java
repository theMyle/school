import java.io.*;

public class problem05 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int hoursWorked = 0;
        double hourlyRate = 0;

        try {
            System.out.print("Enter number of hours worked: ");
            hoursWorked = Integer.parseInt(reader.readLine());

            System.out.print("Enter hourly rate: ");
            hourlyRate = Double.parseDouble(reader.readLine());
        } catch (Exception error) {
            System.out.println("Error parsing input: " + error.getMessage());
        }

        double overtimePay = 0;
        double grossPay = 0;

        if (hoursWorked > 40) {
            overtimePay = (hoursWorked - 40) * (hourlyRate * 1.5);
            grossPay = (40 * hourlyRate) + overtimePay;
            System.out.printf("Gross Pay: %.2f\nOvertime Pay: %.2f\n", grossPay, overtimePay);
        } else {
            grossPay = (hoursWorked * hourlyRate);
            System.out.println("Gross Pay: " + grossPay);
        }
    }
}

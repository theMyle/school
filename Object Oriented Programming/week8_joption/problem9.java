import javax.swing.*;

public class problem9 {
    public static void main(String[] args) {
        String input = "";
        double tax = 0;
        double realEstateVal = 0;

        input = JOptionPane.showInputDialog("Enter real estate value");
        realEstateVal = Double.parseDouble(input);

        if (realEstateVal < 250_001 && realEstateVal >= 0) {
            tax = realEstateVal * 0.05;
        } else if (realEstateVal >= 250_001 && realEstateVal <= 500_000) {
            tax = realEstateVal * 0.1;
        } else if (realEstateVal > 500_000) {
            tax = realEstateVal * 0.15;
        }

        JOptionPane.showMessageDialog(
                null,
                String.format("Real Estate Value: %.2f\nCalculated Tax: %.2f", realEstateVal, tax));
    }
}

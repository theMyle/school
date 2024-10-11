
import javax.swing.*;

public class problem01 {

    public static void main(String[] args) {
        String input = "";
        int total_purchase = 0;
        float discount = 0;
        float amount_to_be_paid = 0;

        try {
            input = JOptionPane.showInputDialog("What is your total purchase amount: ");
            total_purchase = Integer.parseInt(input);
        } catch (Exception error) {
            JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        if (total_purchase >= 2000) {
            discount = 0.05F;
        }

        amount_to_be_paid = total_purchase - (total_purchase * discount);
        JOptionPane.showMessageDialog(null, "Amount to be paid: " + amount_to_be_paid);
    }
}

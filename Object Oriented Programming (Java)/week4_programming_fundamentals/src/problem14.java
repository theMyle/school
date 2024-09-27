import javax.swing.JOptionPane;

public class problem14 {
    public static void main(String[] args) {
        try {
            final double LAZADA_COMMISSION_RATE = 0.15;
            final double FEEBUDDY_COMMISSION_RATE = 0.029;
            final double SHIPPING_REIMBURSEMENT = 3.99;
            final double SHIPPING_COST_PER_POUND = 1.59;

            String sellingPriceInput = JOptionPane.showInputDialog(null, "Enter the selling price of the book:");
            double sellingPrice = Double.parseDouble(sellingPriceInput);

            String weightInput = JOptionPane.showInputDialog(null, "Enter the weight of the book in pounds:");
            double weight = Double.parseDouble(weightInput);

            int roundedWeight = (int) Math.ceil(weight);

            double lazadaCommission = sellingPrice * LAZADA_COMMISSION_RATE;
            double totalAmountForFeebuddy = sellingPrice + SHIPPING_REIMBURSEMENT;
            double feebuddyCommission = totalAmountForFeebuddy * FEEBUDDY_COMMISSION_RATE;
            double shippingCost = roundedWeight * SHIPPING_COST_PER_POUND;

            double revenue = sellingPrice + SHIPPING_REIMBURSEMENT;
            double totalExpenses = lazadaCommission + feebuddyCommission + shippingCost;
            double profit = revenue - totalExpenses;

            String message = String.format(
                    "Lazada Commission : $%.2f\n" +
                            "Feebuddy Commission: $%.2f\n" +
                            "Shipping cost: $%.2f\n" +
                            "Total Profit: $%.2f",
                    lazadaCommission, feebuddyCommission, shippingCost, profit
            );
            JOptionPane.showMessageDialog(null, message);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Invalid input! Please enter valid numbers.");
        }
    }
}
import javax.swing.JOptionPane;

public class problem13 {
    public static void main(String[] args) {
        while (true) {
            try {
                String input = JOptionPane.showInputDialog(null, "Enter the number of days (0 to quit):");
                int days = Integer.parseInt(input);

                if (days == 0) {
                    break;
                }

                double population = 100 * Math.sqrt(days) + 201.0 / (days + 1) + 1;
                int roundedPopulation = (int) Math.round(population);
                JOptionPane.showMessageDialog(null, String.format("Days: %d\nPopulation: %d", days, roundedPopulation));
            } catch (NumberFormatException e) {
                JOptionPane.showMessageDialog(null, "Invalid input! Please enter a positive integer.");
            }
        }
    }
}
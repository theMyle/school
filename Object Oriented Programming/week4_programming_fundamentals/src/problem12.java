import javax.swing.JOptionPane;

public class problem12 {

    public static void main(String[] args) {
        try {
            String focalLengthObjectiveInput = JOptionPane.showInputDialog(null, "Enter the focal length of the objective (FO):");
            double focalLengthObjective = Double.parseDouble(focalLengthObjectiveInput);

            String diameterInput = JOptionPane.showInputDialog(null, "Enter the diameter (D):");
            double diameter = Double.parseDouble(diameterInput);

            String focalLengthEyepieceInput = JOptionPane.showInputDialog(null, "Enter the focal length of the eyepiece (Fe):");
            double focalLengthEyepiece = Double.parseDouble(focalLengthEyepieceInput);

            double focalRatio = focalLengthObjective / diameter;

            double exitPupil = focalLengthEyepiece / focalRatio;

            String message = String.format(
                    "The focal ratio of the telescope is %.1f\n" +
                            "The size of the image that exits the eyepiece is: %.2f",
                    focalRatio, exitPupil
            );

            JOptionPane.showMessageDialog(null, message);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Invalid input! Please enter valid numbers.");
        }
    }
}
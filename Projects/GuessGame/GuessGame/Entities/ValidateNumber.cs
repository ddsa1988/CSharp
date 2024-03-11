namespace GuessGame.Entities;

public class ValidateNumber {
    public static bool IsNumberValid(string? strNumber, int minRange, int maxRange, out int number) {
        int value;
        number = -1;

        if (string.IsNullOrEmpty(strNumber) || string.IsNullOrWhiteSpace(strNumber)) return false;

        try {
            value = int.Parse(strNumber);
            if (value < minRange || value > maxRange) return false;
        } catch {
            return false;
        }

        number = value;
        return true;
    }
}
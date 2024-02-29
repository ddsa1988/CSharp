namespace GuessGame.Entities;

public static class RandomNumber {
    public static int GetNumber(int min, int max) {
        if (min > max) {
            min += max;
            max = min - max;
            min -= max;
        }

        Random random = new Random();
        int number = random.Next(min, max + 1);

        return number;
    }
}
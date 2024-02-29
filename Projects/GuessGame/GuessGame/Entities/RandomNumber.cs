namespace GuessGame.Entities;

public static class RandomNumber {
    public static int GetNumber(int min, int max) {
        if (min >= max) return 0;

        Random random = new Random();
        int number = random.Next(min, max);

        return number;
    }
}
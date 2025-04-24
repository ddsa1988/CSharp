namespace NumberGuessGame.Models;

public static class RandomNumber {
    private static readonly Random Random;

    static RandomNumber() {
        Random = new Random();
    }

    public static int NextInt(int min, int max) {
        if (min > max) {
            (min, max) = (max, min);
        }

        return Random.Next(min, max);
    }
}
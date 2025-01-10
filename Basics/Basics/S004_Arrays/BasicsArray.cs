namespace Basics.S004_Arrays;

public static class BasicsArray {
    public static void UserMain() {
        var random = new Random();
        const int size = 10;

        int[] numbers = new int[size];
        string[] names = ["Diego", "Amanda", "Amora", "Ameixa"];

        for (int i = 0; i < size; i++) numbers[i] = random.Next(size);

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
        Console.WriteLine($"[{string.Join(", ", names)}]");
    }
}
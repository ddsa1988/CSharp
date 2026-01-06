namespace Chapter014.Threads;

public static class Example003 {
    // The Sleep method pauses the current thread for a specified period
    public static void Run() {
        int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

        foreach (int number in numbers) {
            Console.Write(number + " ");

            Thread.Sleep(TimeSpan.FromSeconds(1));
        }
    }
}
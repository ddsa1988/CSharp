namespace Examples.RefParameter;

public static class Example001 {
    public static void Run() {
        int myNumber = 10;

        Console.WriteLine($"{nameof(myNumber)}: {myNumber}");

        IncrementInteger(ref myNumber);

        Console.WriteLine($"{nameof(myNumber)}: {myNumber}");
    }

    private static void IncrementInteger(ref int number) {
        number++;
    }
}
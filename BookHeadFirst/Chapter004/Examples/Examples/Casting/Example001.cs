namespace Examples.Casting;

public static class Example001 {
    public static void Run() {
        const short myShort = 365;
        const int myInt = myShort;
        const byte myByte = unchecked((byte)myShort);

        Console.WriteLine($"{nameof(myShort)}: {myShort}");
        Console.WriteLine($"Cast {nameof(myShort)} to {nameof(myInt)}: {myInt}");
        Console.WriteLine($"Cast {nameof(myShort)} to {nameof(myByte)}: {myByte}");
    }
}
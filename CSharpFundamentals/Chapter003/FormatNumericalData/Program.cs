namespace FormatNumericalData;

public static class Program {
    public static void Main(string[] args) {
        const int number = 99999;
        const int bigNumber = 100000;

        Console.WriteLine($"The value {number} in various formats:");
        Console.WriteLine($"C format: {number:C}");
        Console.WriteLine($"D9 format: {number:D9}");
        Console.WriteLine($"F3 format: {number:F3}");
        Console.WriteLine($"N format: {number:N}");
        Console.WriteLine($"E format: {number:E}");
        Console.WriteLine($"e format: {number:e}");
        Console.WriteLine($"X format: {number:X}");
        Console.WriteLine($"x format: {number:x}");

        Console.WriteLine();

        string userMessage = string.Format("{0} in hex is {0:x}", bigNumber);
        Console.WriteLine(userMessage);
    }
}
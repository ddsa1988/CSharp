namespace Examples.HandlingExceptions;

public static class Example001 {
    public static void Run() {
        int? number = null;

        while (!number.HasValue) {
            Console.Write("Type a number: ");
            string input = Console.ReadLine() ?? string.Empty;

            try {
                number = int.Parse(input);
            } catch (NullReferenceException ex) {
                Console.WriteLine("Invalid number: " + ex.Message);
            } catch (FormatException ex) {
                Console.WriteLine("Invalid number: " + ex.Message);
            } catch (OverflowException ex) {
                Console.WriteLine("Invalid number: " + ex.Message);
            }
        }

        Console.Write("You've typed the number: " + number.Value);
    }
}
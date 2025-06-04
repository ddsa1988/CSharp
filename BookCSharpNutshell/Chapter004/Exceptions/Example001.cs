namespace Chapter004.Exceptions;

public static class Example001 {
    public static void Run() {
        Console.Write("Type a number: ");
        string? input = Console.ReadLine();

        try {
            double number = Convert.ToDouble(input);
            Console.WriteLine("The number entered is " + number);
        } catch (FormatException ex) {
            Console.WriteLine("Format exception: " + ex.Message);
        } catch (Exception ex) {
            Console.WriteLine("General exception: " + ex.Message);
        } finally {
            Console.WriteLine("Finally block always execute.");
        }
    }
}
namespace GuessGame;

public class Program {
    public static void Main(string[] args) {
        int number = MyRandom.GetNumber(0, 11);
        
        Console.WriteLine("Type something:");
        string? result = Console.ReadLine();

        Console.WriteLine(number);
        Console.WriteLine(result);
    }
}
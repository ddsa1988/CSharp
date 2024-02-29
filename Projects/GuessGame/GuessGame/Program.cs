namespace GuessGame;

using MyRandom = GuessGame.Entities.RandomNumber;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine(MyRandom.GetNumber(-5, -10));
    }
}
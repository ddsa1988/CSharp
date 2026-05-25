using HiLoGameConsole.Models;

namespace HiLoGameConsole;

public static class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Welcome to the HiLo Game.");
        Console.WriteLine($"Guess numbers between {HiLoGame.Minimum} and {HiLoGame.Maximum}.");

        HiLoGame.Hint();

        while (HiLoGame.GetPot() > 0) {
            Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
            Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
            char choice = Console.ReadKey(true).KeyChar;

            switch (char.ToLower(choice)) {
                case 'h':
                    HiLoGame.Guess(true);
                    break;
                case 'l':
                    HiLoGame.Guess(false);
                    break;
                case '?':
                    HiLoGame.Hint();
                    break;
                default:
                    return;
            }
        }

        Console.WriteLine("The pot is empty. Bye!");
    }
}
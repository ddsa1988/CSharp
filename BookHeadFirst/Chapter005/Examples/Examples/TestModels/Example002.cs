using Examples.Models;

namespace Examples.TestModels;

public static class Example002 {
    public static void Run() {
        Console.WriteLine("Welcome to HiLo.");
        Console.WriteLine($"Guess numbers between 1 and {HiLoGame.Maximum}.");

        HiLoGame.Hint();

        while (HiLoGame.Pot > 0) {
            Console.WriteLine("Press 'h' for higher, 'l'  for lower, '?' to buy a hint,");
            Console.Write($"or any other key to quit with {HiLoGame.Pot}: ");

            char option = Console.ReadKey(true).KeyChar;

            switch (option) {
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
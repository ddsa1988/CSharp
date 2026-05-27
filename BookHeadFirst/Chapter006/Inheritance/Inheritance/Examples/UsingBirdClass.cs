using Inheritance.Models;

namespace Inheritance.Examples;

public static class UsingBirdClass {
    public static void Run() {
        while (true) {
            Bird bird;

            Console.Write("\nPress P for pigeon, O for ostrich: ");
            char userInput = Console.ReadKey().KeyChar;

            switch (char.ToLower(userInput)) {
                case 'p':
                    bird = new Pigeon();
                    break;
                case 'o':
                    bird = new Ostrich();
                    break;
                default:
                    return;
            }

            Console.Write("\nHow many eggs should it lay? ");
            string? numberOfEggsString = Console.ReadLine();

            bool isNumberOfEggsValid = int.TryParse(numberOfEggsString, out int numberOfEggs) && numberOfEggs > 0;

            if (!isNumberOfEggsValid) return;

            Egg[] eggs = bird.LayEggs(numberOfEggs);

            foreach (Egg egg in eggs) {
                Console.WriteLine(egg.Description);
            }
        }
    }
}
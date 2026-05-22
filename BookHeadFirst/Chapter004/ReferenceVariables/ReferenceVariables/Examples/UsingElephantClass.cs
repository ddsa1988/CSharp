using ReferenceVariables.Models;

namespace ReferenceVariables.Examples;

public static class UsingElephantClass {
    public static void Run() {
        var lloyd = new Elephant("Lloyd", 40);
        var lucinda = new Elephant("Lucinda", 33);
        const string methodName = "WhoAmI()";

        while (true) {
            Console.Write($"Press 1 for {lloyd.Name}, 2 for {lucinda.Name}, 3 to swap. (any other key to exit): ");
            char userInput = Console.ReadKey(true).KeyChar;

            Console.WriteLine($"\nYou pressed {userInput}.");

            switch (userInput) {
                case '1':
                    Console.WriteLine($"Calling {lloyd.Name.ToLower()}.{methodName}");
                    lloyd.WhoAmI();
                    Console.WriteLine();
                    break;
                case '2':
                    Console.WriteLine($"Calling {lucinda.Name.ToLower()}.{methodName}");
                    lucinda.WhoAmI();
                    Console.WriteLine();
                    break;
                case '3':
                    (lloyd, lucinda) = (lucinda, lloyd);
                    Console.WriteLine("References have been swapped\n");
                    break;
                default:
                    return;
            }
        }
    }
}
using PickRandomCards.Models;

namespace PickRandomCards;

public static class Program {
    public static void Main(string[] args) {
        int numberOfCards;

        while (true) {
            Console.Write("Enter the number of cards to pick: ");
            string? userInput = Console.ReadLine();

            bool isNumberValid = int.TryParse(userInput, out numberOfCards);

            if (!isNumberValid) {
                Console.WriteLine("Invalid number.\n");
                continue;
            }

            if (numberOfCards < 1) {
                Console.WriteLine("You must enter a positive number!\n");
                continue;
            }

            break;
        }

        string[] pickedCards = CardPicker.PickSomeCards(numberOfCards);

        Console.WriteLine("\nThe picked cards are:\n");

        foreach (string card in pickedCards) {
            Console.WriteLine(card);
        }
    }
}
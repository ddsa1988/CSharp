using PickRandomCards.Models;

namespace PickRandomCards;

public static class Program {
    public static void Main(string[] args) {
        Console.Write("Enter the number of cards to pick: ");
        string? input = Console.ReadLine();
        bool isInputValid = int.TryParse(input, out int numberOfCards) && numberOfCards > 0;

        if (isInputValid) {
            IEnumerable<string> cards = CardPicker.GetRandomCards(numberOfCards);
            Console.WriteLine(string.Join("\n", cards));
        } else {
            Console.WriteLine("\nYou entered an invalid number!");
        }
    }
}
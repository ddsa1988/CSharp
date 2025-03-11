using PickRandomCards.Models;

namespace PickRandomCards;

public static class Program {
    public static void Main(string[] args) {
        int numberOfCards;
        
        while (true) {
            Console.Write("Enter the number of cards to pick: ");
            string? userInput = Console.ReadLine();
            
            bool isInputValid = int.TryParse(userInput, out numberOfCards) && numberOfCards >= 1;

            if (!isInputValid) continue;

            break;
        }

        string[] cards = CardPicker.PickSomeCards(numberOfCards);

        foreach (string card in cards) {
            Console.WriteLine(card);
        }
    }
}
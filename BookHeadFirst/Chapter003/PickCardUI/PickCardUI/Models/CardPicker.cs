using System;
using System.Linq;

namespace PickCardUI.Models;

public static class CardPicker {
    private static readonly string[] Values =
        ["Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"];

    private static readonly string[] Suits = ["Spades", "Hearts", "Clubs", "Diamonds"];

    private static readonly Random Random = new();

    /// <summary>
    /// Picks a number of cards and returns them.
    /// </summary>
    /// <param name="numberOfCards">The number of cards to pick</param>
    /// <returns>An array of strings that contain the card names</returns>
    public static string[] PickSomeCards(int numberOfCards) {
        if (numberOfCards < 1) return Enumerable.Empty<string>().ToArray();

        string[] pickedCards = new string[numberOfCards];

        for (int i = 0; i < numberOfCards; i++) {
            pickedCards[i] = GetRandomCard();
        }

        return pickedCards;
    }

    private static string GetRandomCard() {
        string randomValue = GetRandomValue();
        string randomSuit = GetRandomSuit();

        return $"{randomValue} of {randomSuit}";
    }

    private static string GetRandomValue() {
        int randomIndex = Random.Next(0, Values.Length);
        string randomValue = Values[randomIndex];

        return randomValue;
    }

    private static string GetRandomSuit() {
        int randomIndex = Random.Next(0, Suits.Length);
        string randomSuit = Suits[randomIndex];

        return randomSuit;
    }
}
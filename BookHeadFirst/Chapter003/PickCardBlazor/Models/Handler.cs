namespace PickCardBlazor.Models;

public static class Handler {
    public static int NumberOfCards { get; set; }
    public static string[] PickedCards { get; private set; }

    static Handler() {
        NumberOfCards = 5;
        PickedCards = [];
    }

    public static void UpdateCards() {
        PickedCards = CardPicker.PickSomeCards(NumberOfCards);
    }
}
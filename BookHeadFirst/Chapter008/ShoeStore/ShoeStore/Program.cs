using ShoeStore.Models;

namespace ShoeStore;

public static class Program {
    public static void Main(string[] args) {
        var shoeCloset = new ShoeCloset();

        while (true) {
            shoeCloset.PrintShoes();

            Console.Write("\nPress 'a' to add or 'r' to remove a shoe: ");
            char userInput = Console.ReadKey().KeyChar;

            switch (char.ToLower(userInput)) {
                case 'a':
                    Console.WriteLine("\nAdd a shoe");

                    foreach (Style style in Enum.GetValues<Style>()) {
                        Console.WriteLine($"Press {(int)style} to add a {style}");
                    }

                    Console.Write("Enter a style: ");
                    string? styleString = Console.ReadLine();

                    bool isStyleIndexValid = int.TryParse(styleString, out int styleIndex);

                    if (!isStyleIndexValid) break;

                    break;
                case 'r':
                    Console.Write("\nEnter the number of the shoe to remove: ");
                    string? indexString = Console.ReadLine();

                    bool isShoeIndexValid = int.TryParse(indexString, out int shoeIndex);

                    if (!isShoeIndexValid) break;

                    Shoe? removedShoe = shoeCloset.RemoveShoeAt(shoeIndex);

                    if (removedShoe == null) break;

                    Console.WriteLine($"Removing {removedShoe.Description()}");
                    break;
                default:
                    return;
            }

            Console.Clear();
        }
    }
}
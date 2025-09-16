namespace Examples.Lists.Models;

public class ShoeCloset {
    private readonly List<Shoe> _shoes = [];

    public void PrintShoes() {
        if (_shoes.Count == 0) {
            Console.WriteLine("\nThe shoe closet is empty.");
        }

        Console.WriteLine("\nThe shoe closet contains:");
        int index = 1;

        foreach (Shoe shoe in _shoes) {
            Console.WriteLine($"Shoe #{index++}: {shoe.Description}");
        }
    }

    public void AddShoe() {
        const int numberOfShoesStyles = 6;
        const int numberOfShoeColors = 3;

        Console.WriteLine("\nAdd shoe:");

        for (int i = 0; i < numberOfShoesStyles; i++) {
            Console.WriteLine($"Press {i} to add a {(Style)i}");
        }

        Console.WriteLine("Enter a style:");

        for (int i = 0; i < numberOfShoeColors; i++) {
            Console.WriteLine($"Press {i} to add the color {(Color)i}");
        }

        Console.WriteLine("Enter a color:");
    }
}
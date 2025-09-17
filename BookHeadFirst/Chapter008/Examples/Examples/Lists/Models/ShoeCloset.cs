namespace Examples.Lists.Models;

public class ShoeCloset {
    private readonly List<Shoe> _shoes = [];

    public void PrintShoes() {
        if (_shoes.Count == 0) {
            Console.WriteLine("The shoe closet is empty.");
            return;
        }

        Console.WriteLine("The shoe closet contains:");
        int index = 1;

        foreach (Shoe shoe in _shoes) {
            Console.WriteLine($"Shoe #{index++}: {shoe.Description}");
        }
    }

    public void AddShoe() {
        const int numberOfShoesStyles = 6;
        const int numberOfShoeColors = 5;

        Console.WriteLine("\nAdd shoe");

        for (int i = 0; i < numberOfShoesStyles; i++) {
            Console.WriteLine($"Press {i} to add a {(Style)i}");
        }

        Console.Write("Enter a style: ");

        if (!(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style) && style >= 0 &&
              style < numberOfShoesStyles)) {
            Console.WriteLine();
            return;
        }

        Console.WriteLine("\n\nAdd color");

        for (int i = 0; i < numberOfShoeColors; i++) {
            Console.WriteLine($"Press {i} to add the color {(Color)i}");
        }

        Console.Write("Enter a color: ");

        if (!(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int color) && color >= 0 &&
              color < numberOfShoeColors)) {
            Console.WriteLine();
            return;
        }

        var shoe = new Shoe((Style)style, (Color)color);
        _shoes.Add(shoe);

        Console.WriteLine();
    }

    public void RemoveShoe() {
        Console.Write("\nEnter the number of the shoe to remove: ");

        if (!(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int index) && index > 0 &&
              index <= _shoes.Count)) {
            Console.WriteLine();
            return;
        }

        index--;

        Console.WriteLine($"\nRemoving {_shoes[index].Description}");
        _shoes.RemoveAt(index);
    }
}
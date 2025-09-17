using Examples.Lists.Models;

namespace Examples.Lists;

public static class Example002 {
    public static void Run() {
        const char add = 'a';
        const char remove = 'r';

        var shoeCloset = new ShoeCloset();

        while (true) {
            shoeCloset.PrintShoes();

            Console.Write("\nPress 'a' to add or 'r' to remove a shoe: ");
            char key = char.ToLower(Console.ReadKey().KeyChar);

            Console.WriteLine();

            switch (key) {
                case add:
                    shoeCloset.AddShoe();
                    break;
                case remove:
                    shoeCloset.RemoveShoe();
                    break;
                default:
                    return;
            }

            Console.WriteLine();
        }
    }
}
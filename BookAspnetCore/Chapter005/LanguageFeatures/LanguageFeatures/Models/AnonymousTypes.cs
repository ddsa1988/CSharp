namespace LanguageFeatures.Models;

public static class AnonymousTypes {
    public static void Run() {
        var products = new[] {
            new { Name = "Kayak", Price = 275M },
            new { Name = "Life Jacket", Price = 28.95M },
            new { Name = "Soccer Ball", Price = 19.5M },
            new { Name = "Corner Flag", Price = 34.95M },
        };

        var person = new { Name = "Diego Alexander", Birthdate = new DateTime(1988, 01, 22) };

        foreach (var product in products) {
            Console.WriteLine($"{nameof(product.Name)}: {product.Name}, {nameof(product.Price)}: {product.Price}");
        }

        Console.WriteLine($"{nameof(person.Name)}, {nameof(person.Birthdate)}: {person.Birthdate}");
    }
}
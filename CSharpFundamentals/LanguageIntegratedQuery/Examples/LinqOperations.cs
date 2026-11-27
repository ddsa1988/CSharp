using LanguageIntegratedQuery.Models;

namespace LanguageIntegratedQuery.Examples;

internal static class LinqOperations {
    private static readonly ProductInfo[] ItemsInStock = [
        new() { Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24 },
        new() { Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100 },
        new() { Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120 },
        new() { Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2 },
        new() { Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100 },
        new() { Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73 }
    ];

    private static readonly List<string> MyCars = ["Yugo", "Aztec", "BMW"];
    private static readonly List<string> YourCars = ["BMW", "Saab", "Aztec"];

    public static void Run() {
        int choice = int.Parse("8");

        switch (choice) {
            case 0:
                SelectEverything(ItemsInStock);
                break;
            case 1:
                ListProductNames(ItemsInStock);
                break;
            case 2:
                GetOverstock(ItemsInStock);
                break;
            case 3:
                _ = GetNamesAndDescriptions(ItemsInStock);
                break;
            case 4:
                _ = GetNamesAndDescriptionsTyped(ItemsInStock);
                break;
            case 5:
                AlphabetizeProductNames(ItemsInStock);
                break;
            case 6:
                DisplayDiff();
                break;
            case 7:
                DisplayIntersect();
                break;
            case 8:
                DisplayUnion();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(choice), "Invalid choice");
        }
    }

    private static void SelectEverything(ProductInfo[] products) {
        // IEnumerable<ProductInfo> allProducts = from product in products select product;

        IEnumerable<ProductInfo> allProducts = products.Select(product => product);

        Console.WriteLine("All products details: ");

        foreach (ProductInfo product in allProducts) {
            Console.WriteLine(product);
        }
    }

    private static void ListProductNames(ProductInfo[] products) {
        // IEnumerable<string> names = from product in products select product.Name;

        IEnumerable<string> names = products.Select(product => product.Name);

        Console.WriteLine("Only product names: ");

        foreach (string name in names) {
            Console.WriteLine(name);
        }
    }

    private static void GetOverstock(ProductInfo[] products) {
        // IEnumerable<ProductInfo> overstock =
        //     from product in products
        //     where product.NumberInStock > 25
        //     select product;

        IEnumerable<ProductInfo> overstock = products.Where(product => product.NumberInStock > 25);

        Console.WriteLine("Overstock items: ");

        foreach (ProductInfo product in overstock) {
            Console.WriteLine(product);
        }
    }


    private static Array GetNamesAndDescriptions(ProductInfo[] products) {
        // var nameDesc =
        //     (from product in products
        //         select new { product.Name, product.Description }).ToArray();

        var nameDesc = products.Select(product => new { product.Name, product.Description }).ToArray();

        Console.WriteLine("Names and Descriptions: ");

        foreach (var obj in nameDesc) {
            Console.WriteLine(obj);
        }

        return nameDesc;
    }

    private static ProductInfoSmall[] GetNamesAndDescriptionsTyped(ProductInfo[] products) {
        // ProductInfoSmall[] nameDesc =
        //     (from product in products
        //         select new ProductInfoSmall() { Name = product.Name, Description = product.Description }).ToArray();

        ProductInfoSmall[] nameDesc = products.Select(product => new ProductInfoSmall()
            { Name = product.Name, Description = product.Description }).ToArray();

        Console.WriteLine("Names and Descriptions: ");

        foreach (ProductInfoSmall obj in nameDesc) {
            Console.WriteLine(obj);
        }

        return nameDesc;
    }

    private static void AlphabetizeProductNames(ProductInfo[] products) {
        // IEnumerable<ProductInfo> subset =
        //     from product in products
        //     orderby product.Name ascending
        //     select product;

        IEnumerable<ProductInfo> subset =
            products.OrderBy(product => product.Name, StringComparer.InvariantCultureIgnoreCase);

        Console.WriteLine("Ordered by name: ");

        foreach (ProductInfo product in subset) {
            Console.WriteLine(product);
        }
    }

    private static void DisplayDiff() {
        // The Except() method returns those elements in first that don't appear in second.
        // It doesn't return those elements in second that don't appear in first.
        // Only unique elements are returned.

        // IEnumerable<string> carDiff =
        //     (from myCar in myCars
        //         select myCar).Except(from yourCar in yourCars select yourCar);

        IEnumerable<string> carDiff = MyCars.Except(YourCars);

        Console.WriteLine("Here is what you don't have, but I do: ");

        foreach (string car in carDiff) {
            Console.WriteLine(car);
        }
    }

    private static void DisplayIntersect() {
        // The Intersect() method will return a result set that contains the common data items in a set of containers.

        // IEnumerable<string> carIntersect =
        //     (from myCar in myCars
        //         select myCar).Intersect(from yourCar in yourCars select yourCar);

        IEnumerable<string> carIntersect = MyCars.Intersect(YourCars);

        Console.WriteLine("Here is what we have in common: ");

        foreach (string car in carIntersect) {
            Console.WriteLine(car);
        }
    }

    private static void DisplayUnion() {
        // The Union() method, returns a result set that includes all members of a batch of LINQ queries.

        // IEnumerable<string> carUnion =
        //     (from myCar in MyCars
        //         select myCar).Union(from yourCar in YourCars select yourCar);

        IEnumerable<string> carUnion = MyCars.Union(YourCars);

        Console.WriteLine("Here is everything: ");

        foreach (string car in carUnion) {
            Console.WriteLine(car);
        }
    }
}
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

    public static void Run() {
        const int choice = 4;

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
}
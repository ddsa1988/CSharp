using Section017_Delegates.Services;

namespace Section017_Delegates;

public class Example004 {
    public static void CallMain() {
        List<Product> products = new List<Product>();

        products.Add(new Product("Tv", 900.00F));
        products.Add(new Product("Mouse", 50.00F));
        products.Add(new Product("Tablet", 350.50F));
        products.Add(new Product("HD Case", 80.90F));

        PrintCollection(products);
        Console.WriteLine();

        Func<Product, string> ToUpperCase = product => product.Name.ToUpper();

        List<string> productNames = products.Select(ToUpperCase).ToList();

        PrintCollection(productNames);
    }

    // private static Func<Product, string> ToUpperCase = product => product.Name.ToUpper();

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T item in collection) {
            Console.WriteLine(item);
        }
    }
}
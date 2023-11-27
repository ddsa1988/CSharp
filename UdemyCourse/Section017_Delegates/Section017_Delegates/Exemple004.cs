using Section017_Delegates.Services;

namespace Section017_Delegates;

public class Exemple004 {
    public static void CallMain() {
        List<Product> products = new List<Product>();
        List<Product> productsUpperCase = new List<Product>();

        products.Add(new Product("Tv", 900.00F));
        products.Add(new Product("Mouse", 50.00F));
        products.Add(new Product("Tablet", 350.50F));
        products.Add(new Product("HD Case", 80.90F));


        PrintCollection(products);
        Console.WriteLine();

        foreach (Product product in products) {
            productsUpperCase.Add(ToUpperCase(product));
        }

        PrintCollection(productsUpperCase);
    }

    private static Func<Product, Product> ToUpperCase = product => {
        product.Name = product.Name.ToUpper();
        return product;
    };

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T item in collection) {
            Console.WriteLine(item);
        }
    }
}
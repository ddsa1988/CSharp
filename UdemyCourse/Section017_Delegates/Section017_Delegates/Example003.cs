using Section017_Delegates.Services;

namespace Section017_Delegates;

public class Example003 {
    public static void CallMain() {
        List<Product> products = new List<Product>();

        products.Add(new Product("Tv", 900.00F));
        products.Add(new Product("Mouse", 50.00F));
        products.Add(new Product("Tablet", 350.50F));
        products.Add(new Product("HD Case", 80.90F));

        PrintCollection(products);
        Console.WriteLine();

        //products.ForEach(product => product.Price += product.Price * (10F / 100F));
        Action<Product> action = AddPercentage;
        products.ForEach(action);
        PrintCollection(products);
    }

    private static void AddPercentage(Product product) {
        const float percent = 10F / 100F;
        product.Price += product.Price * percent;
    }

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T item in collection) {
            Console.WriteLine(item);
        }
    }
}
using Section017_Delegates.Services;

namespace Section017_Delegates;

public class Example002 {
    public static void CallMain() {

        List<Product> products = new List<Product>();
        
        products.Add(new Product("Tv", 900.00F));
        products.Add(new Product("Mouse", 50.00F));
        products.Add(new Product("Tablet", 350.50F));
        products.Add(new Product("HD Case", 80.90F));
        
        PrintCollection(products);
        Console.WriteLine();

        //products.RemoveAll(product => product.Price < 100F);
        Predicate<Product> predicate = ProductTest;
        products.RemoveAll(predicate);
        PrintCollection(products);
    }

    private static bool ProductTest(Product product) {
        return product.Price < 100F;
    }
    
    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T item in collection) {
            Console.WriteLine(item);
        }
    }
}
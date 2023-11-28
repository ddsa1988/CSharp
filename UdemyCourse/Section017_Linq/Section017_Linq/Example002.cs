using Section017_Linq.Entities;

namespace Section017_Linq;

public class Example002 {
    public static void CallMain() {
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00F));
        list.Add(new Product("Mouse", 50.00F));
        list.Add(new Product("Tablet", 350.50F));
        list.Add(new Product("HD Case", 80.90F));

        PrintCollection(list);

        IEnumerable<float> result = list.Where(p => p.Name[0] == 'T').Select(p => p.Price);
        float sum = result.Aggregate(0F, (acc, next) => acc + next);
        
        PrintCollection(result);
        Console.WriteLine(sum);
    }

    public static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T item in collection) {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
}
using Section017_Linq.Entities;

namespace Section017_Linq;

public class Example002 {
    public static void CallMain() {
        List<ProductType01> list = new List<ProductType01>();
        list.Add(new ProductType01("Tv", 900.00F));
        list.Add(new ProductType01("Mouse", 50.00F));
        list.Add(new ProductType01("Tablet", 350.50F));
        list.Add(new ProductType01("HD Case", 80.90F));

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
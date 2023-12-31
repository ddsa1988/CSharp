using Section017_Linq.Entities;

namespace Section017_Linq;

public class Example003 {
    public static void CallMain() {
        Category c1 = new Category("Tools", 1, 2);
        Category c2 = new Category("Computers", 2, 1);
        Category c3 = new Category("Electronics", 3, 1);

        List<ProductType02> products = new List<ProductType02>() {
            new ProductType02("Computer", 1, 1100F, c2),
            new ProductType02("Hammer", 2, 90F, c1),
            new ProductType02("Tv", 3, 1700F, c3),
            new ProductType02("Notebook", 4, 1300F, c2),
            new ProductType02("Saw", 5, 80F, c1),
            new ProductType02("Tablet", 6, 700F, c2),
            new ProductType02("Camera", 7, 700F, c3),
            new ProductType02("Printer", 8, 350F, c3),
            new ProductType02("MacBook", 9, 1800F, c2),
            new ProductType02("Sound Bar", 10, 700F, c3),
            new ProductType02("Level", 11, 70F, c1),
        };

        IEnumerable<ProductType02> r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900F);
        // IEnumerable<ProductType02> r1 = from p in products where p.Category.Tier == 1 && p.Price < 900F select p;
        PrintCollection(r1);

        IEnumerable<string> r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        // IEnumerable<string> r2 = from p in products where p.Category.Name == "Tools" select p.Name;
        PrintCollection(r2);

        IEnumerable<object> r3 = products.Where(p => p.Name.StartsWith('C'))
            .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
        // IEnumerable<object> r3 = from p in products
        //     where p.Name.StartsWith('C')
        //     select new { p.Name, p.Price, CategoryName = p.Category.Name };
        PrintCollection(r3);

        IEnumerable<ProductType02> r4 =
            products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        // IEnumerable<ProductType02> r4 = from p in products
        //     where p.Category.Tier == 1
        //     orderby p.Name, p.Price
        //     select p;
        PrintCollection(r4);

        IEnumerable<ProductType02> r5 = r4.Skip(2).Take(4);
        PrintCollection(r5);

        ProductType02? r6 = products.Where(p => p.Id == 3).SingleOrDefault();
        Console.WriteLine(r6);
        Console.WriteLine();

        IEnumerable<IGrouping<Category, ProductType02>> r7 = products.GroupBy(p => p.Category);
        // IEnumerable<IGrouping<Category, ProductType02>> r7 = from p in products group p by p.Category;

        foreach (IGrouping<Category, ProductType02> group in r7) {
            Console.WriteLine("Category " + group.Key.Name + ":");

            foreach (ProductType02 product in group) {
                Console.WriteLine(product);
            }

            Console.WriteLine();
        }
    }

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T obj in collection) {
            Console.WriteLine(obj);
        }

        Console.WriteLine();
    }
}
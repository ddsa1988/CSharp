namespace Section015_HashSetComparison;

public class Program {
    public static void Main(string[] args) {

        {
            HashSet<Product> products = new HashSet<Product>();
        
            Product p1 = new Product("TV", 1200);
            Product p2 = new Product("Iphone", 5000);
            Product p3 = new Product("Iphone", 5000);

            products.Add(p1);
            products.Add(p2);

            Console.WriteLine(products.Contains(p2));
            Console.WriteLine(products.Contains(p3));
        }

        Console.WriteLine();

        {
            HashSet<Point> points = new HashSet<Point>();

            Point p1 = new Point(5, 2);
            Point p2 = new Point(10, 20);
            Point p3 = new Point(5, 2);

            points.Add(p1);
            points.Add(p2);

            Console.WriteLine(points.Contains(p3));
        }
    }
}
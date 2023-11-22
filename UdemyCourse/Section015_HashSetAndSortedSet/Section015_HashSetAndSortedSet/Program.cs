namespace  Section015_HashSetAndSortedSet;

public class Program {
    public static void Main(string[] args) {

        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Diego");
            names.Add("Amanda");
            names.Add("Rodrigo");

            PrintCollection(names);
        }

        {
            SortedSet<int> a = new SortedSet<int>() { 10, 5, 15, 8, 3, 2 };
            SortedSet<int> b = new SortedSet<int>() { 1, 2, 5, 3, 2,10,20 };
            PrintCollection(a);
            PrintCollection(b);

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);
            
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);
            
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }
    }

    public static void PrintCollection<T>(IEnumerable<T> collection) {

        if (collection?.Count() == 0) return;
        
        foreach (T obj in collection) {
            Console.Write(obj + " ");
        }

        Console.WriteLine();
    }
}


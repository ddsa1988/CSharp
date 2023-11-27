namespace Section017_Delegates;

public class Exemple003 {
    public static void CallMain() { }

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T item in collection) {
            Console.WriteLine(item);
        }
    }
}
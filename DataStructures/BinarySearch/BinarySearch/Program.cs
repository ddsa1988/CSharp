namespace BinarySearch;

public static class Program {
    public static void Main(string[] args) {
        IEnumerable<int> numbers = Enumerable.Range(100, 10).ToArray();
        string[] names = ["Amanda", "Diego", "Rodrigo"];

        const int numberToSearch = 18;
        const string nameToSearch = "Diego";

        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        Console.WriteLine($"Index of '{numberToSearch}': {BinarySearch(numbers, numberToSearch)}");
        Console.WriteLine();

        Console.WriteLine("[" + string.Join(", ", names) + "]");
        Console.WriteLine($"Index of '{nameToSearch}': {BinarySearch(names, nameToSearch)}");
    }

    /// <summary>
    /// The collection must be sorted
    /// </summary>
    /// <param name="collection"></param>
    /// <param name="item"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>The item in the collection or -1</returns>
    private static int BinarySearch<T>(IEnumerable<T>? collection, T item) where T : IComparable<T> {
        if (collection == null) return -1;

        T[] arr = collection.ToArray();

        int low = 0;
        int high = arr.Length - 1;

        while (low <= high) {
            int middle = (low + high) / 2;
            int result = arr.ElementAt(middle).CompareTo(item);

            switch (result) {
                case < 0:
                    low = middle + 1;
                    break;
                case > 0:
                    high = middle - 1;
                    break;
                default:
                    return middle;
            }
        }

        return -1;
    }
}
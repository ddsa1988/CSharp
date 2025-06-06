namespace Chapter004.Iterators;

public static class Example001 {
    public static void Run() {
        // An iterator is a producer of an enumerator. 

        foreach (int number in GetNumber(10)) {
            Console.Write(number + " ");
        }
    }

    private static IEnumerable<int> GetNumber(int maxValue) {
        for (int i = 0; i < maxValue; i++) {
            yield return i;
            Console.WriteLine("Inside {0} method. ", nameof(GetNumber));
        }
    }
}
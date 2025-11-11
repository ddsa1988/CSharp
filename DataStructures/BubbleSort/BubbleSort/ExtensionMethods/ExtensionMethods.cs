namespace BubbleSort.ExtensionMethods;

public static class ExtensionMethods {
    // Bubbe sort: O(n²) => O(n x n)
    public static void BubbleSort<T>(this T[] array) where T : IComparable<T> {
        if (array.Length == 0) return;

        int lenght = array.Length;
        bool swapped = false;

        for (int i = 0; i < lenght - 1; i++) {
            for (int j = 0; j < lenght - i - 1; j++) {
                if (array[j].CompareTo(array[j + 1]) <= 0) continue;

                (array[j + 1], array[j]) = (array[j], array[j + 1]);
                swapped = true;
            }

            if (!swapped) break;
        }
    }
}
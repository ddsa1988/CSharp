namespace SelectionSort.ExtensionMethods;

public static class ExtensionMethods {
    // Selection sort: O(n²) => O(n x n)
    public static void SelectionSort<T>(this T[] array) where T : IComparable<T> {
        if (array.Length == 0) return;

        for (int i = 0; i < array.Length - 1; i++) {
            int smallestIndex = i;

            for (int j = i + 1; j < array.Length; j++) {
                if (array[j].CompareTo(array[smallestIndex]) < 0) {
                    smallestIndex = j;
                }
            }

            if (smallestIndex == i) continue;

            (array[i], array[smallestIndex]) = (array[smallestIndex], array[i]);
        }
    }
}
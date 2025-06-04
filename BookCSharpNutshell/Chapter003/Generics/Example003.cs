namespace Chapter003.Generics;

public static class Example003 {
    public static void Run() {
        // You can use the default keyword to get the default value for a generic type parameter. 

        int[] numbers = new int[5];
        string[] names = new string[5];

        InitializeArray(numbers);
        InitializeArray(names);

        PrintArray(numbers);
        PrintArray(names);
    }

    private static void InitializeArray<T>(T?[] arr) {
        int length = arr.Length;

        for (int i = 0; i < length; ++i) {
            arr[i] = default(T);
        }
    }

    private static void PrintArray<T>(T[] arr) {
        if (arr.Length == 0) {
            Console.WriteLine("[]");
            return;
        }

        Console.WriteLine("[{0}]", string.Join(", ", arr));
    }
}
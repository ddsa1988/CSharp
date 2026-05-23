namespace WorkingWithArrays.Examples;

public static class ArrayOfValueTypes {
    public static void Run() {
        int[] numbers = new int[10];

        Console.WriteLine(numbers.Length);
        Console.WriteLine(string.Join(", ", numbers));

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = i * 10;
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}
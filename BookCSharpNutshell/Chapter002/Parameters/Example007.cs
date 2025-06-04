namespace Chapter002.Parameters;

public static class Example007 {
    public static void Run() {
        /*
            The params modifier, if applied to the last parameter of a method, allows the
            method to accept any number of arguments of a particular type. The parameter
            type must be declared as a (single-dimensional) array.
        */

        int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

        Console.WriteLine(Sum());
        Console.WriteLine(Sum(null));
        Console.WriteLine(Sum(0, 1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine(Sum(numbers));
    }

    private static int Sum(params int[] numbers) {
        int sum = 0;

        if (numbers == null || numbers.Length == 0) {
            return sum;
        }

        foreach (int number in numbers) {
            sum += number;
        }

        return sum;
    }
}
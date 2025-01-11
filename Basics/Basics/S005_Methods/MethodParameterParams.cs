namespace Basics.S005_Methods;

public static class MethodParameterParams {
    public static void UserMain() {
        int[] numbers = [10, 20, 30];

        Console.WriteLine(Add(numbers));
        Console.WriteLine(Add(null, null));
        Console.WriteLine(Add("This is a message.", numbers));
    }

    private static int Add(params int[] numbers) {
        int sum = 0;

        if (numbers == null || numbers.Length == 0) return sum;

        foreach (int number in numbers) sum += number;

        return sum;
    }

    private static int Add(string msg, params int[] numbers) {
        int sum = 0;

        Console.WriteLine(msg);

        if (numbers == null || numbers.Length == 0) return sum;

        foreach (int number in numbers) sum += number;

        return sum;
    }
}
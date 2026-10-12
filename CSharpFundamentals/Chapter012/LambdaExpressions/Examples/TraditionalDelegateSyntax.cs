namespace LambdaExpressions.Examples;

internal static class TraditionalDelegateSyntax {
    public static void Run() {
        List<int> myList = [20, 1, 4, 8, 9, 44];

        Predicate<int> callback = IsEvenNumber;

        List<int> evenNumbers = myList.FindAll(callback);

        Console.WriteLine("Here are your even numbers:");

        foreach (int number in evenNumbers) {
            Console.Write(number + " ");
        }
    }

    private static bool IsEvenNumber(int number) {
        return number % 2 == 0;
    }
}
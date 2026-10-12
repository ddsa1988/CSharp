namespace LambdaExpressions.Examples;

internal static class AnonymousMethodSyntax {
    public static void Run() {
        List<int> myList = [20, 1, 4, 8, 9, 44];


        List<int> evenNumbers = myList.FindAll(delegate(int number) { return number % 2 == 0; });

        Console.WriteLine("Here are your even numbers:");

        foreach (int number in evenNumbers) {
            Console.Write(number + " ");
        }
    }
}
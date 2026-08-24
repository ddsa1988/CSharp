namespace UsingTuples.Examples;

internal static class CreatingTuples {
    internal static void Run() {
        {
            // (string, int, char) values = ("dog", 10, 'a');
            var values = ("dog", 10, 'a');

            Console.WriteLine("First item: " + values.Item1);
            Console.WriteLine("Second item: " + values.Item2);
            Console.WriteLine("Third item: " + values.Item3);
        }

        Console.WriteLine();

        {
            (string myString, int myInt, char myChar) values = ("dog", 10, 'a');
            Console.WriteLine("First item: " + values.myString);
            Console.WriteLine("Second item: " + values.myInt);
            Console.WriteLine("Third item: " + values.myChar);
        }

        Console.WriteLine();

        {
            var values = (myString: "dog", myInt: 10, myChar: 'a');
            Console.WriteLine("First item: " + values.myString);
            Console.WriteLine("Second item: " + values.myInt);
            Console.WriteLine("Third item: " + values.myChar);
        }

        Console.WriteLine();

        {
            var values = (5, 5, ('a', 'b'));
            Console.WriteLine("First item: " + values.Item1);
            Console.WriteLine("Second item: " + values.Item2);
            Console.WriteLine("Third item: " + values.Item3.Item1);
            Console.WriteLine("Fourth item: " + values.Item3.Item2);
        }
    }
}
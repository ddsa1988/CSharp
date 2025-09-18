namespace Examples.Dictionary;

public static class Example001 {
    public static void Run() {
        var peopleAge = new Dictionary<string, int>() {
            { "John", 4 },
            { "Jane", 3 },
        };

        Console.WriteLine($"{string.Join(", ", peopleAge)}\n");
        peopleAge.Add("Ana", 14);
        peopleAge["Victor"] = 9;

        Console.WriteLine($"{string.Join(", ", peopleAge)}\n");

        string[] names = peopleAge.Keys.ToArray();
        Console.WriteLine($"{string.Join(", ", names)}\n");

        int[] ages = peopleAge.Values.ToArray();
        Console.WriteLine($"{string.Join(", ", ages)}\n");

        {
            if (peopleAge.TryGetValue("Ana", out int value)) {
                Console.WriteLine($"Ana's age is {value}.");
            }
        }

        {
            peopleAge.Remove("Ana", out int value);
            Console.WriteLine($"Ana's age is {value}.\n");
        }

        Console.WriteLine($"{string.Join(", ", peopleAge)}\n");
    }
}
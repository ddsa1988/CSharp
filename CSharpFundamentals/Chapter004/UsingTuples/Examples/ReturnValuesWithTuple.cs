namespace UsingTuples.Examples;

internal static class ReturnValuesWithTuple {
    internal static void Run() {
        {
            (string first, string second, string third) = SplitFullName(" ");

            Console.WriteLine($"{first}, {second}, {third}");
        }

        Console.WriteLine();

        {
            (string first, string second, string third) = SplitFullName("Diego");

            Console.WriteLine($"{first}, {second}, {third}");
        }

        Console.WriteLine();

        {
            (string first, string second, string third) = SplitFullName("Diego Santos");

            Console.WriteLine($"{first}, {second}, {third}");
        }

        Console.WriteLine();

        {
            (string first, string second, string third) = SplitFullName("Diego Santos Alexandre");

            Console.WriteLine($"{first}, {second}, {third}");
        }

        Console.WriteLine();

        {
            (_, string second, _) = SplitFullName("Diego Santos Alexandre");

            Console.WriteLine(second);
        }
    }

    private static (string, string, string) SplitFullName(string fullName) {
        if (string.IsNullOrEmpty(fullName) || !fullName.Contains(' ')) {
            return (fullName, string.Empty, string.Empty);
        }

        string[] names = fullName.Split(' ');

        return names.Length switch {
            1 => (names[0], string.Empty, string.Empty),
            2 => (names[0], names[1], string.Empty),
            _ => (names[0], names[1], names[2])
        };
    }
}
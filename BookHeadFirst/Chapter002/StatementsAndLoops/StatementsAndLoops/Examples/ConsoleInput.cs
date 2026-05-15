namespace StatementsAndLoops.Examples;

public static class ConsoleInput {
    public static void Run() {
        string name = "";
        int age;

        while (true) {
            Console.Write("Enter your name: ");
            string? userInput = Console.ReadLine();

            if (userInput == null || userInput.Trim().Length == 0) {
                Console.WriteLine("Invalid name.");
                continue;
            }

            userInput = userInput.Trim().ToLower();

            name = CapitalizeWord(userInput);
            break;
        }

        while (true) {
            Console.Write($"Enter your age: ");
            string? userInput = Console.ReadLine();

            bool isAgeValid = int.TryParse(userInput, out age);

            if (!isAgeValid) {
                Console.WriteLine("Invalid age.");
                continue;
            }

            break;
        }

        Console.WriteLine($"Hello! Your name is {name} and you are {age} years old.");
    }

    private static string CapitalizeWord(string? word) {
        if (word == null || word.Trim().Length == 0) {
            return string.Empty;
        }

        string wordFormatted = word.Trim().ToLower();

        return char.ToUpper(wordFormatted[0]) + wordFormatted.Substring(1);
    }
}
namespace Basics.S002_SystemConsoleClass;

public static class BasicsConsoleIo {
    public static void UserMain() {
        Console.WriteLine("***** Basics Console IO *****\n");

        ConsoleColor original = Console.ForegroundColor;

        string userName = GetUserName();
        int age = GetAge();
        Greeting(userName, age);

        Console.ForegroundColor = original;
    }

    private static string GetUserName() {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string? userName;

        while (true) {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            bool isUserNameValid = !(string.IsNullOrEmpty(userName) || string.IsNullOrWhiteSpace(userName));

            if (!isUserNameValid) continue;

            break;
        }

        return userName ?? string.Empty;
    }

    private static int GetAge() {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int age;

        while (true) {
            Console.Write("Please enter your age: ");
            string? userAge = Console.ReadLine();

            bool isAgeValid = int.TryParse(userAge, out age) && age >= 0;

            if (!isAgeValid) continue;

            break;
        }

        return age;
    }

    private static void Greeting(string name, int age) {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"Hello, {name}! You are {age} years old.");
    }
}
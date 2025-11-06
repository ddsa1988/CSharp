namespace Examples.OutParameter;

public static class Example001 {
    public static void Run() {
        const string fullName = "Diego Santos Alexandre";

        Console.WriteLine(SplitFullName(fullName, out string firstName, out string lastName));

        Console.WriteLine($"{nameof(firstName)}: {firstName}");
        Console.WriteLine($"{nameof(lastName)}: {lastName}");
    }

    private static bool SplitFullName(string fullName, out string firstName, out string lastName) {
        firstName = string.Empty;
        lastName = string.Empty;

        if (string.IsNullOrEmpty(fullName.Trim())) return false;

        string[] parts = fullName.Trim().Split(' ');

        if (parts.Length >= 1) {
            firstName = parts[0];
        }

        if (parts.Length >= 2) {
            lastName = parts[^1];
        }

        return true;
    }
}
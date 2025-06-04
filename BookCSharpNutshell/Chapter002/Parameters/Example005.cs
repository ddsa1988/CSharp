namespace Chapter002.Parameters;

public static class Example005 {
    public static void Run() {
        //  The out argument is like a ref argument except for the following:
        //  • It need not be assigned before going into the function.
        //  • It must be assigned before it comes out of the function.

        const string fullName = "Diego dos Santos Alexandre";
        string firstName = string.Empty;
        string lastName = string.Empty;

        Console.WriteLine("Before method: ");
        Console.WriteLine("{0} = {1}", nameof(fullName), fullName);
        Console.WriteLine("{0} = {1}", nameof(firstName), firstName);
        Console.WriteLine("{0} = {1}", nameof(lastName), lastName);

        SplitFullName(fullName, out firstName, out lastName);

        // The "discard" symbol (_) is used when you don't want to receive values from all the parameters

        // SplitFullName(fullName, out firstName, out _);

        Console.WriteLine("\nAfter method: ");
        Console.WriteLine("{0} = {1}", nameof(fullName), fullName);
        Console.WriteLine("{0} = {1}", nameof(firstName), firstName);
        Console.WriteLine("{0} = {1}", nameof(lastName), lastName);
    }

    private static void SplitFullName(string fullName, out string firstName, out string lastName) {
        firstName = string.Empty;
        lastName = string.Empty;

        if (string.IsNullOrEmpty(fullName)) {
            return;
        }

        if (!fullName.Trim().Contains(' ')) {
            firstName = fullName;
            return;
        }

        string[] nameSplit = fullName.Trim().Split(' ');

        firstName = nameSplit[0];
        lastName = nameSplit[^1];
    }
}
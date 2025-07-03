namespace Chapter006.Strings;

public static class Example008 {
    public static void Run() {
        // String.Format and composite format strings

        {
            const string composite = "I was {0} degrees on {1} on this {2} morning.";
            string text = string.Format(composite, 8, "Curitiba", DateTime.Now.DayOfWeek);
            Console.WriteLine(text);
        }

        Console.WriteLine();

        {
            // string s = "Name = " + "Diego".PadRight(20) + " Credit Limit = " + 2000.ToString("C").PadLeft(15);

            // The minimum width is useful for aligning columns. If the value is negative, the data
            // is left-aligned; otherwise, it’s right-aligned.

            const string composite = "Name = {0,-20} Credit Limit = {1,15:C}";
            Console.WriteLine(composite, "Diego", 2000);
            Console.WriteLine(composite, "Amanda", 5000);
        }
    }
}
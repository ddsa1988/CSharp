using System.Reflection;

namespace ExtensionMethods.MyExtensionsMethods;

internal static class MyExtensions {
    // This method allows any object to display the assembly it is defined in
    public static void DisplayDefiningAssembly(this object obj) {
        Console.WriteLine($"{obj.GetType().Name} lives here: {Assembly.GetAssembly(obj.GetType())?.GetName().Name}");
    }

    // This method allows any integer to reverse its digits
    public static int ReverseDigits(this int i) {
        char[] digits = i.ToString().ToCharArray();

        Array.Reverse(digits);

        string newDigits = new string(digits);

        if (newDigits.ElementAt(newDigits.Length - 1) == '-') {
            newDigits = '-' + newDigits.Remove(newDigits.Length - 1);
        }

        return int.Parse(newDigits);
    }

    public static void PrintDataAndBeep(this System.Collections.IEnumerable iterator) {
        foreach (object obj in iterator) {
            Console.WriteLine(obj);
            Console.Beep();
        }
    }
}
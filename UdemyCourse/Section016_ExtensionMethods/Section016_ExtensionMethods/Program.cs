using Section016_ExtensionMethods.Extension;

namespace Section016_ExtensionMethods;

public class Program {
    public static void Main(string[] args) {

        DateTime date1 = new DateTime(2018, 11, 22, 8, 10, 45);
        DateTime date2 = new DateTime(2023, 11, 22, 20, 10, 45);
        Console.WriteLine(date1.ElapsedTime());
        Console.WriteLine(date2.ElapsedTime());

        Console.WriteLine();

        const string str1 = "Good morning dear students!";
        Console.WriteLine(str1.Cut(50));
        Console.WriteLine(str1.Cut(10));

        Console.WriteLine();

        string name1 = "dIEGO dos santos alexandre";
        string? name2 = null;
        string name3 = "dIeGo";
        string name4 = "dIEGOdossANtosAlexandre";

        Console.WriteLine(name1.ToTitleCase());
        Console.WriteLine(name2?.ToTitleCase());
        Console.WriteLine(name3.ToTitleCase());
        Console.WriteLine(name4.ToTitleCase());
    }
}
using System.Globalization;

namespace Basics.S003_SystemDateTime;

public static class BasicsDateTime {
    public static void UserMain() {
        DateTime now = DateTime.Now;
        var birthdate1 = new DateTime(1988, 1, 22);
        DateTime birthdate2 = DateTime.Parse("1988-01-22");
        DateTime birthdate3 = DateTime.ParseExact("22/01/1988", "mm/dd/yyyy", CultureInfo.InvariantCulture);

        TimeSpan elapsedTime = now - birthdate1;
        int age = elapsedTime.Days / 365;

        Console.WriteLine(now);
        Console.WriteLine(birthdate1);
        Console.WriteLine(birthdate2);
        Console.WriteLine(birthdate3);
        Console.WriteLine(age);
    }
}
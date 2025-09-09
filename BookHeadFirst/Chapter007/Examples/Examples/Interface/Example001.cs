using Examples.Interface.Models;

namespace Examples.Interface;

public static class Example001 {
    public static void Run() {
        var guy = new TallGuy() { Name = "Jim", Height = 76 };

        guy.TalkAboutYourself();
        guy.Honk();
        Console.WriteLine(guy.FunnyThingIHave);
    }
}
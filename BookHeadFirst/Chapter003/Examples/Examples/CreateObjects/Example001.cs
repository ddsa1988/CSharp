using Examples.Models;

namespace Examples.CreateObjects;

public static class Example001 {
    public static void Run() {
        var joe = new Player() { Name = "Joe", Cash = 50 };
        var bob = new Player() { Name = "Bob", Cash = 100 };

        joe.WriteMyInfo();
        bob.WriteMyInfo();
        Console.WriteLine();

        joe.ReceiveCash(bob.GiveCash(80));
        joe.WriteMyInfo();
        bob.WriteMyInfo();
        Console.WriteLine();

        bob.ReceiveCash(joe.GiveCash(20));
        joe.WriteMyInfo();
        bob.WriteMyInfo();
    }
}
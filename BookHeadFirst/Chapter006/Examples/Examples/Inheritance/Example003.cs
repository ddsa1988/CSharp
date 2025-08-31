using Examples.Models;

namespace Examples.Inheritance;

public static class Example003 {
    public static void Run() {
        var owner = new SafeOwner();
        var safe = new Safe();
        var jewelThief = new JewelThief();
        jewelThief.OpenSafe(safe, owner);
    }
}
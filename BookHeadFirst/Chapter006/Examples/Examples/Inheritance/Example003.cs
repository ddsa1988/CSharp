using Examples.Models;

namespace Examples.Inheritance;

public static class Example003 {
    public static void Run() {
        var owner = new SafeOwner();
        var safe = new Safe("precious jewels", "12345");
        var jewelThief = new JewelThief();
        jewelThief.OpenSafe(safe, owner);
    }
}
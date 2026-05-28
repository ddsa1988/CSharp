using Inheritance.Models;

namespace Inheritance.Examples;

public static class UsingSafeClass {
    public static void Run() {
        var owner = new SafeOwner();
        var safe = new Safe();
        var jewelThief = new JewelThief();
        jewelThief.OpenSafe(safe, owner);
    }
}
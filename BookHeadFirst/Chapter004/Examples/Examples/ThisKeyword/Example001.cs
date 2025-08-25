using Examples.ThisKeyword.Models;

namespace Examples.ThisKeyword;

public static class Example001 {
    public static void Run() {
        var diego = new Person() { Name = "Diego" };
        var amanda = new Person() { Name = "Amanda" };

        diego.SpeakTo(amanda, "Hello, are you there?");
    }
}
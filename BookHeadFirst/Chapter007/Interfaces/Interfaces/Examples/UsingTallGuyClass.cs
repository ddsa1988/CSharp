using Interfaces.Models;

namespace Interfaces.Examples;

public static class UsingTallGuyClass {
    public static void Run() {
        var tallGuy = new TallGuy() { Name = "Jimmy", Height = 76 };
        tallGuy.TalkAboutYourself();
        tallGuy.Honk();
    }
}
using ReferenceVariables.Models;

namespace ReferenceVariables.Examples;

public static class UsingObjectReferences {
    public static void Run() {
        var lloyd = new Elephant("Lloyd", 40);
        var lucinda = new Elephant("Lucinda", 33);

        lucinda.SpeakTo(lloyd, "Good morning!");
    }
}
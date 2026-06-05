namespace Interfaces.Models;

public class Wolf : Canine {
    public Wolf(bool belongsToPack) {
        BelongsToPack = belongsToPack;
    }

    public override void MakeNoise() {
        Console.WriteLine("I'm a wolf.");

        if (BelongsToPack) {
            Console.WriteLine("I'm in a pack.");
        }

        Console.WriteLine("I'm making noise.");
    }

    public void HuntInPack() {
        Console.WriteLine(BelongsToPack ? "I'm going hunting with my pack." : "I'm going hunting without my pack.");
    }
}
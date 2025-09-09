namespace Examples.Models;

public abstract class Animal {
    public abstract void MakeNoise();
}

public abstract class Canine : Animal {
    protected bool BelongsToPack { get; init; }
}

public class Hippo : Animal {
    public override void MakeNoise() {
        Console.WriteLine("Hippo make noise.");
    }

    public void Swim() {
        Console.WriteLine("Hippo swim.");
    }
}

public class Wolf : Canine {
    public Wolf(bool belongsToPack) {
        BelongsToPack = belongsToPack;
    }

    public override void MakeNoise() {
        Console.WriteLine("Wolf make noise.");
    }

    public void HuntInPack() {
        Console.WriteLine(BelongsToPack ? "Wolf hunts in a pack." : "Wolf hunts alone.");
    }
}
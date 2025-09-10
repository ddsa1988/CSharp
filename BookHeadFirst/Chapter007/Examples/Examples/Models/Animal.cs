namespace Examples.Models;

public abstract class Animal {
    public abstract void MakeNoise();
}

public abstract class Canine : Animal {
    protected bool BelongsToPack { get; init; }
}

public interface ISwimmer {
    public void Swim();
}

public interface IPackHunter {
    public void HuntInPack();
}

public class Hippo : Animal, ISwimmer {
    public override void MakeNoise() {
        Console.WriteLine("Hippo make noise.");
    }

    public void Swim() {
        Console.WriteLine("Hippo swim.");
    }
}

public class Wolf : Canine, IPackHunter {
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
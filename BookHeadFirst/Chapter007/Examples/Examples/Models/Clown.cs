namespace Examples.Models;

public interface IScaryClown : IClown {
    public string ScaryThingIHave { get; }
    public void ScareLittleChildren();
}

public class FunnyFunny : IClown {
    public string FunnyThingIHave { get; }

    protected FunnyFunny(string funnyThingIHave) {
        FunnyThingIHave = funnyThingIHave;
    }

    public void Honk() {
        Console.WriteLine($"Hi kids! I have {FunnyThingIHave}.");
    }
}

public class ScaryScary : FunnyFunny, IScaryClown {
    private readonly int _scaryThingCount;

    public ScaryScary(string funnyThingIHave, int scaryThingCount) : base(funnyThingIHave) {
        _scaryThingCount = scaryThingCount;
    }

    public string ScaryThingIHave => $"{_scaryThingCount} spiders";

    public void ScareLittleChildren() {
        Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}.");
    }
}
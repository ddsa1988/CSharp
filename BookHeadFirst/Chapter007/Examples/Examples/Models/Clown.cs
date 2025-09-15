namespace Examples.Models;

public interface IClown {
    private static int _carCapacity = 12;
    protected static readonly Random Random = new Random();
    public string FunnyThingIHave { get; }
    public void Honk();

    public static int CarCapacity {
        get => _carCapacity;
        set {
            if (value <= 10) {
                Console.Error.WriteLine($"Car capacity {value} is too small.");
                return;
            }

            _carCapacity = value;
        }
    }

    public static string ClownCarDescription() {
        return $"A clown car with {Random.Next(CarCapacity / 2, CarCapacity)}";
    }
}

public interface IScaryClown : IClown {
    public string ScaryThingIHave { get; }
    public void ScareLittleChildren();

    public void ScareAdults() {
        Console.WriteLine($"""
                           I am an ancient evil that will haunt your dreams.
                           Behold my terrifying necklace with {Random.Next(4, 10)} of my last victim's fingers.
                           Oh, also, before I forget...
                           """);
        ScareLittleChildren();
    }
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
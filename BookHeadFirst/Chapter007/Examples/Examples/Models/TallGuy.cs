namespace Examples.Models;

public interface IClown {
    public string FunnyThingIHave { get; }
    public void Honk();
}

public class TallGuy : IClown {
    private string _funnyThingIHave = "Big shoes.";
    public string Name { get; init; } = string.Empty;
    public int Height { get; init; }

    public void TalkAboutYourself() {
        Console.WriteLine($"My names is {Name} and I'm {Height} inches tall.");
    }

    public string FunnyThingIHave {
        get => _funnyThingIHave;
        set => _funnyThingIHave = string.IsNullOrEmpty(value) ? string.Empty : value;
    }

    public void Honk() {
        Console.WriteLine("Tall Guy Honk!!!");
    }
}
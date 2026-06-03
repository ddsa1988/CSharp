namespace Interfaces.Models;

public class TallGuy : IClown {
    public string Name { get; init; } = string.Empty;
    public int Height { get; init; }

    public string FunnyThingIHave => "Big shoes.";

    public void TalkAboutYourself() {
        Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
    }

    public void Honk() {
        Console.WriteLine($"Tall guy says: Honk honk.");
    }
}
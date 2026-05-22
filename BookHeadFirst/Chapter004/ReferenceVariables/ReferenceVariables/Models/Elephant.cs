namespace ReferenceVariables.Models;

public class Elephant {
    public string Name { get; }
    public int EarSize { get; }

    public Elephant(string name, int earSize) {
        Name = name;
        EarSize = earSize;
    }

    public void WhoAmI() {
        Console.WriteLine($"My name is {Name}.");
        Console.WriteLine($"My years are {EarSize} inches tall.");
    }
}
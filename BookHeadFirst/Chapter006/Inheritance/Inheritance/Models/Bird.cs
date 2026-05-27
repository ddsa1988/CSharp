namespace Inheritance.Models;

public class Bird {
    protected static readonly Random Random = new();

    public virtual Egg[] LayEggs(int numberOfEggs) {
        Console.Error.WriteLine("Bird.LayEggs: should never be called");
        return Enumerable.Empty<Egg>().ToArray();
    }
}
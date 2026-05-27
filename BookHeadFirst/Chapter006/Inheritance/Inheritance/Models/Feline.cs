namespace Inheritance.Models;

public class Feline : Animal {
    public override void Sleep() {
        Console.WriteLine($"Feline: {Name} is sleeping");
    }

    public override void Roam() {
        Console.WriteLine($"Feline: {Name} is roaming");
    }

    public void Run() {
        Console.WriteLine($"Feline: {Name} is running");
    }
}
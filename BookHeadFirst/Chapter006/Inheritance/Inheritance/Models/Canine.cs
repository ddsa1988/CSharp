namespace Inheritance.Models;

public class Canine : Animal {
    public override void MakeSound() {
        Console.WriteLine($"Canine: {Name} is making sound");
    }

    public override void Eat() {
        Console.WriteLine($"Canine: {Name} is eating");
    }

    public void Bark() {
        Console.WriteLine($"Canine: {Name} is barking");
    }
}
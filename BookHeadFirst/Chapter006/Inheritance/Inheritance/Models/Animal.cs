namespace Inheritance.Models;

public class Animal {
    public string Name { get; set; } = string.Empty;
    public string Food { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;

    public void MakeSound() {
        Console.WriteLine($"Animal: {Name} is making sound");
    }

    public void Eat() {
        Console.WriteLine($"Animal: {Name} is eating");
    }

    public void Sleep() {
        Console.WriteLine($"Animal: {Name} is sleeping");
    }

    public void Roam() {
        Console.WriteLine($"Animal: {Name} is roaming");
    }
}
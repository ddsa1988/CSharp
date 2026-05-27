namespace Inheritance.Models;

public class Animal {
    public string Name { get; set; } = string.Empty;
    public string Food { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;

    public virtual void MakeSound() {
        Console.WriteLine($"Animal: {Name} is making sound");
    }

    public virtual void Eat() {
        Console.WriteLine($"Animal: {Name} is eating");
    }

    public virtual void Sleep() {
        Console.WriteLine($"Animal: {Name} is sleeping");
    }

    public virtual void Roam() {
        Console.WriteLine($"Animal: {Name} is roaming");
    }

    public override string ToString() {
        return "{ Animal: " + Name + ", Food: " + Food + ", Location: " + Location + " }";
    }
}
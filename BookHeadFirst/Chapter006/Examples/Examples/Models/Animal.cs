namespace Examples.Models;

public class Animal {
    public required string Name { get; set; }

    public virtual void MakeSound() {
        Console.WriteLine($"{Name} is making Sound.");
    }
}

public class Hippo : Animal {
    public override void MakeSound() {
        Console.WriteLine($"{Name} is making hippo sound.");
    }

    public void Eat() {
        Console.WriteLine($"{Name} is eating.");
    }
}

public class Canine : Animal {
    public bool IsAlphaInThePack;

    public virtual void Sleep() {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

public class Dog : Canine {
    public required string Breed;

    public override void MakeSound() {
        Console.WriteLine($"{Name} is making dog sound.");
    }
}
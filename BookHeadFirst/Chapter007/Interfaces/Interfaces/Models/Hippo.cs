namespace Interfaces.Models;

public class Hippo : IAnimal {
    public void MakeNoise() {
        Console.WriteLine("I'm Hippo. I'm making noise.");
    }

    public void Swim() {
        Console.WriteLine("I'm Hippo. I'm swimming.");
    }
}
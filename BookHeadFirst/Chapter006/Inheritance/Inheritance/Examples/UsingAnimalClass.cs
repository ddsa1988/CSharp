using Inheritance.Models;

namespace Inheritance.Examples;

public static class UsingAnimalClass {
    public static void Run() {
        Animal[] animals = [
            new Animal() { Name = "Animal 1", Food = "Food 1", Location = "Location 1" },
            new Canine() { Name = "Canine 1", Food = "Food 2", Location = "Location 2" },
            new Feline() { Name = "Feline 1", Food = "Food 3", Location = "Location 3" }
        ];

        foreach (Animal animal in animals) {
            Console.WriteLine(animal);
            Console.WriteLine(animal.GetType());
            Console.WriteLine(animal.GetType() == typeof(Animal));
            Console.WriteLine(animal.GetType() == typeof(Canine));
            Console.WriteLine(animal.GetType() == typeof(Feline));
            Console.WriteLine();
        }
    }
}
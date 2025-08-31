using Examples.Models;

namespace Examples.Inheritance;

public static class Example002 {
    public static void Run() {
        var hippo = new Hippo() { Name = "Hippo" };
        var canine = new Canine() { Name = "Canine" };
        var dog = new Dog() { Name = "Dog", Breed = "Unknow" };

        PrintName(hippo);
        PrintName(dog);
        PrintName(canine);
    }

    private static void PrintName(Animal animal) {
        Console.WriteLine($"Animal name => {animal.Name}");
    }
}
using Examples.Models;

namespace Examples.Inheritance;

public static class Example001 {
    public static void Run() {
        var hippo = new Hippo() { Name = "Hippo" };
        var canine = new Canine() { Name = "Canine" };
        var dog = new Dog() { Name = "Dog", Breed = "Unknow" };

        hippo.MakeSound();
        canine.MakeSound();
        dog.MakeSound();
    }
}
namespace Basics.S011_ObjectOrientedProgramming.Models;

public class Car {
    // The 'state' of the Car
    public string? PetName { get; set; }
    public int CurrentSpeed { get; set; }

    // Default custom constructors
    public Car() : this("string.Empty") { }

    public Car(string petName) {
        PetName = petName;
    }

    public Car(string petName, int currentSpeed) : this(petName) {
        CurrentSpeed = currentSpeed;
    }

    // The 'behaviors' of the Car
    public void PrintState() {
        Console.WriteLine($"{PetName} is going {CurrentSpeed} km/h.");
    }

    public void SpeedUp(int value) {
        CurrentSpeed += value;
    }
}
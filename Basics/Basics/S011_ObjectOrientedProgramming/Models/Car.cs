namespace Basics.S011_ObjectOrientedProgramming.Models;

public class Car {
    // Default custom constructors
    public Car() : this(string.Empty, 0) { }
    public Car(string petName) : this(petName, 0) { }
    public Car(int currentSpeed) : this(string.Empty, currentSpeed) { }

    public Car(string petName, int currentSpeed) {
        PetName = petName;
        CurrentSpeed = currentSpeed;
    }

    // The 'state' of the Car
    public string? PetName { get; set; }
    public int CurrentSpeed { get; set; }

    // The 'behaviors' of the Car
    public void PrintState() {
        Console.WriteLine($"{PetName} is going {CurrentSpeed} km/h.");
    }

    public void SpeedUp(int value) {
        CurrentSpeed += value;
    }
}
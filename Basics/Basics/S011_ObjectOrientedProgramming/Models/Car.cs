namespace Basics.S011_ObjectOrientedProgramming.Models;

public class Car {
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
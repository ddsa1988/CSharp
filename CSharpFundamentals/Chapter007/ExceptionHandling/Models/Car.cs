namespace ExceptionHandling.Models;

internal class Car {
    // Constants
    public const int MaxSpeed = 100;

    // Properties
    public int CurrentSpeed { get; set; }
    public string PetName { get; set; }

    // Is the car still operational?
    private bool _carIsDead;

    // Car has-a radio
    private readonly Radio _radio = new();

    // Constructors
    public Car() : this("Unknown", 0) { }

    public Car(string petName, int speed) {
        PetName = petName;
        CurrentSpeed = speed;
    }

    public void CrankTunes(bool state) {
        // Delegate request to inner object
        _radio.TurnOn(state);
    }

    // See if Car has overheated
    public void Accelerate(int delta) {
        if (!_carIsDead) {
            Console.WriteLine($"{PetName} is out of order...");
            return;
        }

        CurrentSpeed += delta;

        if (CurrentSpeed > MaxSpeed) {
            Console.WriteLine($"{PetName} has overheated!");
            CurrentSpeed = 0;
            _carIsDead = true;
        }

        Console.WriteLine($"=> Current speed: {CurrentSpeed}");
    }
}
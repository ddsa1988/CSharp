using ProcessMultipleExceptions.Exceptions;

namespace ProcessMultipleExceptions.Models;

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
        if (_carIsDead) {
            Console.WriteLine($"{PetName} is out of order...");
            return;
        }

        if (delta < 0) {
            throw new ArgumentOutOfRangeException(nameof(delta), "Speed must be greater than or equal to 0.");
        }

        CurrentSpeed += delta;

        if (CurrentSpeed > MaxSpeed) {
            CurrentSpeed = 0;
            _carIsDead = true;

            throw new CarIsDeadException("You have a lead foot.", DateTime.Now, $"{PetName} has overheated!") {
                HelpLink = "https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/",
            };
        }

        Console.WriteLine($"=> Current speed: {CurrentSpeed}");
    }
}
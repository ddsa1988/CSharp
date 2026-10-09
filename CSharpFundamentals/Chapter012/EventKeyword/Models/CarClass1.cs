namespace EventKeyword.Models;

internal class CarClass1 {
    private bool _isCarDead;
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string Name { get; set; }

    public delegate void CarEngineHandler(string msgForCaller);

    public event CarEngineHandler? Exploded;
    public event CarEngineHandler? AboutToBlow;

    public CarClass1(string name, int maxSpeed, int currentSpeed) {
        CurrentSpeed = currentSpeed;
        MaxSpeed = maxSpeed;
        Name = name;
    }


    public void Accelerate(int delta) {
        if (_isCarDead) {
            Exploded?.Invoke("Sorry, Car is dead...");
            return;
        }

        CurrentSpeed += delta;

        if (MaxSpeed - CurrentSpeed <= 10) {
            AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
        }

        if (CurrentSpeed > MaxSpeed) {
            _isCarDead = true;
            return;
        }

        Console.WriteLine($"Current speed: {CurrentSpeed}");
    }
}
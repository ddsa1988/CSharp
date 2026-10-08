namespace Delegates.Models;

internal class Car {
    private bool _IsCarDead;
    private CarEngineHandler _listOfHandlers;
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string Name { get; set; }

    public delegate void CarEngineHandler(string msgForCaller);

    public Car(string name, int maxSpeed, int currentSpeed) {
        CurrentSpeed = currentSpeed;
        MaxSpeed = maxSpeed;
        Name = name;
    }

    public void RegisterWithCarEngine(CarEngineHandler methodToCall) {
        _listOfHandlers = methodToCall;
    }

    public void Accelerate(int delta) {
        if (_IsCarDead) {
            _listOfHandlers?.Invoke("Sorry, Car is dead...");
            return;
        }

        CurrentSpeed += delta;

        if (MaxSpeed - CurrentSpeed <= 10) {
            _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
        }

        if (CurrentSpeed > MaxSpeed) {
            _IsCarDead = true;
            return;
        }

        Console.WriteLine($"Current speed: {CurrentSpeed}");
    }
}
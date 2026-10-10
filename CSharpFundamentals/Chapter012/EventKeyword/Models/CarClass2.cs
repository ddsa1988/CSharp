namespace EventKeyword.Models;

internal class CarClass2 {
    private bool _isCarDead;
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string Name { get; set; }

    public delegate void CarEngineHandler(object sender, CarEventArgs e);

    public event CarEngineHandler? Exploded;
    public event CarEngineHandler? AboutToBlow;

    public CarClass2(string name, int maxSpeed, int currentSpeed) {
        CurrentSpeed = currentSpeed;
        MaxSpeed = maxSpeed;
        Name = name;
    }


    public void Accelerate(int delta) {
        if (_isCarDead) {
            Exploded?.Invoke(this, new CarEventArgs("Sorry, Car is dead..."));
            return;
        }

        CurrentSpeed += delta;

        if (MaxSpeed - CurrentSpeed <= 10) {
            AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
        }

        if (CurrentSpeed > MaxSpeed) {
            _isCarDead = true;
            return;
        }

        Console.WriteLine($"Current speed: {CurrentSpeed}");
    }
}
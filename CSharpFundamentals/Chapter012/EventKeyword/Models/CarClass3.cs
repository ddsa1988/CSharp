namespace EventKeyword.Models;

internal class CarClass3 {
    private bool _isCarDead;
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string Name { get; set; }

    public event EventHandler<CarEventArgs>? Exploded;
    public event EventHandler<CarEventArgs>? AboutToBlow;

    public CarClass3(string name, int maxSpeed, int currentSpeed) {
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
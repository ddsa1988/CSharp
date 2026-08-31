namespace BasicInheritance.Models;

internal class Car {
    private int _currentSpeed;
    public readonly int MaxSpeed;

    public Car() : this(55) { }

    public Car(int maxSpeed) {
        MaxSpeed = maxSpeed;
    }

    public int Speed {
        get => _currentSpeed;
        set => _currentSpeed = value < MaxSpeed ? value : MaxSpeed;
    }

    public override string ToString() {
        return $"Car {{ Speed: {Speed}, MaxSpeed: {MaxSpeed} }}";
    }
}
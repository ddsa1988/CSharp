namespace SimpleClassExample.Models;

internal class Car {
    // The 'state' of the car
    private readonly string _owner;
    private int _currenSpeed;

    // Custom default constructor
    public Car() {
        _owner = string.Empty;
        _currenSpeed = 0;
    }

    // Custom constructor
    public Car(string owner, int currenSpeed) {
        _owner = owner;
        _currenSpeed = currenSpeed;
    }

    public void PrintState() => Console.WriteLine($"{_owner} is going {_currenSpeed} km/h.");

    public void SpeedUp(int delta) => _currenSpeed += delta;
}
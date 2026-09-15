namespace ComparableCar.Models;

internal class Car : IComparable<Car> {
    // Constants
    public const int MaxSpeed = 100;

    // Properties
    public int CurrentSpeed { get; set; }
    public string PetName { get; set; }
    public int CarId { get; set; }

    // Is the car still operational?
    private bool _carIsDead;

    // Car has-a radio
    private readonly Radio _radio = new();

    // Constructors
    public Car() : this("Unknown", 0, 0) { }

    public Car(string petName, int speed, int id) {
        PetName = petName;
        CurrentSpeed = speed;
        CarId = id;
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
            return;
        }

        CurrentSpeed += delta;

        if (CurrentSpeed > MaxSpeed) {
            CurrentSpeed = 0;
            _carIsDead = true;

            return;
        }

        Console.WriteLine($"=> Current speed: {CurrentSpeed}");
    }

    public override string ToString() {
        return
            $"Car {{ {nameof(CarId)} = {CarId}, {nameof(PetName)} =  {PetName}, {nameof(CurrentSpeed)} = {CurrentSpeed} }}";
    }

    // IComparable implementation
    public int CompareTo(Car? other) {
        if (ReferenceEquals(this, other)) return 0;
        // if (ReferenceEquals(null, other)) return 1;
        //
        // if (CarId > other.CarId) return 1;
        // if (CarId < other.CarId) return -1;
        // return 0;

        return other == null ? 1 : CarId.CompareTo(other.CarId);
    }
}
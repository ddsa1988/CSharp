namespace SimpleGC.Models;

internal class Car:IDisposable {
    public int CurrentSpeed { get; set; }
    public string Name { get; set; }

    public Car(string name, int speed) {
        Name = name;
        CurrentSpeed = speed;
    }
    
    public Car():this(string.Empty, 0) { }

    public override string ToString() {
        return $"Car {{ {nameof(Name)} = {Name}, {nameof(CurrentSpeed)} = {CurrentSpeed} }}";
    }

    // The object user should call this method when they finish with the object
    public void Dispose() {
        // TODO release managed resources here
        Console.WriteLine("***** In Dispose! *****");
    }
}


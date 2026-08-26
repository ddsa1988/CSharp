namespace SimpleClassExample.Models;

internal class Motorcycle {
    public string DriverName { get; private set; }
    public int DriverIntensity { get; private set; }

    public Motorcycle() : this(string.Empty, 0) {
        Console.WriteLine("Default Motorcycle");
    }

    public Motorcycle(string name) : this(name, 0) {
        Console.WriteLine("Constructor taking a string.");
    }

    public Motorcycle(int intensity) : this(string.Empty, intensity) {
        Console.WriteLine("Constructor taking an int.");
    }

    // 'Main" constructor
    public Motorcycle(string driverName, int driverIntensity) {
        DriverName = driverName;
        SetDriverIntensity(driverIntensity);

        Console.WriteLine("Main constructor.");
    }

    private void SetDriverIntensity(int intensity) {
        if (intensity > 10) {
            DriverIntensity = 10;
            return;
        }

        DriverIntensity = intensity;
    }
}
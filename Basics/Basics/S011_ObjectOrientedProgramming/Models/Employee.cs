namespace Basics.S011_ObjectOrientedProgramming.Models;

public class Employee {
    // Field data
    private int _id;
    private string _name;
    private float _pay;

    // Constructors
    public Employee(string name, int id, float pay) {
        Name = name;
        Id = id;
        Pay = pay;
    }

    // Properties
    public string Name {
        get => _name;
        set {
            ArgumentException.ThrowIfNullOrEmpty(value, nameof(value));
            ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(value));
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Length, 15, nameof(value));
            _name = value;
        }
    }

    public int Id {
        get => _id;
        set {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 0, nameof(value));
            _id = value;
        }
    }

    public float Pay {
        get => _pay;
        set {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(value, 0, nameof(value));
            _pay = value;
        }
    }

    public override string ToString() {
        return $"Name: {Name}, Id: {Id}, Pay: {Pay}";
    }
}
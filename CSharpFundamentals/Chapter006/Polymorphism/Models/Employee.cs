namespace Polymorphism.Models;

// Encapsulation using properties
internal abstract class Employee {
    // Field data
    private string _name = string.Empty;
    private readonly Guid _id;
    private float _salary;

    // Constructor
    public Employee(string name, float salary) {
        Name = name;
        Salary = salary;

        _id = Guid.CreateVersion7();
    }

    // Properties
    public string Name {
        get => _name;
        set {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentException("Name cannot be null or empty");
            }

            if (value.Length > 15) {
                throw new ArgumentException("Name cannot be longer than 15 characters");
            }

            _name = value;
        }
    }

    public float Salary {
        get => _salary;
        set {
            if (value < 0) {
                throw new ArgumentException("Salary cannot be negative");
            }

            _salary = value;
        }
    }

    // Methods
    public string GetId() => _id.ToString();

    public virtual void GiveBonus(float amount) {
        Salary += amount;
    }

    public override string ToString() {
        return $"Employee {{ Name: {Name}, Id: {GetId()}, Salary: {Salary} }}";
    }
}
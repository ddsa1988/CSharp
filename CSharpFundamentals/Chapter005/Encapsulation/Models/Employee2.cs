namespace Encapsulation.Models;

// Encapsulation using properties
internal class Employee2 {
    // Field data
    private string _name = string.Empty;
    private readonly Guid _id;
    private float _salary;

    // Constructor
    public Employee2(string name, float salary) {
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

    // Getter
    public string Id() => _id.ToString();

    // Methods
    public void GiveBonus(float amount) {
        _salary += amount;
    }

    public override string ToString() {
        return $"Name: {_name}, Id: {_id}, Salary: {_salary}";
    }
}
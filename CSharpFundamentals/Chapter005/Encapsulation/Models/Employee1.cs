namespace Encapsulation.Models;

// Encapsulation using getters (accessor) and setters (mutator)
internal class Employee1 {
    // Field data
    private string _name = string.Empty;
    private readonly Guid _id;
    private float _salary;

    // Constructor
    public Employee1(string name, float salary) {
        SetName(name);
        SetSalary(salary);

        _id = Guid.CreateVersion7();
    }

    // Getters
    public string GetName() => _name;

    public string GetId() => _id.ToString();

    public float GetSalary() => _salary;


    // Setters
    public void SetName(string name) {
        if (string.IsNullOrEmpty(name)) {
            throw new ArgumentException("Name cannot be null or empty");
        }

        if (name.Length > 15) {
            throw new ArgumentException("Name cannot be longer than 15 characters");
        }

        _name = name;
    }

    public void SetSalary(float salary) {
        if (salary < 0) {
            throw new ArgumentException("Salary cannot be negative");
        }

        _salary = salary;
    }

    // Methods
    public void GiveBonus(float amount) {
        _salary += amount;
    }

    public override string ToString() {
        return $"Name: {_name}, Id: {_id}, Salary: {_salary}";
    }
}
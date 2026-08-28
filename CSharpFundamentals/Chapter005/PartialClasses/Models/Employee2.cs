namespace PartialClasses.Models;

internal partial class Employee {
    // Field data
    private DateTime _birthDate;

    // Constructor
    public Employee(string name, float salary, DateTime birthDate) : this(name, salary) {
        BirthDate = birthDate;
    }

    public DateTime BirthDate {
        get => _birthDate;
        set {
            DateTime now = DateTime.Now;
            TimeSpan diff = now.Subtract(value);

            if (diff.Days < 0) {
                throw new ArgumentException("BirthDate must be greater than today's date");
            }

            _birthDate = value;
        }
    }

    // Methods
    public void GiveBonus(float amount) {
        Salary += amount;
    }
}
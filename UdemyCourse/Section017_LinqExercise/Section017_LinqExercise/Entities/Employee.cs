using System.Globalization;

namespace Section017_LinqExercise.Entities;

public class Employee {
    private float salary;
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";

    public Employee(string name, string email, float salary) {
        Name = name;
        Email = email;
        Salary = salary;
    }

    public float Salary {
        get => salary;
        set => salary = value > 0 ? value : 0;
    }

    public override string ToString() {
        return "Name: " + Name +
               " Email: " + Email +
               " Salary: $" + Salary.ToString("F2", CultureInfo.InvariantCulture);
    }
}
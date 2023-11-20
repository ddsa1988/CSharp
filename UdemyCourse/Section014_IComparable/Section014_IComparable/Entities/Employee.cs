using System.Globalization;

namespace Section014_IComparable.Entities; 

public class Employee : IComparable {

    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    private double salary;
    public string Name { get; set; } = "";

    public Employee(string txtEmployee) {
        if (!txtEmployee.Contains(',')) return;
        
        string[] data = txtEmployee.Split(",");
        Name = data[0];
        Salary = double.Parse(data[1], cultureInfo);
    }

    public double Salary {
        get { return salary; }
        set { salary = value > 0 ? value : 0; }
    }

    public override string ToString() {
        return "Name: " + Name +
               " - Salary: $" + Salary.ToString("F2", cultureInfo);
    }

    public int CompareTo(object? obj) {

        if (obj is not Employee) {
            throw new ArgumentException("Comparing error: argument is not a Employee");
        }
        
        Employee? other = obj as Employee;
        
        return Salary.CompareTo(other?.Salary);
    }
}
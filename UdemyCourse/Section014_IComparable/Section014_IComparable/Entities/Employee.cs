using System.Globalization;

namespace Section014_IComparable.Entities; 

public class Employee : IComparable<Employee> {

    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    private double salary;
    public string Name { get; set; } = "";

    public Employee(string txtEmployee) {
        SetEmployee(txtEmployee);
    }

    private void SetEmployee(string txtEmployee) {
        if (!txtEmployee.Contains(',')) return;

        string[] data = txtEmployee.Split(",");

        if (string.IsNullOrEmpty(data[0]) || string.IsNullOrWhiteSpace(data[0])) return;

        try {
            Salary = double.Parse(data[1], cultureInfo);
            Name = data[0];
        } catch (Exception e) {
            // Console.WriteLine(e.Message);
        }
    }

    public double Salary {
        get { return salary; }
        set { salary = value > 0 ? value : 0; }
    }

    public int CompareTo(Employee? other) {
        return string.CompareOrdinal(Name, other?.Name);
    }

    public override string ToString() {
        return "Name: " + Name +
               " - Salary: $" + Salary.ToString("F2", cultureInfo);
    }
    
    public class SortBySalaryAscending : IComparer<Employee> {
        public int Compare(Employee? x, Employee? y) {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return x.Salary.CompareTo(y.Salary);
        }
    }
    
    public class SortBySalaryDescending : IComparer<Employee> {
        public int Compare(Employee? x, Employee? y) {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return y.Salary.CompareTo(x.Salary);
        }
    }
}
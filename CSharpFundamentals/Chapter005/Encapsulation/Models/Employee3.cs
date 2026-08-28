using Encapsulation.Enums;

namespace Encapsulation.Models;

// Encapsulation using properties
internal class Employee3 {
    // Field data
    private string _name = string.Empty;
    private readonly Guid _id;
    private float _salary;
    public EmployeePayTypeEnum PayType { get; set; }
    public DateOnly HireDate { get; set; }

    // Constructor
    public Employee3(string name, float salary, EmployeePayTypeEnum payType, DateOnly hireDate) {
        Name = name;
        Salary = salary;
        PayType = payType;
        HireDate = hireDate;

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

    public void GiveBonus(float amount) {
        Salary = this switch {
            { PayType: EmployeePayTypeEnum.Commissioned, HireDate: { Year: > 2020 } } => Salary += 0.10f * amount,
            { PayType: EmployeePayTypeEnum.Hourly, HireDate.Year: > 2020 } => Salary += 40f * amount / 2080f,
            { PayType: EmployeePayTypeEnum.Salaried } => Salary += amount,
            _ => Salary += 0
        };
    }

    public override string ToString() {
        return $"Name: {Name}, Id: {GetId()}, Salary: {Salary},  PayType: {PayType}, HireDate: {HireDate}";
    }
}
using Basics.S011_ObjectOrientedProgramming.Enums;

namespace Basics.S011_ObjectOrientedProgramming.Models;

public class Employee {
    // Field data
    private int _age;
    private int _id;
    private string _name;
    private float _pay;
    private EmployeePayTypeEnum _payType;

    // Constructors
    public Employee(string name, int id, float pay, EmployeePayTypeEnum payType) {
        Name = name;
        Id = id;
        Pay = pay;
        PayType = payType;
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

    public int Age {
        get => _age;
        set {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 0, nameof(value));
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

    public EmployeePayTypeEnum PayType {
        get => _payType;
        set => _payType = value;
    }

    // Pattern matching with property patterns
    public void GiveBonus(float amount) {
        ArgumentOutOfRangeException.ThrowIfLessThan(amount, 0, nameof(amount));

        Pay = this switch {
            { Age: >= 18, PayType: EmployeePayTypeEnum.Commission } => Pay += 10f * amount,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly } => Pay += 40f * amount / 2080f,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
            _ => Pay += 0
        };
    }

    public override string ToString() {
        return $"Name: {Name}, Id: {Id}, Pay: {Pay}";
    }
}
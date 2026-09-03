namespace Polymorphism.Models;

internal class SalesPerson : Employee {
    public int SalesNumber { get; set; }

    public SalesPerson(string name, float salary) : base(name, salary) { }

    public sealed override void GiveBonus(float amount) {
        int salesBonus = SalesNumber switch {
            >= 0 and <= 100 => 10,
            >= 101 and <= 200 => 15,
            _ => 20
        };

        base.GiveBonus(amount * salesBonus);
    }

    public override string ToString() {
        return $"Sales Person {{ Name: {Name}, Id: {GetId()}, Salary: {Salary}, SalesNumber: {SalesNumber} }}";
    }
}
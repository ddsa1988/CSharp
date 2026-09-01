namespace BasicInheritance.Models;

internal class SalesPerson : Employee {
    public int SalesNumber { get; set; }

    public SalesPerson(string name, float salary) : base(name, salary) { }

    public override string ToString() {
        return $"Sales Person {{ Name: {Name}, Id: {GetId()}, Salary: {Salary}, SalesNumber: {SalesNumber} }}";
    }
}
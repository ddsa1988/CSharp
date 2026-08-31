namespace BasicInheritance.Models;

internal class SalesPerson : Employee {
    public int SalesNumber { get; set; }

    public SalesPerson(string name, float salary) : base(name, salary) { }
}
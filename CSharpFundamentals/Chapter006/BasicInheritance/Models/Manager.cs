namespace BasicInheritance.Models;

internal class Manager : Employee {
    public int StockOptions { get; set; }

    public Manager(string name, float salary) : base(name, salary) { }

    public override string ToString() {
        return $"Manager {{ Name: {Name}, Id: {GetId()}, Salary: {Salary}, StockOptions: {StockOptions} }}";
    }
}
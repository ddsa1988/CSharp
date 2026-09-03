namespace Polymorphism.Models;

internal class Manager : Employee {
    public int StockOptions { get; set; }

    public Manager(string name, float salary) : base(name, salary) { }

    public override void GiveBonus(float amount) {
        base.GiveBonus(amount);
        Random random = new();
        StockOptions += random.Next(500);
    }

    public override string ToString() {
        return $"Manager {{ Name: {Name}, Id: {GetId()}, Salary: {Salary}, StockOptions: {StockOptions} }}";
    }
}
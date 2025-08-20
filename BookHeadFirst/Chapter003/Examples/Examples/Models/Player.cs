namespace Examples.Models;

public class Player {
    public required string Name { get; init; }
    public int Cash { get; set; }

    public void WriteMyInfo() {
        Console.WriteLine($"{Name} has {Cash:C} bucks");
    }

    public int GiveCash(int amount) {
        if (amount <= 0) {
            Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
            return 0;
        }

        if (amount > Cash) {
            Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
            return 0;
        }

        Cash -= amount;
        return amount;
    }

    public void ReceiveCash(int amount) {
        if (amount <= 0) {
            Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
            return;
        }

        Cash += amount;
    }

    public override string ToString() {
        return $"Player [Name: {Name}, Cash: {Cash:C}]";
    }
}
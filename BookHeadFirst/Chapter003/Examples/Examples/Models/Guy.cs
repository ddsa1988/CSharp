namespace Examples.Models;

public class Guy {
    public required string Name { get; set; }
    public int Cash { get; set; }

    public void WriteMyInfo() {
        Console.WriteLine(Name + " has " + Cash + " bucks");
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
}
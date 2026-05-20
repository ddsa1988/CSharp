namespace Classes.Models;

public class Guy {
    public string Name { get; set; } = string.Empty;
    public int Cash { get; set; }

    /// <summary>
    /// Writes my name and the amount of cash I have to the console
    /// </summary>
    public void WriteMyInfo() {
        Console.WriteLine($"{Name} has {Cash} bucks.");
    }

    /// <summary>
    /// Give some of my cash, removing it from my wallet (or printing a message to the console if I don't have enough cash).
    /// </summary>
    /// <param name="amount">Amount of cash to give.</param>
    /// <returns>The amount of cash removed from my wallet or 0 if I don't have enough cash or if the amount is invalid.</returns>
    public void GiveCash(int amount) {
        if (amount <= 0) {
            Console.WriteLine($"{Name} says: ${amount} isn't a valid amount.");
            return;
        }

        if (amount > Cash) {
            Console.WriteLine($"{Name} says: I don't have enough cash to give you ${amount}.");
            return;
        }

        Cash -= amount;
    }

    /// <summary>
    /// Receive some cash, adding it to my wallet or printing a message to the console if the amount is invalid
    /// </summary>
    /// <param name="amount">Amount of cash to receive.</param>
    public void ReceiveCash(int amount) {
        if (amount <= 0) {
            Console.WriteLine($"{Name} says: ${amount} isn't an amount I'll take.");
        }

        Cash += amount;
    }
}
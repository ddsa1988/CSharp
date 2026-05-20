using Classes.Models;

namespace Classes.Examples;

public static class UsingGuyClass {
    public static void Run() {
        var joe = new Guy() { Name = "Joe", Cash = 50 };
        var bob = new Guy() { Name = "Bob", Cash = 100 };

        while (true) {
            joe.WriteMyInfo();
            bob.WriteMyInfo();

            Console.Write("Enter an amount (or a blank line to exit): ");
            string? amountStr = Console.ReadLine();

            if (amountStr == null) continue;

            if (amountStr.Trim() == string.Empty) return;

            bool isAmountValid = int.TryParse(amountStr, out int amount);

            if (!isAmountValid) continue;

            Console.Write("Who should give the cash: ");
            string? witchGuy = Console.ReadLine();

            if (witchGuy == null) continue;

            switch (witchGuy.Trim().ToLower()) {
                case "joe":
                    joe.GiveCash(amount);
                    bob.ReceiveCash(amount);
                    break;
                case "bob":
                    bob.GiveCash(amount);
                    joe.ReceiveCash(amount);
                    break;
                default:
                    Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    break;
            }
        }
    }
}
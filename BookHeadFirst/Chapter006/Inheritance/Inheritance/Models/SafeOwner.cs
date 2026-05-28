namespace Inheritance.Models;

public class SafeOwner {
    private string _valuables = string.Empty;

    public void ReceiveContents(string safeContents) {
        _valuables = safeContents;
        Console.WriteLine($"Thank you for returning my {_valuables}.");
    }
}
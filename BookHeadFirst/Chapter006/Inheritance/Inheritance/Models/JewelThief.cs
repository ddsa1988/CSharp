namespace Inheritance.Models;

public class JewelThief : Locksmith {
    private string _stolenJewels = string.Empty;

    protected override void ReturnContents(string safeContents, SafeOwner owner) {
        _stolenJewels = safeContents;
        Console.WriteLine($"I'm stealing the jewels! I stole: {_stolenJewels}.");
    }
}
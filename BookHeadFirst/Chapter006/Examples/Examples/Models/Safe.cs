namespace Examples.Models;

public class Safe {
    private const string Contents = "precious jewels";
    private const string SafeCombination = "12345";

    public static string Open(string combination) {
        return combination == SafeCombination ? Contents : string.Empty;
    }

    public static void PickLock(LockSmith lockpicker) {
        lockpicker.Combination = SafeCombination;
    }
}

public class SafeOwner {
    private string _valuables = string.Empty;

    public void ReceiveContents(string safeContents) {
        _valuables += safeContents;
        Console.WriteLine($"Thank you for returning my {_valuables}.");
    }
}

public class LockSmith {
    public string Combination { private get; set; } = string.Empty;

    public void OpenSafe(Safe safe, SafeOwner owner) {
        Safe.PickLock(this);
        string safeContents = Safe.Open(Combination);
        ReturnContents(safeContents, owner);
    }

    protected static void ReturnContents(string safeContents, SafeOwner owner) {
        owner.ReceiveContents(safeContents);
    }
}

public class JewelThief : LockSmith {
    private string _stolenJewels = string.Empty;

    protected void ReturnContents(string safeContents, SafeOwner owner) {
        _stolenJewels = safeContents;
        Console.WriteLine($"I'm stealing the jewels! I stole: {_stolenJewels}");
    }
}
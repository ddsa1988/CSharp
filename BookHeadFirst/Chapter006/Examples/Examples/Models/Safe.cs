namespace Examples.Models;

public class Safe {
    private string Contents { get; }
    private string SafeCombination { get; }

    public Safe(string contents, string safeCombination) {
        Contents = contents;
        SafeCombination = safeCombination;
    }

    public string Open(string combination) {
        return combination == SafeCombination ? Contents : string.Empty;
    }

    public void PickLock(LockSmith lockpicker) {
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
        safe.PickLock(this);
        string safeContents = safe.Open(Combination);
        ReturnContents(safeContents, owner);
    }

    protected virtual void ReturnContents(string safeContents, SafeOwner owner) {
        owner.ReceiveContents(safeContents);
    }
}

public class JewelThief : LockSmith {
    private string _stolenJewels = string.Empty;

    protected override void ReturnContents(string safeContents, SafeOwner owner) {
        _stolenJewels = safeContents;
        Console.WriteLine($"I'm stealing the jewels! I stole: {_stolenJewels}.");
    }
}
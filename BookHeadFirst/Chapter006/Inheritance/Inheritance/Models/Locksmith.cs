namespace Inheritance.Models;

public class Locksmith {
    public string Combination { private get; set; } = string.Empty;

    public void OpenSafe(Safe safe, SafeOwner owner) {
        Safe.PickLock(this);
        string safeContents = Safe.Open(Combination);
        ReturnContents(safeContents, owner);
    }

    protected virtual void ReturnContents(string safeContents, SafeOwner owner) {
        owner.ReceiveContents(safeContents);
    }
}
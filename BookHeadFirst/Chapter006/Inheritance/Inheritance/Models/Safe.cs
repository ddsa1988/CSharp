namespace Inheritance.Models;

public class Safe {
    private const string Contents = "Precious jewels";
    private const string SafeCombination = "12345";

    public static string Open(string combination) {
        return combination == SafeCombination ? Contents : string.Empty;
    }

    public static void PickLock(Locksmith lockpicker) {
        lockpicker.Combination = SafeCombination;
    }
}
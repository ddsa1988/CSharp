namespace IndexerMethods.Models;

internal class StringContainerClass : IStringContainer {
    private readonly List<string> _myStrings = [];

    public string this[int index] {
        get => _myStrings[index];
        set => _myStrings.Insert(index, value);
    }
}
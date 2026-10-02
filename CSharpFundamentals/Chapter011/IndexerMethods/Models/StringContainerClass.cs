using System.Collections;

namespace IndexerMethods.Models;

internal class StringContainerClass : IStringContainer, IEnumerable<string> {
    private readonly List<string> _myStrings = [];

    public string this[int index] {
        get => _myStrings[index];
        set => _myStrings.Insert(index, value);
    }

    public IEnumerator<string> GetEnumerator() {
        return _myStrings.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
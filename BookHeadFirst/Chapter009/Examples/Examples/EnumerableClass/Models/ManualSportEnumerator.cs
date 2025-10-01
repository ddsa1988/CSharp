using System.Collections;

namespace Examples.EnumerableClass.Models;

public class ManualSportEnumerator : IEnumerator<Sport> {
    private int _current = -1;

    public bool MoveNext() {
        int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;

        if (_current >= maxEnumValue) return false;

        _current++;
        return true;
    }

    public void Reset() {
        _current = 0;
    }

    public Sport Current => (Sport)_current;

    object? IEnumerator.Current => Current;

    public void Dispose() {
        GC.SuppressFinalize(this);
    }
}
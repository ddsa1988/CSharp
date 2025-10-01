using System.Collections;

namespace Examples.YieldReturn.Models;

public class BetterSportSequence : IEnumerable<Sport> {
    public IEnumerator<Sport> GetEnumerator() {
        int maxEnumValue = Enum.GetValues(typeof(Sport)).Length;

        for (int i = 0; i < maxEnumValue; i++) {
            yield return (Sport)i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    public Sport this[int index] {
        get {
            int maxEnumValue = Enum.GetValues(typeof(Sport)).Length;

            if (index < 0 || index >= maxEnumValue)
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");

            return (Sport)index;
        }
    }
}
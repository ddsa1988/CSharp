using System.Collections;

namespace Examples.YieldReturn.Models;

public class PowerOfTwo : IEnumerable<int> {
    public IEnumerator<int> GetEnumerator() {
        double maxPower = Math.Round(Math.Log(int.MaxValue), 2);

        for (int i = 0; i < maxPower; i++) {
            yield return (int)Math.Pow(2, i);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
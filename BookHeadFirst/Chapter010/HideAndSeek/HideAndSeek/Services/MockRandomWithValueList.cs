namespace HideAndSeek.Services;

public class MockRandomWithValueList : Random {
    private readonly Queue<int> _valuesToReturn;

    public MockRandomWithValueList(IEnumerable<int> values) {
        _valuesToReturn = new Queue<int>(values);
    }

    public int NextValue() {
        int nextValue = _valuesToReturn.Dequeue();
        _valuesToReturn.Enqueue(nextValue);

        return nextValue;
    }

    public override int Next() => NextValue();
    public override int Next(int maxValue) => Next(0, maxValue);

    public override int Next(int minValue, int maxValue) {
        int next = NextValue();
        return next >= minValue && next < maxValue ? next : minValue;
    }
}
namespace HideAndSeek.Services;

public class MockRandom : Random {
    public int ValueToReturn { get; set; }
    public override int Next() => ValueToReturn;
    public override int Next(int maxValue) => ValueToReturn;
    public override int Next(int minValue, int maxValue) => ValueToReturn;
}
namespace Bird.Models;

public class Duck : Aves {
    public KindOfDuck Kind { get; init; }
    public int Size { get; init; }

    public override string ToString() {
        return $"{Size} inch {Kind}";
    }
}
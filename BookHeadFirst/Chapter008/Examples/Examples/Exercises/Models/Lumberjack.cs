namespace Examples.Exercises.Models;

public enum Flapjack {
    Crispy,
    Soggy,
    Browned,
    Banana,
}

public class Lumberjack {
    private readonly Stack<Flapjack> _flapjacks;
    public string Name { get; }

    public Lumberjack(string name) {
        Name = name;
        _flapjacks = new Stack<Flapjack>();
    }

    public void TakeFlapjack(Flapjack flapjack) {
        _flapjacks.Push(flapjack);
    }

    public void EatFlapjack() {
        if (_flapjacks.Count == 0) return;

        Console.WriteLine($"{Name} is eating flapjacks");

        while (_flapjacks.Count > 0) {
            string flapjack = _flapjacks.Pop().ToString().ToLower();
            Console.WriteLine($"{Name} ate a {flapjack}");
        }
    }
}
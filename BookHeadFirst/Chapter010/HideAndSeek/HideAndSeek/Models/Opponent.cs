namespace HideAndSeek.Models;

public class Opponent {
    public string Name { get; }

    public Opponent(string name) {
        Name = name;
    }

    public void Hide() {
        throw new NotImplementedException();
    }

    public override string ToString() => Name;
}
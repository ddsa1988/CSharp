namespace Section017_Linq.Entities;

public class Category {
    private string name = "";
    private int id;
    private int tier;

    public Category(string name, int id, int tier) {
        Name = name;
        Id = id;
        Tier = tier;
    }

    public string Name {
        get => name;
        set => name = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value;
    }

    public int Id {
        get => id;
        set => id = value > 0 ? value : 0;
    }

    public int Tier {
        get => tier;
        set => tier = value > 0 ? value : 0;
    }

    public override string ToString() {
        return "Name: " + Name +
               ", Id: " + Id +
               ", Tier: " + Tier;
    }
}
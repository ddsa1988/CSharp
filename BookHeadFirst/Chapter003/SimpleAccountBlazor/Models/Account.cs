namespace SimpleAccountBlazor.Models;

public class Account {
    private string _name = string.Empty;
    private double _balance;

    public Account(string name) : this(name, 0) { }

    public Account(string name, double balance) {
        Name = name;
        Balance = balance;
    }

    public string Name {
        get => _name;
        set {
            ArgumentException.ThrowIfNullOrEmpty(value, nameof(value));
            ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(value));

            _name = value;
        }
    }

    public double Balance {
        get => _balance;
        set => _balance = value > 0 ? value : 0;
    }
}
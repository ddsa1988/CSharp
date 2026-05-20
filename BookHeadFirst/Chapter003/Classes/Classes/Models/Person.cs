namespace Classes.Models;

public class Person {
    private string _name = string.Empty;
    private DateOnly _birthDate;

    public Person(string name, DateOnly birthDate) {
        Name = name;
        BirthDate = birthDate;
    }

    public string Name {
        get => _name;
        set => _name = string.IsNullOrWhiteSpace(value) ? "" : value;
    }

    public DateOnly BirthDate {
        get => _birthDate;
        set {
            DateOnly now = DateOnly.FromDateTime(DateTime.Now);
            _birthDate = value > now ? now : value;
        }
    }

    public override string ToString() {
        return $"Name: {Name}, BirthDate: {BirthDate}";
    }
}
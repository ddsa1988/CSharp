namespace ObjectOrientedProgramming.Models.Employee;

internal class Person {
    private string _name;
    private DateOnly _birthdate;

    public Person(string name, DateOnly birthdate) {
        Name = name;
        Birthdate = birthdate;
    }

    public string Name {
        get => _name;
        init {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Argument can't be null or empty", nameof(value));
            }

            _name = value;
        }
    }

    public DateOnly Birthdate {
        get => _birthdate;
        init {
            DateTime today = DateTime.Now;
            TimeSpan diff = today - _birthdate.ToDateTime(TimeOnly.MinValue);

            if (diff.Days < 0) {
                throw new ArgumentOutOfRangeException(nameof(value), "Argument can't be greater tha today.");
            }

            _birthdate = value;
        }
    }

    public override int GetHashCode() {
        return HashCode.Combine(Name, Birthdate);
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;
        if (ReferenceEquals(this, obj)) return true;

        return obj is Person other && ToString().Equals(other.ToString());
    }

    public override string ToString() {
        return $"Person [{nameof(Name)} = {Name}, {nameof(Birthdate)} = {Birthdate}]";
    }
}
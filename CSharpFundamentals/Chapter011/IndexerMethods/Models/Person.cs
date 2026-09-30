namespace IndexerMethods.Models;

internal class Person {
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person(string firstName, string lastName, int age) {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName {
        get => _firstName;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("First name cannot be empty.");
            }

            _firstName = value;
        }
    }

    public string LastName {
        get => _lastName;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Last name cannot be empty.");
            }

            _lastName = value;
        }
    }

    public int Age {
        get => _age;
        set {
            if (value < 0) {
                throw new ArgumentException("Age cannot be negative.");
            }

            _age = value;
        }
    }

    public override string ToString() {
        return $"{{ {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Age)}: {Age} }}";
    }
}
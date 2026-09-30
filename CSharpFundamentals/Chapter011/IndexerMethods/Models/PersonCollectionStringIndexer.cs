namespace IndexerMethods.Models;

internal class PersonCollectionStringIndexer {
    private readonly Dictionary<string, Person> _listPeople = new();

    public Person? this[string name] {
        get {
            _listPeople.TryGetValue(name, out Person? person);
            return person;
        }

        set {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentException("Name cannot be null or whitespace.");
            }

            if (value == null) {
                throw new ArgumentException("Value cannot be null.");
            }

            _listPeople[name] = value;
        }
    }

    public int Count => _listPeople.Count;

    public void Clear() => _listPeople.Clear();
}
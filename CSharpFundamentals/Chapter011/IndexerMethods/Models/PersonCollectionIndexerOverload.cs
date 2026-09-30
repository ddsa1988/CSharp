using System.Collections;

namespace IndexerMethods.Models;

internal class PersonCollectionIndexerOverload {
    private readonly List<Person> _people = [];

    public Person this[int index] {
        get {
            if (index < 0 || index >= Count) {
                throw new IndexOutOfRangeException();
            }

            return _people[index];
        }
        set {
            if (index < 0 || index > Count) {
                throw new IndexOutOfRangeException();
            }

            if (index == Count) {
                _people.Insert(index, value);
            }
            else {
                _people[index] = value;
            }
        }
    }

    public Person? this[string firstName] {
        get {
            Person? result = null;

            for (int i = 0; i < Count; i++) {
                if (!this[i].FirstName.Equals(firstName, StringComparison.InvariantCultureIgnoreCase)) continue;

                result = this[i];
                break;
            }

            return result;
        }
    }

    public int Count => _people.Count;
}
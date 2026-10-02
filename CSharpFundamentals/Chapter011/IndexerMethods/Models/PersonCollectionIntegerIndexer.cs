using System.Collections;

namespace IndexerMethods.Models;

internal class PersonCollectionIntegerIndexer : IEnumerable<Person> {
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

    public int Count => _people.Count;

    public IEnumerator<Person> GetEnumerator() {
        return _people.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
using System.Collections;

namespace CustomEnumerator.Models;

internal class Garage3 : IEnumerable {
    private readonly Car[] _cars = new Car[4];

    public Garage3() {
        _cars[0] = new Car("Rusty", 30);
        _cars[1] = new Car("Clunker", 55);
        _cars[2] = new Car("Zippy", 30);
        _cars[3] = new Car("Fred", 35);
    }

    public IEnumerator GetEnumerator() {
        // This will not get thrown until MoveNext() is called
        throw new Exception("This won't get called.");

        foreach (Car car in _cars) {
            yield return car;
        }
    }

    public IEnumerator GetEnumerator1() {
        //This will get thrown immediately
        throw new Exception("This will get called.");

        return ActualImplementation();

        // This is the local function and the actual IEnumerator implementation
        IEnumerator ActualImplementation() {
            foreach (Car car in _cars) {
                yield return car;
            }
        }
    }
}
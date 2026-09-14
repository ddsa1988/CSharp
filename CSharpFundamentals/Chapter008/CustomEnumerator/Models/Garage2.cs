using System.Collections;

namespace CustomEnumerator.Models;

internal class Garage2 : IEnumerable {
    private readonly Car[] _cars = new Car[4];

    public Garage2() {
        _cars[0] = new Car("Rusty", 30);
        _cars[1] = new Car("Clunker", 55);
        _cars[2] = new Car("Zippy", 30);
        _cars[3] = new Car("Fred", 35);
    }

    public IEnumerator GetEnumerator() {
        foreach (Car car in _cars) {
            yield return car;
        }
    }
}
using System.Collections;

namespace CustomEnumerator.Models;

internal class Garage1 : IEnumerable {
    private readonly Car[] _cars = new Car[4];

    public Garage1() {
        _cars[0] = new Car("Rusty", 30);
        _cars[1] = new Car("Clunker", 55);
        _cars[2] = new Car("Zippy", 30);
        _cars[3] = new Car("Fred", 35);
    }

    public IEnumerator GetEnumerator() {
        return _cars.GetEnumerator();
    }

    // Hide the functionality of IEnumerable from the object level
    // IEnumerator IEnumerable.GetEnumerator() {
    //     return _cars.GetEnumerator();
    // }
}
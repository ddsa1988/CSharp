using System.Collections;

namespace CustomEnumerator.Models;

internal class Garage4 : IEnumerable {
    private readonly Car[] _cars = new Car[4];

    public Garage4() {
        _cars[0] = new Car("Rusty", 30);
        _cars[1] = new Car("Clunker", 55);
        _cars[2] = new Car("Zippy", 30);
        _cars[3] = new Car("Fred", 35);
    }


    public IEnumerator GetEnumerator() {
        // Do some error checking here
        return ActualImplementation();

        // This is the local function and the actual IEnumerator implementation
        IEnumerator ActualImplementation() {
            foreach (Car car in _cars) {
                yield return car;
            }
        }
    }

    public IEnumerable GetTheCars(bool returnReversed) {
        // Do some error checking here

        return ActualImplementation();

        IEnumerable ActualImplementation() {
            if (returnReversed) {
                for (int i = _cars.Length - 1; i >= 0; i--) {
                    yield return _cars[i];
                }
            }
            else {
                foreach (Car car in _cars) {
                    yield return car;
                }
            }
        }
    }
}
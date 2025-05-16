using System.Collections;

namespace Chapter003.Interfaces;

public static class Example001 {
    public static void UserMain() {
        // An interface is similar to a class, but only specifies behavior and does not hold state (data)

        var countdown = new Countdown(10);

        while (countdown.MoveNext()) {
            Console.Write(countdown.Current + " ");
        }
    }

    private class Countdown : IEnumerator {
        private readonly int _startValue;
        private int _count;

        public Countdown(int startValue) {
            _startValue = startValue;
            _count = _startValue;
        }

        public bool MoveNext() {
            if (_count <= 0) return false;

            _count--;
            return true;
        }

        public void Reset() {
            _count = _startValue;
        }

        public object Current => _count;
    }
}
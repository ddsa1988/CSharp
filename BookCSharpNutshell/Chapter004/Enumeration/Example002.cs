namespace Chapter004.Enumeration;

public static class Example002 {
    public static void Run() {
        string[] names = ["Diego", "Amanda", "Amora", "Ameixa"];
        int[] numbers = [0, 1, 2, 3, 4];

        var t1 = new Test<string>(names);
        var t2 = new Test<int>(numbers);

        while (t1.MoveNext()) {
            Console.Write(t1.Current + " ");
        }

        Console.WriteLine();

        while (t2.MoveNext()) {
            Console.Write(t2.Current + " ");
        }
    }

    private class Test<T> {
        private int _index = -1;
        private readonly T[] _array;

        public Test(T[] array) {
            _array = array;
        }

        public bool MoveNext() {
            if (_index >= _array.Length - 1) return false;

            _index++;
            return true;
        }

        public void Reset() {
            _index = -1;
        }

        public T? Current => _index >= _array.Length ? default : _array[_index];
    }
}
using System.Text;

namespace Chapter003.Generics;

public static class Example001 {
    public static void Run() {
        // A generic type declares type parameters—placeholder types to be filled in by the
        // consumer of the generic type, which supplies the type arguments.

        var stack = new Stack<int>(3);
        stack.TryPush(10);
        stack.TryPush(11);
        stack.TryPush(12);

        Console.WriteLine(stack);
        Console.WriteLine(stack.Count);

        stack.TryPop(out int _);

        Console.WriteLine(stack);
        Console.WriteLine(stack.Count);
    }

    private class Stack<T> {
        private readonly int _capacity;
        private T?[] _array;
        public int Count { get; private set; }

        public Stack(int capacity) {
            Capacity = capacity;
            Count = 0;
            _array = new T[capacity];
        }

        public bool TryPush(T item) {
            if (IsFull()) return false;

            _array[Count++] = item;
            return true;
        }

        public bool TryPop(out T? item) {
            if (IsEmpty()) {
                item = default(T);
                return false;
            }

            item = _array[--Count];
            _array[Count] = default(T);

            return true;
        }

        public bool IsEmpty() {
            return Count == 0;
        }

        public bool IsFull() {
            return Count == Capacity;
        }

        public void Clear() {
            Count = 0;
            _array = new T[Capacity];
        }

        public int Capacity {
            get => _capacity;
            private init => _capacity = value > 0 ? value : 0;
        }

        public override string ToString() {
            if (Count == 0) return "[]";

            var sb = new StringBuilder();
            sb.Append("[ ");

            int lastIndex = Count - 1;

            for (int i = 0; i < lastIndex; i++) {
                sb.Append(_array[i] + ", ");
            }

            sb.Append(_array[lastIndex] + " ]");

            return sb.ToString();
        }
    }
}
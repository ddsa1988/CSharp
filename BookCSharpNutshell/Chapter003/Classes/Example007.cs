namespace Chapter003.Classes;

public static class Example007 {
    public static void Run() {
        /*
           The get and set accessors can have different access levels. The typical use case for
           this is to have a public property with an internal or private access modifier on the setter.
         */
    }

    private class Foo {
        private decimal _price;

        // These init-only properties act like read-only properties, except that they can also be set via an object initializer
        public int Time { get; init; }

        public decimal Price {
            get => _price;
            private set => _price = value;
        }

        // public void TrySetTime() {
        //     Time++; // Compile error
        // }
    }
}
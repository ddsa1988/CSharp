namespace Chapter003.Inheritance;

public static class Example012 {
    public static void Run() {
        // The "base" keyword can call base class constructor

        var derivedClass = new DerivedClass();
    }

    private class BaseClass {
        public int X { get; set; } = 10;

        public BaseClass() {
            Console.WriteLine("Inside the base class constructor");
            Console.WriteLine("{0} = {1}", nameof(X), X);
        }
    }

    private class DerivedClass : BaseClass {
        public int Y { get; set; } = 20;

        public DerivedClass() : base() {
            Console.WriteLine("Inside the derived class constructor");
            Console.WriteLine("{0} = {1}", nameof(Y), Y);
        }
    }
}
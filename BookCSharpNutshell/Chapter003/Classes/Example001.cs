namespace Chapter003.Classes;

public static class Example001 {
    public static void UserMain() {
        // Simple class example

        var obj1 = new MyClass();
        var obj2 = new MyClass();
    }

    private class MyClass {
        private string _name = string.Empty; // Field
        public int Age { get; set; } // Property
        private const string Greeting = "Hello"; // Constant (It's evaluated at compile time)

        public readonly float
            MyFloat; // Read-only field can be assigned only in its declaration or within the enclosing type’s constructor.

        public MyClass() {
            MyFloat = 1.5f;
        }

        public static void StaticMethod() {
            // Static method
            Console.WriteLine("Static Method");
        }

        public static void StaticMethod(string msg) {
            // Method overload
            Console.WriteLine("Static Method" + " " + msg);
        }

        public void Foo(int x) {
            // Instance method
            Console.WriteLine(x * Age);
        }

        public string GetGreeting(string msg) => Greeting + " " + Age + " " + msg; // Expression-bodied method

        public static void LocalMethod() {
            // The local method (Test) is visible only to the enclosing method (LocalMethod). 
            const int x = 10;

            Console.WriteLine(Test(2));
            Console.WriteLine(Test(4));

            return;

            int Test(int y) => x * y;
        }
    }
}
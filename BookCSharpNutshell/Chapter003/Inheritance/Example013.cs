namespace Chapter003.Inheritance;

public static class Example013 {
    public static void UserMain() {
        // A required member must be populated via an object initializer when constructed

        // var person = new Person(); // Compile-time error
        var person = new Person() { Name = "Diego", Age = 30 };
    }

    private class Person {
        public required string Name { get; set; }
        public required int Age { get; set; }
    }
}
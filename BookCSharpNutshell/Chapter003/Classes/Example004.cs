namespace Chapter003.Classes;

public static class Example004 {
    public static void UserMain() {
        // Object initializers: To simplify object initialization, any accessible fields or properties
        // of an object can be set via an object initializer directly after construction.

        var p1 = new Person() { Name = "Diego", BirthDate = DateOnly.FromDateTime(new DateTime(1988, 01, 22)) };
        Console.WriteLine(p1);
    }

    private class Person {
        public string Name { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; }

        public Person() { }

        public Person(string name, DateOnly birthDate) {
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString() {
            return $"Person {{ Name = {Name}, BirthDate = {BirthDate} }}";
        }
    }
}
namespace Chapter003.Classes;

public static class Example002 {
    public static void Run() {
        // Constructors

        var obj1 = new Person();
        var obj2 = new Person("Diego");
        var obj3 = new Person("Amanda", DateOnly.Parse("1993-10-16"));

        Console.WriteLine("{0} => {1}", nameof(obj1), obj1);
        Console.WriteLine("{0} => {1}", nameof(obj2), obj2);
        Console.WriteLine("{0} => {1}", nameof(obj3), obj3);
    }

    private class Person {
        public string Name { get; set; }
        public DateOnly Birthdate { get; set; }

        public Person() : this(string.Empty, DateOnly.FromDateTime(DateTime.Now)) { }

        public Person(string name) : this(name, DateOnly.FromDateTime(DateTime.Now)) { }

        public Person(string name, DateOnly birthdate) {
            Name = name;
            Birthdate = birthdate;
        }

        public override string ToString() {
            return "Person { " +
                   "Name = " + Name +
                   ", Birthdate = " + Birthdate + " }";
        }
    }
}
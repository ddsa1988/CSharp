namespace Chapter004.Records;

public static class Example004 {
    public static void Run() {
        // When subclassing another record, the copy constructor is responsible for copying only its own fields.
        // To copy the base record’s fields, delegate to the base.

        var st1 = new Student("Diego", "Alexander", 1);
        Student st2 = st1 with { FirstName = "Amanda", LastName = "Perna", Id = 2 };

        Console.WriteLine("{0} => {1}", nameof(st1), st1);
        Console.WriteLine("{0} => {1}", nameof(st2), st2);
    }

    private record Person(string FirstName, string LastName);

    private record Student(string FirstName, string LastName, int Id) : Person(FirstName, LastName);
}
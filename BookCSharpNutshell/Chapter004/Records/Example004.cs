namespace Chapter004.Records;

public static class Example004 {
    public static void Run() {
        // When subclassing another record, the copy constructor is responsible for copying only its own fields.
        // To copy the base record’s fields, delegate to the base.
    }

    private record Person(string FirstName, string LastName);
}
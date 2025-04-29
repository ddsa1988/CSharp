namespace Chapter002.BooleanType;

public static class Example002 {
    public static void UserMain() {
        // For reference types, equality compares the references of the variables

        var p1 = new Person() { Name = "John" };
        var p2 = new Person() { Name = "John" };
        Person p3 = p1;

        Console.WriteLine("{0} == {1} = {2}", nameof(p1), nameof(p2), p1 == p2);
        Console.WriteLine("{0} == {1} = {2}", nameof(p1), nameof(p3), p1 == p3);
    }
}

internal class Person {
    public string Name { get; set; } = string.Empty;
}